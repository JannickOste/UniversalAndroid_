using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalAndroid.Forms;
using UniversalAndroid.Forms.Menus;
using SharpAdbClient;
using System.IO;
using UniversalAndroid.Resources;

namespace UniversalAndroid
{
    static class Program
    {
        public enum scrapingModels
        {
            REXDL
        }

        public enum searchMethods
        {
            KEYWORD
        }

        public static AdbServer adb_server = new AdbServer();

        public static RenderingPanel panel { get; set; }
        public static Scripts.ScriptLoader scriptLoader = new Scripts.ScriptLoader();
        public static List<DownloadClient> dl_clients = new List<DownloadClient>();

        /**
         * Initisation procedure of the program,
         * - Checking filepaths / starting server instance / assigning default panels / etc..
         */
        static bool init()
        {
            bool init_error = false;

            try
            {
                // Check the filepaths.
                foreach (var filepath in new[] {
                    Resources.Filepaths.ADB_LOCATION,
                    Resources.Filepaths.DOS_LOCATION,
                    System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), Resources.Filepaths.APP_DATA_LOCATION)
                })
                    if (!(System.IO.File.Exists(filepath) | System.IO.Directory.Exists(filepath)))
                    {
                        MessageBox.Show(String.Format("Unable to detect the file \"{0}\", Reinstall your program", filepath));
                        Environment.Exit(-1);
                    }


                // Start the adb server in background & set the main rendering panel where user controls will be rendered upon.
                adb_server.StartServer(Resources.Filepaths.ADB_LOCATION, true);
            } 
            catch 
            { 
                init_error = true; 
            }

            return !init_error;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Start init procedure, if procedure was succesfull start application.
            if(init())
            {
                // Default form initiation. 
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Create the mainpanel and apply the default styling.
                panel = new RenderingPanel();
                ControlAssist.applyPanelDefaults(panel);

                // (Start/Show) the default panel
                Application.Run(panel);
            }
        }


        public static void setRenderingPanel(UserControl new_panel)
        {
            panel.renderPanel.Controls.Clear();
            panel.renderPanel.Controls.Add(new_panel);

        }
    }
}
