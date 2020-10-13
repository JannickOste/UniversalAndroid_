using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using UniversalAndroid.Scripts;
using UniversalAndroid.Forms.UIPanels;
using SharpAdbClient;

namespace UniversalAndroid.Forms.Menus
{
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();


            this.menu_options = new List<MenuListening>()
            {
                new MenuListening( // Launch a custom script.
                    header:      "Start a custom script over ADB",
                    description: "- Automated android tasks/applications *bot-scripts*",
                    image:       global::UniversalAndroid.Properties.Resources.script_64x64,
                    action:      new Action(() => Program.setRenderingPanel(new ScriptMenu()))
                ),
                new MenuListening(
                    header:     "Open a shell prompt over ADB",
                    description: "- Usefull for *testing/debugging* phones/functionality",
                    image:       global::UniversalAndroid.Properties.Resources.terminal,
                    action:      new Action(() =>
                    {
                        if(AdbClient.Instance.GetDevices().Count() == 0) MessageBox.Show("Unable to detect any devices with adb enabled");
                        else Program.setRenderingPanel(new ShellPrompt());
                    })
                ),
                new MenuListening( // APK/OBB Scraper.
                    header:      "Application data search / management / injection",
                    description: "- Download/Remove/Update/Inject application data",
                    image:       global::UniversalAndroid.Properties.Resources.android_64x64,
                    action:      new Action(() => Program.setRenderingPanel(new DataManagment()))
                )
            };
        }

        public List<MenuListening> menu_options { get; set; }


        private void StartScreen_Load(object sender, EventArgs e)
        {
            foreach (var option in this.menu_options)
            {
                option.Width = this.menuPanel.Width - 10;

                this.menuPanel.Controls.Add(option);
            }
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
