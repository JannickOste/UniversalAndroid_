using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalAndroid.Forms
{
    class FormEventHandler
    {

        /**
         * Sending a message calback to a specific window invoking a window based event.
         */

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        /**
         * Form events.
         */
        public static void Event_Draw_MainPanel(Form target, PaintEventArgs e)
        {
            // First time refresh, otherwise button images did not get propperly loaded.
            if (target.FormBorderStyle != FormBorderStyle.None)
            {
                target.FormBorderStyle = FormBorderStyle.None;
                target.Refresh();
            }
            ControlPaint.DrawBorder(e.Graphics, target.ClientRectangle, System.Drawing.Color.Black, ButtonBorderStyle.Solid);
        }

        /**
         * Button events.
         */
        public static void Event_MenuButton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = io.ImageHandler.LoadBase64Image(Resources.Images.DARKGRAY_BUTTON_HOVER);
        }

        public static void Event_MenuButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = io.ImageHandler.LoadBase64Image(Resources.Images.DARKGRAY_BUTTON);
        }


        /**
         * ListView events.
         */

        public static void Event_BlockListViewWidthChange(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
        }

        public static void Event_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Draw Background.
            e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 40, 40, 40)), e.Bounds);

            //// Draw Text
            using (var sf = new System.Drawing.StringFormat())
            {
                sf.Alignment = System.Drawing.StringAlignment.Center;

                using (var headerFont = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Regular))
                {
                    // Add small vertical offset for text.
                    var text_bounds = e.Bounds;
                    text_bounds.Y += 4;

                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        System.Drawing.Brushes.White, text_bounds, sf);
                }

            }
        }

        // Default draw for the listview item, if not applied when ownerdraw is enabled 
        public static void Event_DrawListViewItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        /**
         * Table layout 
         */

    }
}
