using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UniversalAndroid.Forms.Menus;
using UniversalAndroid.Forms.Controls;
using System.IO;
using SharpAdbClient;
using SharpAdbClient.DeviceCommands;

namespace UniversalAndroid.Forms.UIPanels
{
    public partial class DataManagment : UserControl
    {
        private bool autoscrape = false;
        private List<ScraperData> search_results = new List<ScraperData>();
        private APKScraper scraper = new APKScraper();
        private string data_filepath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), Resources.Filepaths.APP_DATA_LOCATION);

        public DataManagment()
        {
            InitializeComponent();
        }

        private void APKScraper_Load(object sender, EventArgs e)
        {

            foreach (var btn in new[] { manualScrapeBtn, autoScrapeButton, startDownloads, backButton, injectButton, deleteButton, searchBtn})
            {
                // if button delete anchor left, if inject button anchor right otherwise apply usual centered anchor.
                AnchorStyles anchor = !(new[] { injectButton.Name, deleteButton.Name }.Contains(btn.Name)) ? (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom)
                : deleteButton.Name == btn.Name ? AnchorStyles.Left : AnchorStyles.Right;

                // Apply global button styling to button.
                ControlAssist.applyButtonStyling(btn, anchor);

                // Apply button events.
                btn.MouseEnter += FormEventHandler.Event_MenuButton_MouseEnter;
                btn.MouseLeave += FormEventHandler.Event_MenuButton_MouseLeave;
                btn.Click += Event_Click;
            }

            // Add listview events.
            fileList.DrawItem += FormEventHandler.Event_DrawListViewItem;
            fileList.DrawColumnHeader += FormEventHandler.Event_DrawColumnHeader;
            fileList.ColumnWidthChanging += FormEventHandler.Event_BlockListViewWidthChange;

            /**
             * Create a watchguard that checks downloads & files and populate lists based on search opened or not.
             */
            TaskHandler.createGuardedTask("background", watchGuardTask());
        }

        /**
         * Sets label for search results/active downloads based on new control set/data in field.
         */
        private void downloadSelectionList_ControlChanged(object sender, ControlEventArgs e)
        {
            var downloadSelectionListviews = downloadSelectionList.Controls.OfType<ListView>();

            if (downloadSelectionListviews.Count() > 0 && downloadSelectionListviews.FirstOrDefault().Items.Count > 0)
                label4.Text = "Search results:";
            else if (downloadSelectionList.Controls.OfType<DownloadListening>().Count() > 0 || downloadSelectionList.Controls.Count == 0)
                label4.Text = "Active downloads:";

            downloadSelectionList.Refresh();
        }

        /**
         * Actions for when a single mouse click is detected upon a control;
         */
        private void Event_Click(object sender, EventArgs e)
        {
            string target_name = ((Button)sender).Name;

            switch (target_name)
            {
                /**
                 *  (intro screen)
                 */
                // Selecting a scraping mode
                case "autoScrapeButton":
                case "manualScrapeBtn":
                    this.autoscrape = ((Button)sender).Name.ToLower().Contains("auto");

                    // Swap visibility items
                    foreach (var panelconf in new List<(Control, bool)> { (selectPanel, false), (managementPanel, true) })
                    {
                        panelconf.Item1.Visible = panelconf.Item2;
                        panelconf.Item1.Enabled = panelconf.Item2;
                    }

                    this.populateFileList();
                    break;

                /**
                 * Main management screen.
                 */

                // Going back to the main menu.
                case "backButton":
                    TaskHandler.cancelTasksWithKey("background");
                    Program.setRenderingPanel(new StartScreen());
                    break;
                
                //  Searching for an application 
                case "searchBtn":
                    if ((string.IsNullOrEmpty(searchBox.Text) | string.IsNullOrWhiteSpace(searchBox.Text)))
                        MessageBox.Show("Unable to search without searching term.");
                    else
                    {
                        List<ScraperData> scrapes_set = scraper.fetchDownloadData(searchBox.Text);

                        // Check or results have been found.
                        if (scrapes_set.Count() == 0) MessageBox.Show(String.Format("No search results for: {0}", searchBox.Text));
                        else
                        {
                            // If results have found, clear download/search panel.
                            search_results.Clear();
                            downloadSelectionList.Controls.Clear();

                            // if manualy scraping generate a result list.
                            if (!autoscrape) manualScrape(scrapes_set);
                            else
                            {
                                // otherwise just start downloading first found item.
                                foreach (var dl_source in new[] { scrapes_set.First().apk_link, scrapes_set.First().obb_link })
                                    if (!string.IsNullOrEmpty(dl_source))
                                    {
                                        var client = new DownloadClient(dl_source, System.IO.Path.Combine(data_filepath, dl_source.Split('/').Last()));
                                        client.startAsync();

                                        Program.dl_clients.Add(client);
                                    }
                            }
                        }
                    }
                    break;
                
                // Deleting an item from the filesystem.
                case "deleteButton":
                    bool delete = true;
                    if (fileList.SelectedItems.Count == 1)
                        delete = MessageBox.Show(String.Format("Are you sure you wish to delete {0}", fileList.SelectedItems[0].Text), "", MessageBoxButtons.YesNo) == DialogResult.OK;
                    else if (fileList.SelectedItems.Count == 0) MessageBox.Show("No item(s) selected to delete");

                    if (delete)
                        foreach (ListViewItem selected_item in fileList.SelectedItems)
                        {
                            var path = System.IO.Path.Combine(data_filepath, selected_item.Text);

                            if (selected_item.Text.ToLower().EndsWith("apk")) System.IO.File.Delete(path);
                            else
                            {
                                foreach (var file in System.IO.Directory.EnumerateFiles(path))
                                    System.IO.File.Delete(file);

                                System.IO.Directory.Delete(path);
                            }
                        }
                    break;

                // Injecting application over adb.
                case "injectButton":
                    if (AdbClient.Instance.GetDevices().Count() == 0) MessageBox.Show("No devices with adb enabled have been connected...");
                    else
                    {

                        foreach (ListViewItem selected_item in fileList.SelectedItems)
                        {
                            var listobj = selected_item.Text;
                            var path = System.IO.Path.Combine(data_filepath, listobj);
                            if (path.ToLower().EndsWith("apk"))
                            {
                                bool inject = true;
                                if (Program.dl_clients.Where(i => i.Uri.Contains(listobj.Substring(0, listobj.Length - 5)) && i.progressPercentage != 100).Count() > 0)
                                    // Auto cancel injection if more as one item has been selected, 
                                    // ex: loop get skipped anyway if none where selected.
                                    inject = (fileList.SelectedItems.Count != 1 ? false : MessageBox.Show("Application data has not finished downloading yet, do you wish to continue? (If obb data not injected before, application wont work)", "", MessageBoxButtons.YesNo) == DialogResult.OK);

                                if (inject)
                                {
                                    var devices = AdbClient.Instance.GetDevices();
                                    foreach (var device in devices)
                                    {
                                        TaskHandler.createGuardedTask(
                                            cancel_source_key: "adb_action",
                                            break_on_finish: true,
                                            thread_action: new Action(() =>
                                            {
                                                try
                                                {
                                                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                                                        AdbClient.Instance.Install(device, stream);

                                                    if (devices.Count() == 1) MessageBox.Show("Sucessfully installed application");
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(String.Format("Unable to install {0} to {1}", path, device.Name));
                                                    Console.WriteLine("Injection exception: {0}", ex.Message);
                                                }
                                            }));
                                    }

                                }
                            }
                            else if (fileList.SelectedItems.Count != 1) MessageBox.Show("Cannot inject application based on obb data");
                        }
                    }
                    break;
            }
        }

        /**
         * Panel (function)ality.
         */

        private void populateFileList()
        {
            // Fetch list of valid applications within data folder.
            foreach(var path in System.IO.Directory.EnumerateFiles(data_filepath).Where(i => i.EndsWith("apk")))
            {
                var filename = path.Split('\\').Last();
                var size = Math.Round(
                    filename.ToLower().EndsWith("apk") 
                    ? ((double)new FileInfo(System.IO.Path.Combine(path)).Length / 1000000)
                    : ((double)new DirectoryInfo(path).GetFiles().Sum(file => file.Length) / 1000000), 2); // Just scan files due .obb file being only file

                if (!Program.dl_clients.Where(client => client.progressPercentage != 100).Select(i => i.Uri.Split('/').Last()).Contains(filename))
                    this.fileList.Items.Add(new ListViewItem(new[]
                    {
                        filename, String.Format("{0} MB", size.ToString(), "")
                    }));
            }
        }

        /**
         * Background task for checking download activity updating panels/entries.
         */
        private Action watchGuardTask()
        {
            return new Action(() =>
            {
                while (true)
                {
                    // Populate flowlayout based on (download section/ selection section) enabled.
                    if (this.downloadSelectionList.Controls.OfType<ListView>().Count() == 0)
                    {
                        var active_clients = Program.dl_clients.Where(client => client.progressPercentage != 100);
                        this.downloadSelectionList.BeginInvoke((MethodInvoker)delegate
                        {
                            if (active_clients.Count() != this.downloadSelectionList.Controls.Count)
                            {

                                this.fileList.Items.Clear();
                                foreach (var client in active_clients)
                                {
                                    var listitem = new DownloadListening(client.Uri.Split('/').Last());
                                    this.downloadSelectionList.Controls.Add(listitem);
                                }

                                this.populateFileList();
                            }
                        });
                    }

                    System.Threading.Thread.Sleep(2000);
                }
            });
        }

        /**
         * If manual scraping is selected, create a list with search results and add click action to start download if double clicked.
         */
        private void manualScrape(List<ScraperData> scrapes_set)
        {
            // Create a listview for the search results, adjust params and insert columns.
            var selection_listview = ControlAssist.createListView("selection_listview", columnHeaders: new List<string>() { "Application", "OBB data found"});
            selection_listview.Width = downloadSelectionList.Width;
            selection_listview.Height = downloadSelectionList.Height;
            selection_listview.Columns.OfType<ColumnHeader>().ToList().ForEach(header => header.Width = (this.downloadSelectionList.Width / 100) * (header.Name.StartsWith("A") ? 80 : 36) - 1);
           
            // Inject double click action for starting the download.
            selection_listview.DoubleClick += new EventHandler((s, ev) =>
            {
                if (((ListView)s).SelectedItems.Count > 0)
                {
                    var dl_data = search_results.Where(i => i.apk_link.Contains(((ListView)s).SelectedItems[0].Text)).FirstOrDefault();

                    if (dl_data != null)
                    {
                        foreach (var dl_source in new[] { dl_data.apk_link, dl_data.obb_link })
                            if (!string.IsNullOrEmpty(dl_source))
                            {
                                var client = new DownloadClient(dl_source, System.IO.Path.Combine(data_filepath, dl_source.Split('/').Last()));
                                client.startAsync();

                                Program.dl_clients.Add(client);
                            }
                        label4.Text = "Active downloads:";
                    }

                    this.downloadSelectionList.Controls.Clear();
                }
            });
            
            // Loop through all available scrapes and populate within generated listview.
            foreach (var dl_data in scrapes_set)
            {
                if (!string.IsNullOrEmpty(dl_data.apk_link))
                {
                    selection_listview.Items.Add(new ListViewItem(new[] { dl_data.apk_link.Split('/').Last(), (!string.IsNullOrEmpty(dl_data.obb_link)).ToString() }));
                    search_results.Add(dl_data);
                }
            }

            downloadSelectionList.Controls.Add(selection_listview);
        }

    }
}
