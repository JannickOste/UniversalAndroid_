using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalAndroid
{
    class DownloadClient : System.Net.WebClient
    {

        public string outputLocation { get; set; }
        public string Uri { get; set; }
        public int bytesToDownload { get; private set; }
        public int progressPercentage { get; private set; }



        public DownloadClient(string uri, string output_location)
        {
            this.Uri = uri;
            this.outputLocation = output_location;

            // Progression event.
            this.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

            // Finalizing event.
            this.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(client_DownloadCompleted);
        }

        public void startAsync()
        {
            if (string.IsNullOrEmpty(Uri) | string.IsNullOrEmpty(outputLocation)) throw new ArgumentNullException();

            this.DownloadFileAsync(new System.Uri(this.Uri), this.outputLocation);
        }

        /**
         *  Events
         */
        private void client_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {

            this.bytesToDownload = int.Parse(e.TotalBytesToReceive.ToString());
            this.progressPercentage = int.Parse(e.ProgressPercentage.ToString());

        }

        void client_DownloadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

            if (this.Uri.EndsWith("zip"))
            {
                TaskHandler.createGuardedTask("zip_extract", new Action(() =>
                {
                    var filename = this.Uri.Split('/').Last();

                    var sourceDirectory = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), Resources.Filepaths.APP_DATA_LOCATION, filename.Substring(0, filename.Length - 4));

                    // Unzip to dir if not been extracted before
                    if (!System.IO.Directory.Exists(sourceDirectory))
                        System.IO.Compression.ZipFile.ExtractToDirectory(
                            sourceArchiveFileName: System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), Resources.Filepaths.APP_DATA_LOCATION, filename),
                            destinationDirectoryName: sourceDirectory);

                    if (System.IO.Directory.Exists(sourceDirectory))
                    {
                        var obb_directory = System.IO.Directory.EnumerateDirectories(sourceDirectory).Where(i => i.Contains(".")).First();
                        if (!string.IsNullOrEmpty(obb_directory))
                        {

                            var destinationDirectory = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), Resources.Filepaths.APP_DATA_LOCATION, obb_directory.Split('\\').Last());

                            // extract obb dir to root.
                            System.IO.Directory.Move(obb_directory, destinationDirectory);

                            foreach (var file in System.IO.Directory.EnumerateFiles(sourceDirectory))
                                System.IO.File.Delete(file);

                            System.IO.Directory.Delete(sourceDirectory);
                            System.IO.File.Delete(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), Resources.Filepaths.APP_DATA_LOCATION, filename));
                        }
                    }
                }));
            }
        }
    }
}
