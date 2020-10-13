using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalAndroid.Forms
{
    public partial class MenuListening : UserControl
    {
        private Image base_image = null;
        private Image hover_image = null;

        private Color base_background_color;
        private Color hover_color;

        private Action click_action = null;


        public MenuListening(string header = "MenuOption", string description = "", Image image = null, Image hover_image = null, Action action = null, Color? hover_color = null)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(header)) this.headerLabel.Text = header;
            if (!string.IsNullOrEmpty(description)) this.descriptionLabel.Text = description;
            if (image != null)
            {
                this.base_image = image;
                this.pictureBox1.Image = this.base_image;
            }

            this.click_action = action;

            this.base_background_color = this.BackColor;
            this.hover_color = hover_color.HasValue ? hover_color.Value : Color.FromArgb(255, 35, 35, 35);
            this.hover_image = hover_image;
        }


        private void Event_MouseLeave(object sender, EventArgs e)
        {
            var mouseloc = System.Windows.Forms.Cursor.Position;
            // Position check(disables flickering on hovering multiple controls).
            if (!(mouseloc.X > this.Location.X & mouseloc.X < this.Location.X + this.Size.Width &
                mouseloc.Y > this.Location.Y & mouseloc.Y < this.Location.Y + this.Size.Height))
            {
                if(this.base_image != null) this.pictureBox1.Image = this.base_image;
                this.BackColor = this.base_background_color;
            }
        }


        private void Event_MouseEnter(object sender, EventArgs e)
        {
            if(this.hover_image != null) this.pictureBox1.Image = this.hover_image;
            this.BackColor = this.hover_color;
        }

        private void Event_Click(object sender, EventArgs e)
        {
            if (this.click_action != null) this.click_action();
        }
    }
}
