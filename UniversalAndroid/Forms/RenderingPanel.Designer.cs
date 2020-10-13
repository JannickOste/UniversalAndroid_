namespace UniversalAndroid
{
    partial class RenderingPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.renderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.closeWindow = new System.Windows.Forms.Button();
            this.minimizeWindow = new System.Windows.Forms.Button();
            this.defaultPanelWrapper = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.defaultPanelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // renderPanel
            // 
            this.renderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderPanel.Location = new System.Drawing.Point(3, 38);
            this.renderPanel.Name = "renderPanel";
            this.renderPanel.Size = new System.Drawing.Size(963, 508);
            this.renderPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(893, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Universal android - Oste Jannick";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Invoke_MouseDrag);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.closeWindow, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.minimizeWindow, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(963, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // closeWindow
            // 
            this.closeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeWindow.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeWindow.FlatAppearance.BorderSize = 0;
            this.closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindow.Image = global::UniversalAndroid.Properties.Resources.close_window_32;
            this.closeWindow.Location = new System.Drawing.Point(928, 0);
            this.closeWindow.Margin = new System.Windows.Forms.Padding(0);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(35, 29);
            this.closeWindow.TabIndex = 0;
            this.closeWindow.UseVisualStyleBackColor = false;
            this.closeWindow.Click += new System.EventHandler(this.Event_Click);
            this.closeWindow.MouseEnter += new System.EventHandler(this.Event_MouseEnter);
            this.closeWindow.MouseLeave += new System.EventHandler(this.Event_MouseLeave);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeWindow.FlatAppearance.BorderSize = 0;
            this.minimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeWindow.Image = global::UniversalAndroid.Properties.Resources.maximize_window_32;
            this.minimizeWindow.Location = new System.Drawing.Point(893, 0);
            this.minimizeWindow.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(35, 29);
            this.minimizeWindow.TabIndex = 4;
            this.minimizeWindow.UseVisualStyleBackColor = false;
            this.minimizeWindow.Click += new System.EventHandler(this.Event_Click);
            this.minimizeWindow.MouseEnter += new System.EventHandler(this.Event_MouseEnter);
            this.minimizeWindow.MouseLeave += new System.EventHandler(this.Event_MouseLeave);
            // 
            // defaultPanelWrapper
            // 
            this.defaultPanelWrapper.ColumnCount = 1;
            this.defaultPanelWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.defaultPanelWrapper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.defaultPanelWrapper.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.defaultPanelWrapper.Controls.Add(this.renderPanel, 0, 1);
            this.defaultPanelWrapper.Location = new System.Drawing.Point(1, 2);
            this.defaultPanelWrapper.Name = "defaultPanelWrapper";
            this.defaultPanelWrapper.RowCount = 2;
            this.defaultPanelWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.defaultPanelWrapper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.defaultPanelWrapper.Size = new System.Drawing.Size(969, 549);
            this.defaultPanelWrapper.TabIndex = 5;
            // 
            // RenderingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(971, 551);
            this.Controls.Add(this.defaultPanelWrapper);
            this.Name = "RenderingPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Invoke_MouseDrag);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.defaultPanelWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeWindow;
        public System.Windows.Forms.FlowLayoutPanel renderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button minimizeWindow;
        private System.Windows.Forms.TableLayoutPanel defaultPanelWrapper;
    }
}

