using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalAndroid.Forms.Controls
{
    public partial class DownloadListening : UserControl
    {
        public DownloadListening(string name)
        {
            InitializeComponent();
            this.nameLbl.Text = name;
        }

        private void DownloadListening_Load(object sender, EventArgs e)
        {

        }
    }
}
