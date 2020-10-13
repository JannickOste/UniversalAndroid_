using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalAndroid.Forms.Menus;

namespace UniversalAndroid
{
    class ScriptModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Image ImageIcon = null;

        private ListView logger_output { get; set;  }


        public ScriptModel(string name, string description = "", Image image_icon = null)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();

            this.Name = name;
            this.Description = description;
            this.ImageIcon = image_icon;
        }

        internal void addLogMessage(string message, params string[] formats)
        {
            try
            {
                this.logger_output.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate {
                    logger_output.Items.Add(formats.Count() > 0 ? String.Format(message, formats) : message); 
                });
            }
            catch { }
        }

        public virtual void Main()
        {
            throw new NotImplementedException();
        }

        private void start()
        {
            if(this.logger_output.Items.Count == 0) this.addLogMessage("Starting script: {0}", this.Name);
            Main();
        }

        public Action GetModelAsAction(bool loop = false, ListView logger_output = null)
        {
            this.logger_output = logger_output;
            if (!loop)
                return start;
            else return new Action(() =>
            {
                while (true)
                {
                    this.start();
                    System.Threading.Thread.Sleep(2000);
                }
            });
        }

    }
}
