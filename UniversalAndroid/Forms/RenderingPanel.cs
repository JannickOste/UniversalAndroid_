using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UniversalAndroid.Forms;
using UniversalAndroid.Forms.Menus;

namespace UniversalAndroid
{
    public partial class RenderingPanel : System.Windows.Forms.Form
    {
        // Window drawing override.
        protected override void OnPaint(PaintEventArgs e) => FormEventHandler.Event_Draw_MainPanel(this, e);

        public RenderingPanel()
        {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Assign images.
            foreach ((Button btn, Image img) conf_set in new[] {
                (minimizeWindow, io.ImageHandler.LoadBase64Image(Resources.Images.MINIMIZE_WINDOW)),
                (closeWindow, io.ImageHandler.LoadBase64Image(Resources.Images.CLOSE_WINDOW))
            }) conf_set.btn.Image = conf_set.img;

            // Assign the startup panel.
            Program.setRenderingPanel(new StartScreen());
        }

        /**
         * Main screen window events.
         */
        private void Invoke_MouseDrag(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormEventHandler.ReleaseCapture();
                FormEventHandler.SendMessage(Handle, FormEventHandler.WM_NCLBUTTONDOWN, FormEventHandler.HT_CAPTION, 0);
            }
        }

        /**
         * Actions for when a single mouse click is detected upon a control;
         */
        private void Event_Click(object sender, EventArgs e)
        {
            string target_name = ((Button)sender).Name;

            switch (target_name)
            {
                case "minimizeWindow":
                    this.WindowState = FormWindowState.Minimized;
                    break;

                case "closeWindow":
                    if (Program.dl_clients.Count(i => i.progressPercentage != 100) == 0 ? true 
                        :  MessageBox.Show("You still have active downloads pending in the background, are you sure you wish to exit? (this will stop all active downloads)", "", MessageBoxButtons.YesNo) == DialogResult.OK)
                    {
                        TaskHandler.cancelAll();
                        this.Close();
                    }
                    break;
            }
        }

        /**
         * Actions for when mouse enters a specific control.
         */
        private void Event_MouseEnter(object sender, EventArgs e)
        {
            // Var specified if some more functionality should be added.
            string target_name = ((Button)sender).Name;

            switch (target_name)
            {
                case "minimizeWindow":
                    ((Button)sender).Image = io.ImageHandler.LoadBase64Image(Resources.Images.MINIMIZE_WINDOW_HOVER);
                    break;

                case "closeWindow":
                    ((Button)sender).Image = io.ImageHandler.LoadBase64Image(Resources.Images.CLOSE_WINDOW_HOVER);
                    break;
            }
        }

        /**
         * Actions for when mouse leaves a specific control.
         */
        private void Event_MouseLeave(object sender, EventArgs e)
        {
            string target_name = ((Button)sender).Name;

            switch (target_name)
            {
                case "minimizeWindow":
                    ((Button)sender).Image = io.ImageHandler.LoadBase64Image(Resources.Images.MINIMIZE_WINDOW);
                    break;

                case "closeWindow":
                    ((Button)sender).Image = io.ImageHandler.LoadBase64Image(Resources.Images.CLOSE_WINDOW);
                    break;
            }
        }
    }
}
