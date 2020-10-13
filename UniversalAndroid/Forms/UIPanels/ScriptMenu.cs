using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalAndroid.Forms.Menus
{
    public partial class ScriptMenu : UserControl
    {

        private Action bound_mainloop = null;

        public ScriptMenu()
        {
            InitializeComponent();
        }

        /**
         * Loading procedure create the panel content and assign the events to each button.
         */
        private void ScriptMenu_Load(object sender, EventArgs e)
        {
            CreatePanelContent();

            // Assign hover events to buttons.
            foreach(Button target in new[] { backButton, toggleScript})
            {
                // Apply global button styling to button.
                ControlAssist.applyButtonStyling(target);

                // Apply events to button.
                target.MouseEnter += FormEventHandler.Event_MenuButton_MouseEnter;
                target.MouseLeave += FormEventHandler.Event_MenuButton_MouseLeave;
                target.Click += Event_Click;
            }
        }

        /**
         * Actions for when a single moueclick is detected upon a control;
         */
        private void Event_Click(object sender, EventArgs e)
        {
            string target_name = ((Button)sender).Name;

            switch (target_name)
            {
                /**
                 * Pressing go back in menu click.
                 */
                case "backButton":
                    if (this.scriptPanel.Controls.OfType<ListView>().Count() == 0) Program.setRenderingPanel(new StartScreen());
                    else
                    {
                        // Adjust button data.
                        backButton.Text = "Go back to main menu";

                        // Disable the script toggle button.
                        toggleScript.Enabled = false;
                        toggleScript.Visible = false;

                        // Cancel active bound scripts (if required)
                        TaskHandler.cancelTasksWithKey("script");

                        // Recreate the list of scripts.
                        CreatePanelContent();
                    }
                    break;

                /*
                 * Disabeling & enabling the script.
                 */
                case "toggleScript":
                    if (toggleScript.Text.StartsWith("stop"))
                    {
                        TaskHandler.cancelTasksWithKey("script");
                        toggleScript.Text = "Start script";
                    }
                    else
                    {
                        TaskHandler.createGuardedTask("script", this.bound_mainloop);
                        toggleScript.Text = "Stop script";
                    }
                    break;

            }
        }

        /**
         *  Create a panel with all scripts listed and for each option that opens a logger pannel with the scripts & toggles the button data based on the open interface.
         */
        private void CreatePanelContent()
        {
            this.scriptPanel.Controls.Clear();

            foreach (var info in Program.scriptLoader.getScriptInfo())
            {
                // Create menu listening for each script with a new logging screen each execution.
                var menu_item = new MenuListening(
                    header: info.name,
                    description: info.description,
                    image: info.icon,
                    action: new Action(() => 
                    {
                        // Create logging listview and adjust the parameter.
                        var column_headers = new List<string>() { "Logger output:" };
                        ListView loggingview = ControlAssist.createListView("logger_output", columnHeaders: column_headers);
                        loggingview.Width = this.scriptPanel.Width - 10;
                        loggingview.Height = this.scriptPanel.Height - 10;
                        loggingview.FullRowSelect = true;
                        loggingview.Columns[loggingview.Columns.IndexOfKey(column_headers.First())].Width = loggingview.Width-4;

                        // Bind the scripts main loop to a local variable to enable script toggling.
                        this.bound_mainloop = Program.scriptLoader.loadScriptByName(info.name).GetModelAsAction(logger_output: loggingview);

                        // Replace script list with logging view.
                        this.scriptPanel.Controls.Clear();
                        this.scriptPanel.Controls.Add(loggingview);

                        // Adjust the button data
                        backButton.Text = "Go back to scripts";

                        //(re-)enable the script toggle button.
                        toggleScript.Enabled = true;
                        toggleScript.Visible = true;
                        toggleScript.Text = "Stop script";


                        TaskHandler.createGuardedTask("script", this.bound_mainloop);
                    }
                ));

                menu_item.Width = this.scriptPanel.Width - 10;
                this.scriptPanel.Controls.Add(menu_item);
            }
        }
    }
}
