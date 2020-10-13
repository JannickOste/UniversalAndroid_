namespace UniversalAndroid.Forms.Controls
{
    partial class DownloadListening
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.percentageLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // percentageLbl
            // 
            this.percentageLbl.AutoSize = true;
            this.percentageLbl.BackColor = System.Drawing.Color.Transparent;
            this.percentageLbl.ForeColor = System.Drawing.Color.White;
            this.percentageLbl.Location = new System.Drawing.Point(303, 12);
            this.percentageLbl.Name = "percentageLbl";
            this.percentageLbl.Size = new System.Drawing.Size(159, 13);
            this.percentageLbl.TabIndex = 0;
            this.percentageLbl.Text = "0.00MB/10.00GB - 1000.00 kbs";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(3, 12);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(82, 13);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "download name";
            // 
            // DownloadListening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::UniversalAndroid.Properties.Resources.downloadbg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.percentageLbl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DownloadListening";
            this.Size = new System.Drawing.Size(465, 40);
            this.Load += new System.EventHandler(this.DownloadListening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label percentageLbl;
        private System.Windows.Forms.Label nameLbl;
    }
}
