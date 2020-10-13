using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace UniversalAndroid.Forms
{
    class ControlAssist
    {
        /* default styling colors */
        public static Color default_unhovered_color = Color.FromArgb(255, 30, 30, 30);
        public static Color default_hover_color = Color.FromArgb(255, 40, 40, 40);
        public static Color default_panel_color = Color.FromArgb(255, 0, 0, 0);

        public static ListView createListView(string name = "", Padding? padding = null, View? view = null, Color? backColor = null, Color? foreColor = null, List<string> columnHeaders = null)
        {
            ListView new_list = new ListView();

            // Apply parameters
            new_list.Name = name;
            new_list.Margin = padding.HasValue ? padding.Value : Padding.Empty;
            new_list.View = view.HasValue ? view.Value : View.Details;
            new_list.BackColor = backColor.HasValue ? backColor.Value : System.Drawing.Color.FromArgb(255, 40, 40, 40);
            new_list.ForeColor = foreColor.HasValue ? foreColor.Value : Color.White;
            new_list.OwnerDraw = true;

            // Apply columnheaders if set
            if(columnHeaders != null && columnHeaders.Count() > 0)
            {
                columnHeaders.ForEach(header_text =>
                {
                    ColumnHeader new_header = new ColumnHeader();
                    new_header.Name = header_text;
                    new_header.Text = header_text;
                    new_list.Columns.Add(new_header);
                });
            }

            // Apply events.
            new_list.DrawColumnHeader += FormEventHandler.Event_DrawColumnHeader;
            new_list.DrawItem += FormEventHandler.Event_DrawListViewItem;
            new_list.ColumnWidthChanging += FormEventHandler.Event_BlockListViewWidthChange;

            return new_list;
        }

        public static void applyButtonStyling(Button target, AnchorStyles anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom))
        {
            target.ForeColor = Color.White;
            target.FlatStyle = FlatStyle.Flat;
            target.FlatAppearance.BorderSize = 0;
            target.FlatAppearance.MouseDownBackColor = Color.Transparent;
            target.Font = new Font("Javanese", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            target.Image = io.ImageHandler.LoadBase64Image(Resources.Images.DARKGRAY_BUTTON);
            target.Anchor = anchor;
            target.Width = target.Image.Width;
            target.Height = target.Image.Height;
        }

        public static void applyPanelDefaults(Form target_panel)
        {
            target_panel.BackColor = default_panel_color;
            var control_wrapper = target_panel.Controls.OfType<TableLayoutPanel>().Where(i => i.Name == "defaultPanelWrapper").FirstOrDefault();
            
            if (control_wrapper != null)
            {
            
            }
        }
    }
}
