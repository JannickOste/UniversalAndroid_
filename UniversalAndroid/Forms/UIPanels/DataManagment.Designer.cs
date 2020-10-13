namespace UniversalAndroid.Forms.UIPanels
{
    partial class DataManagment
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
            this.selectPanel = new System.Windows.Forms.TableLayoutPanel();
            this.autoScrapeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.manualScrapeBtn = new System.Windows.Forms.Button();
            this.managementPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataManagementSection = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.injectButton = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.startDownloads = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.downloadSelectionList = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.selectPanel.SuspendLayout();
            this.managementPanel.SuspendLayout();
            this.dataManagementSection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPanel
            // 
            this.selectPanel.ColumnCount = 4;
            this.selectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44481F));
            this.selectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.55519F));
            this.selectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.55519F));
            this.selectPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44482F));
            this.selectPanel.Controls.Add(this.autoScrapeButton, 2, 2);
            this.selectPanel.Controls.Add(this.label1, 1, 1);
            this.selectPanel.Controls.Add(this.manualScrapeBtn, 1, 2);
            this.selectPanel.Location = new System.Drawing.Point(0, 0);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.RowCount = 4;
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.selectPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.selectPanel.Size = new System.Drawing.Size(950, 500);
            this.selectPanel.TabIndex = 0;
            // 
            // autoScrapeButton
            // 
            this.autoScrapeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.autoScrapeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoScrapeButton.FlatAppearance.BorderSize = 0;
            this.autoScrapeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.autoScrapeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.autoScrapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoScrapeButton.ForeColor = System.Drawing.Color.White;
            this.autoScrapeButton.Image = global::UniversalAndroid.Properties.Resources.darkGrayButton;
            this.autoScrapeButton.Location = new System.Drawing.Point(477, 253);
            this.autoScrapeButton.Name = "autoScrapeButton";
            this.autoScrapeButton.Size = new System.Drawing.Size(151, 44);
            this.autoScrapeButton.TabIndex = 2;
            this.autoScrapeButton.Text = "Automated";
            this.autoScrapeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.selectPanel.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a scraping mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manualScrapeBtn
            // 
            this.manualScrapeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manualScrapeBtn.FlatAppearance.BorderSize = 0;
            this.manualScrapeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.manualScrapeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.manualScrapeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualScrapeBtn.ForeColor = System.Drawing.Color.White;
            this.manualScrapeBtn.Image = global::UniversalAndroid.Properties.Resources.darkGrayButton;
            this.manualScrapeBtn.Location = new System.Drawing.Point(320, 253);
            this.manualScrapeBtn.Name = "manualScrapeBtn";
            this.manualScrapeBtn.Size = new System.Drawing.Size(151, 44);
            this.manualScrapeBtn.TabIndex = 3;
            this.manualScrapeBtn.Text = "Manual";
            this.manualScrapeBtn.UseVisualStyleBackColor = true;
            // 
            // managementPanel
            // 
            this.managementPanel.ColumnCount = 2;
            this.managementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.managementPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.managementPanel.Controls.Add(this.dataManagementSection, 0, 0);
            this.managementPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.managementPanel.Enabled = false;
            this.managementPanel.Location = new System.Drawing.Point(0, 0);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.RowCount = 1;
            this.managementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.managementPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.managementPanel.Size = new System.Drawing.Size(950, 500);
            this.managementPanel.TabIndex = 1;
            this.managementPanel.Visible = false;
            // 
            // dataManagementSection
            // 
            this.dataManagementSection.ColumnCount = 2;
            this.dataManagementSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataManagementSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dataManagementSection.Controls.Add(this.deleteButton, 0, 2);
            this.dataManagementSection.Controls.Add(this.injectButton, 1, 2);
            this.dataManagementSection.Controls.Add(this.fileList, 0, 1);
            this.dataManagementSection.Controls.Add(this.label2, 0, 0);
            this.dataManagementSection.Location = new System.Drawing.Point(3, 3);
            this.dataManagementSection.Name = "dataManagementSection";
            this.dataManagementSection.RowCount = 3;
            this.dataManagementSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.dataManagementSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataManagementSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.dataManagementSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.dataManagementSection.Size = new System.Drawing.Size(468, 494);
            this.dataManagementSection.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = global::UniversalAndroid.Properties.Resources.darkGrayButton;
            this.deleteButton.Location = new System.Drawing.Point(3, 452);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 39);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // injectButton
            // 
            this.injectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.injectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.injectButton.FlatAppearance.BorderSize = 0;
            this.injectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectButton.ForeColor = System.Drawing.Color.White;
            this.injectButton.Image = global::UniversalAndroid.Properties.Resources.darkGrayButton;
            this.injectButton.Location = new System.Drawing.Point(317, 452);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(148, 39);
            this.injectButton.TabIndex = 2;
            this.injectButton.Text = "Inject";
            this.injectButton.UseVisualStyleBackColor = true;
            // 
            // fileList
            // 
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.fileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.dataManagementSection.SetColumnSpan(this.fileList, 2);
            this.fileList.ForeColor = System.Drawing.Color.White;
            this.fileList.FullRowSelect = true;
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(0, 30);
            this.fileList.Margin = new System.Windows.Forms.Padding(0);
            this.fileList.Name = "fileList";
            this.fileList.OwnerDraw = true;
            this.fileList.Size = new System.Drawing.Size(468, 419);
            this.fileList.TabIndex = 1;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filepath";
            this.columnHeader1.Width = 228;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "OBB Data found";
            this.columnHeader4.Width = 114;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.dataManagementSection.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.downloadSelectionList, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(478, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 494);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search for application/data:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.searchBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(463, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = global::UniversalAndroid.Properties.Resources.darkGrayButton;
            this.searchBtn.Location = new System.Drawing.Point(315, 0);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(148, 39);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(3, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(307, 35);
            this.searchBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.startDownloads, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.backButton, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 452);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(463, 39);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // startDownloads
            // 
            this.startDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDownloads.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startDownloads.Enabled = false;
            this.startDownloads.FlatAppearance.BorderSize = 0;
            this.startDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDownloads.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDownloads.ForeColor = System.Drawing.Color.White;
            this.startDownloads.Image = global::UniversalAndroid.Properties.Resources.darkGrayButton;
            this.startDownloads.Location = new System.Drawing.Point(0, 0);
            this.startDownloads.Margin = new System.Windows.Forms.Padding(0);
            this.startDownloads.Name = "startDownloads";
            this.startDownloads.Size = new System.Drawing.Size(154, 39);
            this.startDownloads.TabIndex = 7;
            this.startDownloads.Text = "Start download";
            this.startDownloads.UseVisualStyleBackColor = true;
            this.startDownloads.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Image = global::UniversalAndroid.Properties.Resources.darkGrayButton;
            this.backButton.Location = new System.Drawing.Point(308, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(155, 39);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Go back to main menu";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // downloadSelectionList
            // 
            this.downloadSelectionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.downloadSelectionList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downloadSelectionList.Location = new System.Drawing.Point(0, 105);
            this.downloadSelectionList.Margin = new System.Windows.Forms.Padding(0);
            this.downloadSelectionList.Name = "downloadSelectionList";
            this.downloadSelectionList.Size = new System.Drawing.Size(466, 344);
            this.downloadSelectionList.TabIndex = 4;
            this.downloadSelectionList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.downloadSelectionList_ControlChanged);
            this.downloadSelectionList.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.downloadSelectionList_ControlChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Active downloads:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managementPanel);
            this.Controls.Add(this.selectPanel);
            this.Name = "DataManagment";
            this.Size = new System.Drawing.Size(950, 500);
            this.Load += new System.EventHandler(this.APKScraper_Load);
            this.selectPanel.ResumeLayout(false);
            this.selectPanel.PerformLayout();
            this.managementPanel.ResumeLayout(false);
            this.dataManagementSection.ResumeLayout(false);
            this.dataManagementSection.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel selectPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button autoScrapeButton;
        private System.Windows.Forms.Button manualScrapeBtn;
        private System.Windows.Forms.TableLayoutPanel managementPanel;
        private System.Windows.Forms.TableLayoutPanel dataManagementSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel downloadSelectionList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button startDownloads;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
