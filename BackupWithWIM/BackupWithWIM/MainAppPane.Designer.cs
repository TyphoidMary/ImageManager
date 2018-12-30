namespace BackupWithWIM
{
    partial class TotalImageManager
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Settings = new System.Windows.Forms.TabPage();
            this.WaitBoxImage = new System.Windows.Forms.PictureBox();
            this.HyperVPasswordLabel = new System.Windows.Forms.Label();
            this.HyperVServerUsernameLabel = new System.Windows.Forms.Label();
            this.HyperVServerPasswordTextbox = new System.Windows.Forms.TextBox();
            this.HyperVUsernameTextbox = new System.Windows.Forms.TextBox();
            this.GetvSwitchLabel = new System.Windows.Forms.Label();
            this.PingPassedLabel = new System.Windows.Forms.Label();
            this.TestServerConnection = new System.Windows.Forms.Button();
            this.AvailiblevSwitchLabel = new System.Windows.Forms.Label();
            this.AvailiblevSwitchesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SelectVMRepoButton = new System.Windows.Forms.Button();
            this.VMRepoPathTextbox = new System.Windows.Forms.TextBox();
            this.HyperVServerHostnameLabel = new System.Windows.Forms.Label();
            this.VDIServerHostnameTextbox = new System.Windows.Forms.TextBox();
            this.ImageRepoPathTextBox = new System.Windows.Forms.TextBox();
            this.EnableVDICheckbox = new System.Windows.Forms.CheckBox();
            this.CompressionCheckBox = new System.Windows.Forms.CheckBox();
            this.WriteBootSectorCheckBox = new System.Windows.Forms.CheckBox();
            this.StandardFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.QuickFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.FormatDriveCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectImageRepoButton = new System.Windows.Forms.Button();
            this.ImageApplicationTab = new System.Windows.Forms.TabPage();
            this.VistaOrNewerRadioButton = new System.Windows.Forms.RadioButton();
            this.XPBootSectorRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageDriveButton = new System.Windows.Forms.Button();
            this.AvailibleDisks = new System.Windows.Forms.CheckedListBox();
            this.AvailibleImages = new System.Windows.Forms.ComboBox();
            this.CaptureTab = new System.Windows.Forms.TabPage();
            this.AvalibleVolumes = new System.Windows.Forms.CheckedListBox();
            this.DestinationPathTextbox = new System.Windows.Forms.TextBox();
            this.CaptureImages = new System.Windows.Forms.Button();
            this.DestinationButton = new System.Windows.Forms.Button();
            this.HyperVServerHostnameTextbox = new System.Windows.Forms.TabControl();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitBoxImage)).BeginInit();
            this.ImageApplicationTab.SuspendLayout();
            this.CaptureTab.SuspendLayout();
            this.HyperVServerHostnameTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "wim";
            this.saveFileDialog1.Filter = "Windows Image Files|*.wim|All files|*.*";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.WaitBoxImage);
            this.Settings.Controls.Add(this.HyperVPasswordLabel);
            this.Settings.Controls.Add(this.HyperVServerUsernameLabel);
            this.Settings.Controls.Add(this.HyperVServerPasswordTextbox);
            this.Settings.Controls.Add(this.HyperVUsernameTextbox);
            this.Settings.Controls.Add(this.GetvSwitchLabel);
            this.Settings.Controls.Add(this.PingPassedLabel);
            this.Settings.Controls.Add(this.TestServerConnection);
            this.Settings.Controls.Add(this.AvailiblevSwitchLabel);
            this.Settings.Controls.Add(this.AvailiblevSwitchesCheckedListBox);
            this.Settings.Controls.Add(this.SelectVMRepoButton);
            this.Settings.Controls.Add(this.VMRepoPathTextbox);
            this.Settings.Controls.Add(this.HyperVServerHostnameLabel);
            this.Settings.Controls.Add(this.VDIServerHostnameTextbox);
            this.Settings.Controls.Add(this.ImageRepoPathTextBox);
            this.Settings.Controls.Add(this.EnableVDICheckbox);
            this.Settings.Controls.Add(this.CompressionCheckBox);
            this.Settings.Controls.Add(this.WriteBootSectorCheckBox);
            this.Settings.Controls.Add(this.StandardFormatRadioButton);
            this.Settings.Controls.Add(this.QuickFormatRadioButton);
            this.Settings.Controls.Add(this.FormatDriveCheckBox);
            this.Settings.Controls.Add(this.SelectImageRepoButton);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(543, 324);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings and configuration";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // WaitBoxImage
            // 
            this.WaitBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitBoxImage.Image = global::BackupWithWIM.Properties.Resources.ajax_loader;
            this.WaitBoxImage.Location = new System.Drawing.Point(294, 229);
            this.WaitBoxImage.Name = "WaitBoxImage";
            this.WaitBoxImage.Size = new System.Drawing.Size(35, 33);
            this.WaitBoxImage.TabIndex = 24;
            this.WaitBoxImage.TabStop = false;
            this.WaitBoxImage.Visible = false;
            // 
            // HyperVPasswordLabel
            // 
            this.HyperVPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HyperVPasswordLabel.AutoSize = true;
            this.HyperVPasswordLabel.Location = new System.Drawing.Point(163, 266);
            this.HyperVPasswordLabel.Name = "HyperVPasswordLabel";
            this.HyperVPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.HyperVPasswordLabel.TabIndex = 23;
            this.HyperVPasswordLabel.Text = "Hyper-V Password";
            // 
            // HyperVServerUsernameLabel
            // 
            this.HyperVServerUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HyperVServerUsernameLabel.AutoSize = true;
            this.HyperVServerUsernameLabel.Location = new System.Drawing.Point(23, 266);
            this.HyperVServerUsernameLabel.Name = "HyperVServerUsernameLabel";
            this.HyperVServerUsernameLabel.Size = new System.Drawing.Size(120, 13);
            this.HyperVServerUsernameLabel.TabIndex = 22;
            this.HyperVServerUsernameLabel.Text = "Username for Hyper-V";
            // 
            // HyperVServerPasswordTextbox
            // 
            this.HyperVServerPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HyperVServerPasswordTextbox.Location = new System.Drawing.Point(163, 240);
            this.HyperVServerPasswordTextbox.Name = "HyperVServerPasswordTextbox";
            this.HyperVServerPasswordTextbox.Size = new System.Drawing.Size(100, 22);
            this.HyperVServerPasswordTextbox.TabIndex = 21;
            this.HyperVServerPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // HyperVUsernameTextbox
            // 
            this.HyperVUsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HyperVUsernameTextbox.Location = new System.Drawing.Point(23, 240);
            this.HyperVUsernameTextbox.Name = "HyperVUsernameTextbox";
            this.HyperVUsernameTextbox.Size = new System.Drawing.Size(120, 22);
            this.HyperVUsernameTextbox.TabIndex = 20;
            this.HyperVUsernameTextbox.Text = "contoso\\username";
            this.HyperVUsernameTextbox.TextChanged += new System.EventHandler(this.HyperVUsernameTextbox_TextChanged);
            // 
            // GetvSwitchLabel
            // 
            this.GetvSwitchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetvSwitchLabel.AutoSize = true;
            this.GetvSwitchLabel.Location = new System.Drawing.Point(269, 208);
            this.GetvSwitchLabel.Name = "GetvSwitchLabel";
            this.GetvSwitchLabel.Size = new System.Drawing.Size(93, 13);
            this.GetvSwitchLabel.TabIndex = 19;
            this.GetvSwitchLabel.Text = "✓ Get vSwitches";
            this.GetvSwitchLabel.Visible = false;
            // 
            // PingPassedLabel
            // 
            this.PingPassedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PingPassedLabel.AutoSize = true;
            this.PingPassedLabel.Location = new System.Drawing.Point(269, 195);
            this.PingPassedLabel.Name = "PingPassedLabel";
            this.PingPassedLabel.Size = new System.Drawing.Size(72, 13);
            this.PingPassedLabel.TabIndex = 18;
            this.PingPassedLabel.Text = "✓ Ping Host";
            this.PingPassedLabel.Visible = false;
            // 
            // TestServerConnection
            // 
            this.TestServerConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestServerConnection.Enabled = false;
            this.TestServerConnection.Location = new System.Drawing.Point(163, 198);
            this.TestServerConnection.Name = "TestServerConnection";
            this.TestServerConnection.Size = new System.Drawing.Size(100, 23);
            this.TestServerConnection.TabIndex = 17;
            this.TestServerConnection.Text = "Test Connection";
            this.TestServerConnection.UseVisualStyleBackColor = true;
            this.TestServerConnection.Click += new System.EventHandler(this.TestServerConnection_Click);
            // 
            // AvailiblevSwitchLabel
            // 
            this.AvailiblevSwitchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailiblevSwitchLabel.AutoSize = true;
            this.AvailiblevSwitchLabel.Location = new System.Drawing.Point(381, 267);
            this.AvailiblevSwitchLabel.Name = "AvailiblevSwitchLabel";
            this.AvailiblevSwitchLabel.Size = new System.Drawing.Size(103, 13);
            this.AvailiblevSwitchLabel.TabIndex = 16;
            this.AvailiblevSwitchLabel.Text = "Availible vSwitches";
            // 
            // AvailiblevSwitchesCheckedListBox
            // 
            this.AvailiblevSwitchesCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailiblevSwitchesCheckedListBox.FormattingEnabled = true;
            this.AvailiblevSwitchesCheckedListBox.Location = new System.Drawing.Point(374, 175);
            this.AvailiblevSwitchesCheckedListBox.Name = "AvailiblevSwitchesCheckedListBox";
            this.AvailiblevSwitchesCheckedListBox.ScrollAlwaysVisible = true;
            this.AvailiblevSwitchesCheckedListBox.Size = new System.Drawing.Size(120, 89);
            this.AvailiblevSwitchesCheckedListBox.TabIndex = 15;
            // 
            // SelectVMRepoButton
            // 
            this.SelectVMRepoButton.Enabled = false;
            this.SelectVMRepoButton.Location = new System.Drawing.Point(23, 285);
            this.SelectVMRepoButton.Name = "SelectVMRepoButton";
            this.SelectVMRepoButton.Size = new System.Drawing.Size(112, 22);
            this.SelectVMRepoButton.TabIndex = 14;
            this.SelectVMRepoButton.Text = "Select VM Repo";
            this.SelectVMRepoButton.UseVisualStyleBackColor = true;
            this.SelectVMRepoButton.Click += new System.EventHandler(this.SelectVMRepoButton_Click);
            // 
            // VMRepoPathTextbox
            // 
            this.VMRepoPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VMRepoPathTextbox.Enabled = false;
            this.VMRepoPathTextbox.Location = new System.Drawing.Point(141, 285);
            this.VMRepoPathTextbox.Name = "VMRepoPathTextbox";
            this.VMRepoPathTextbox.Size = new System.Drawing.Size(201, 22);
            this.VMRepoPathTextbox.TabIndex = 13;
            this.VMRepoPathTextbox.Text = "\\\\localhost\\Images";
            // 
            // HyperVServerHostnameLabel
            // 
            this.HyperVServerHostnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HyperVServerHostnameLabel.AutoSize = true;
            this.HyperVServerHostnameLabel.Location = new System.Drawing.Point(20, 223);
            this.HyperVServerHostnameLabel.Name = "HyperVServerHostnameLabel";
            this.HyperVServerHostnameLabel.Size = new System.Drawing.Size(137, 13);
            this.HyperVServerHostnameLabel.TabIndex = 12;
            this.HyperVServerHostnameLabel.Text = "Hyper-V Server Hostname";
            this.HyperVServerHostnameLabel.Visible = false;
            // 
            // VDIServerHostnameTextbox
            // 
            this.VDIServerHostnameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VDIServerHostnameTextbox.Enabled = false;
            this.VDIServerHostnameTextbox.Location = new System.Drawing.Point(23, 198);
            this.VDIServerHostnameTextbox.Name = "VDIServerHostnameTextbox";
            this.VDIServerHostnameTextbox.Size = new System.Drawing.Size(134, 22);
            this.VDIServerHostnameTextbox.TabIndex = 11;
            this.VDIServerHostnameTextbox.Text = "localhost";
            this.VDIServerHostnameTextbox.TextChanged += new System.EventHandler(this.VDIServerHostnameTextbox_TextChanged);
            // 
            // ImageRepoPathTextBox
            // 
            this.ImageRepoPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageRepoPathTextBox.Location = new System.Drawing.Point(153, 22);
            this.ImageRepoPathTextBox.Name = "ImageRepoPathTextBox";
            this.ImageRepoPathTextBox.Size = new System.Drawing.Size(201, 22);
            this.ImageRepoPathTextBox.TabIndex = 3;
            // 
            // EnableVDICheckbox
            // 
            this.EnableVDICheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnableVDICheckbox.AutoSize = true;
            this.EnableVDICheckbox.Location = new System.Drawing.Point(23, 175);
            this.EnableVDICheckbox.Name = "EnableVDICheckbox";
            this.EnableVDICheckbox.Size = new System.Drawing.Size(198, 17);
            this.EnableVDICheckbox.TabIndex = 10;
            this.EnableVDICheckbox.Text = "Enable VDI (Hyper-V) Integration?";
            this.EnableVDICheckbox.UseVisualStyleBackColor = true;
            this.EnableVDICheckbox.CheckStateChanged += new System.EventHandler(this.EnableVDICheckbox_CheckStateChanged);
            // 
            // CompressionCheckBox
            // 
            this.CompressionCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompressionCheckBox.AutoSize = true;
            this.CompressionCheckBox.Checked = true;
            this.CompressionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompressionCheckBox.Location = new System.Drawing.Point(23, 101);
            this.CompressionCheckBox.Name = "CompressionCheckBox";
            this.CompressionCheckBox.Size = new System.Drawing.Size(178, 17);
            this.CompressionCheckBox.TabIndex = 9;
            this.CompressionCheckBox.Text = "Apply Compression to image?";
            this.CompressionCheckBox.UseVisualStyleBackColor = true;
            // 
            // WriteBootSectorCheckBox
            // 
            this.WriteBootSectorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WriteBootSectorCheckBox.AutoSize = true;
            this.WriteBootSectorCheckBox.Checked = true;
            this.WriteBootSectorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WriteBootSectorCheckBox.Location = new System.Drawing.Point(23, 51);
            this.WriteBootSectorCheckBox.Name = "WriteBootSectorCheckBox";
            this.WriteBootSectorCheckBox.Size = new System.Drawing.Size(186, 17);
            this.WriteBootSectorCheckBox.TabIndex = 8;
            this.WriteBootSectorCheckBox.Text = "Write new BootSector to drive?";
            this.WriteBootSectorCheckBox.UseVisualStyleBackColor = true;
            // 
            // StandardFormatRadioButton
            // 
            this.StandardFormatRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StandardFormatRadioButton.AutoSize = true;
            this.StandardFormatRadioButton.Location = new System.Drawing.Point(127, 124);
            this.StandardFormatRadioButton.Name = "StandardFormatRadioButton";
            this.StandardFormatRadioButton.Size = new System.Drawing.Size(116, 17);
            this.StandardFormatRadioButton.TabIndex = 7;
            this.StandardFormatRadioButton.Text = "Standard Format?";
            this.StandardFormatRadioButton.UseVisualStyleBackColor = true;
            // 
            // QuickFormatRadioButton
            // 
            this.QuickFormatRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuickFormatRadioButton.AutoSize = true;
            this.QuickFormatRadioButton.Checked = true;
            this.QuickFormatRadioButton.Location = new System.Drawing.Point(23, 124);
            this.QuickFormatRadioButton.Name = "QuickFormatRadioButton";
            this.QuickFormatRadioButton.Size = new System.Drawing.Size(99, 17);
            this.QuickFormatRadioButton.TabIndex = 6;
            this.QuickFormatRadioButton.TabStop = true;
            this.QuickFormatRadioButton.Text = "Quick Format?";
            this.QuickFormatRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormatDriveCheckBox
            // 
            this.FormatDriveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormatDriveCheckBox.AutoSize = true;
            this.FormatDriveCheckBox.Checked = true;
            this.FormatDriveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FormatDriveCheckBox.Location = new System.Drawing.Point(23, 76);
            this.FormatDriveCheckBox.Name = "FormatDriveCheckBox";
            this.FormatDriveCheckBox.Size = new System.Drawing.Size(193, 17);
            this.FormatDriveCheckBox.TabIndex = 5;
            this.FormatDriveCheckBox.Text = "Format drive before application?";
            this.FormatDriveCheckBox.UseVisualStyleBackColor = true;
            // 
            // SelectImageRepoButton
            // 
            this.SelectImageRepoButton.Location = new System.Drawing.Point(23, 22);
            this.SelectImageRepoButton.Name = "SelectImageRepoButton";
            this.SelectImageRepoButton.Size = new System.Drawing.Size(112, 22);
            this.SelectImageRepoButton.TabIndex = 4;
            this.SelectImageRepoButton.Text = "Select Image Repo";
            this.SelectImageRepoButton.UseVisualStyleBackColor = true;
            this.SelectImageRepoButton.Click += new System.EventHandler(this.SelectImageRepoButton_Click);
            // 
            // ImageApplicationTab
            // 
            this.ImageApplicationTab.Controls.Add(this.VistaOrNewerRadioButton);
            this.ImageApplicationTab.Controls.Add(this.XPBootSectorRadioButton);
            this.ImageApplicationTab.Controls.Add(this.ImageDriveButton);
            this.ImageApplicationTab.Controls.Add(this.AvailibleDisks);
            this.ImageApplicationTab.Controls.Add(this.AvailibleImages);
            this.ImageApplicationTab.Location = new System.Drawing.Point(4, 22);
            this.ImageApplicationTab.Name = "ImageApplicationTab";
            this.ImageApplicationTab.Padding = new System.Windows.Forms.Padding(3);
            this.ImageApplicationTab.Size = new System.Drawing.Size(543, 324);
            this.ImageApplicationTab.TabIndex = 1;
            this.ImageApplicationTab.Text = "Image Application";
            this.ImageApplicationTab.UseVisualStyleBackColor = true;
            // 
            // VistaOrNewerRadioButton
            // 
            this.VistaOrNewerRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VistaOrNewerRadioButton.AutoSize = true;
            this.VistaOrNewerRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VistaOrNewerRadioButton.Location = new System.Drawing.Point(148, 76);
            this.VistaOrNewerRadioButton.Name = "VistaOrNewerRadioButton";
            this.VistaOrNewerRadioButton.Size = new System.Drawing.Size(156, 17);
            this.VistaOrNewerRadioButton.TabIndex = 4;
            this.VistaOrNewerRadioButton.TabStop = true;
            this.VistaOrNewerRadioButton.Text = "Windows Vista or newer?";
            this.VistaOrNewerRadioButton.UseVisualStyleBackColor = true;
            // 
            // XPBootSectorRadioButton
            // 
            this.XPBootSectorRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XPBootSectorRadioButton.AutoSize = true;
            this.XPBootSectorRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XPBootSectorRadioButton.Location = new System.Drawing.Point(48, 76);
            this.XPBootSectorRadioButton.Name = "XPBootSectorRadioButton";
            this.XPBootSectorRadioButton.Size = new System.Drawing.Size(94, 17);
            this.XPBootSectorRadioButton.TabIndex = 3;
            this.XPBootSectorRadioButton.TabStop = true;
            this.XPBootSectorRadioButton.Text = "Windows XP?";
            this.XPBootSectorRadioButton.UseVisualStyleBackColor = true;
            // 
            // ImageDriveButton
            // 
            this.ImageDriveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageDriveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDriveButton.Location = new System.Drawing.Point(311, 180);
            this.ImageDriveButton.Name = "ImageDriveButton";
            this.ImageDriveButton.Size = new System.Drawing.Size(98, 23);
            this.ImageDriveButton.TabIndex = 2;
            this.ImageDriveButton.Text = "Image Drive!";
            this.ImageDriveButton.UseVisualStyleBackColor = true;
            this.ImageDriveButton.Click += new System.EventHandler(this.ImageDriveButton_Click);
            // 
            // AvailibleDisks
            // 
            this.AvailibleDisks.AccessibleName = "Availible Disks";
            this.AvailibleDisks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailibleDisks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvailibleDisks.FormattingEnabled = true;
            this.AvailibleDisks.Location = new System.Drawing.Point(311, 30);
            this.AvailibleDisks.Name = "AvailibleDisks";
            this.AvailibleDisks.ScrollAlwaysVisible = true;
            this.AvailibleDisks.Size = new System.Drawing.Size(59, 89);
            this.AvailibleDisks.TabIndex = 1;
            // 
            // AvailibleImages
            // 
            this.AvailibleImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailibleImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvailibleImages.FormattingEnabled = true;
            this.AvailibleImages.Location = new System.Drawing.Point(48, 30);
            this.AvailibleImages.Name = "AvailibleImages";
            this.AvailibleImages.Size = new System.Drawing.Size(121, 21);
            this.AvailibleImages.TabIndex = 0;
            this.AvailibleImages.Text = "Select Image...";
            // 
            // CaptureTab
            // 
            this.CaptureTab.Controls.Add(this.AvalibleVolumes);
            this.CaptureTab.Controls.Add(this.DestinationPathTextbox);
            this.CaptureTab.Controls.Add(this.CaptureImages);
            this.CaptureTab.Controls.Add(this.DestinationButton);
            this.CaptureTab.Location = new System.Drawing.Point(4, 22);
            this.CaptureTab.Name = "CaptureTab";
            this.CaptureTab.Padding = new System.Windows.Forms.Padding(3);
            this.CaptureTab.Size = new System.Drawing.Size(543, 324);
            this.CaptureTab.TabIndex = 0;
            this.CaptureTab.Text = "Image Capture and Sequencing";
            this.CaptureTab.ToolTipText = "Capture an disk image";
            this.CaptureTab.UseVisualStyleBackColor = true;
            // 
            // AvalibleVolumes
            // 
            this.AvalibleVolumes.AccessibleName = "Availible Volumes";
            this.AvalibleVolumes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvalibleVolumes.FormattingEnabled = true;
            this.AvalibleVolumes.Location = new System.Drawing.Point(43, 21);
            this.AvalibleVolumes.Name = "AvalibleVolumes";
            this.AvalibleVolumes.ScrollAlwaysVisible = true;
            this.AvalibleVolumes.Size = new System.Drawing.Size(50, 89);
            this.AvalibleVolumes.TabIndex = 0;
            // 
            // DestinationPathTextbox
            // 
            this.DestinationPathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationPathTextbox.Location = new System.Drawing.Point(194, 182);
            this.DestinationPathTextbox.Name = "DestinationPathTextbox";
            this.DestinationPathTextbox.Size = new System.Drawing.Size(201, 22);
            this.DestinationPathTextbox.TabIndex = 2;
            // 
            // CaptureImages
            // 
            this.CaptureImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureImages.Location = new System.Drawing.Point(43, 126);
            this.CaptureImages.Name = "CaptureImages";
            this.CaptureImages.Size = new System.Drawing.Size(110, 22);
            this.CaptureImages.TabIndex = 4;
            this.CaptureImages.Text = "Capture Image!";
            this.CaptureImages.UseVisualStyleBackColor = true;
            this.CaptureImages.Click += new System.EventHandler(this.CaptureImages_Click);
            // 
            // DestinationButton
            // 
            this.DestinationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DestinationButton.Location = new System.Drawing.Point(43, 182);
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.Size = new System.Drawing.Size(145, 22);
            this.DestinationButton.TabIndex = 1;
            this.DestinationButton.Text = "Select Image destination";
            this.DestinationButton.UseVisualStyleBackColor = true;
            this.DestinationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HyperVServerHostnameTextbox
            // 
            this.HyperVServerHostnameTextbox.AccessibleName = "TabContainerPane";
            this.HyperVServerHostnameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HyperVServerHostnameTextbox.Controls.Add(this.CaptureTab);
            this.HyperVServerHostnameTextbox.Controls.Add(this.ImageApplicationTab);
            this.HyperVServerHostnameTextbox.Controls.Add(this.Settings);
            this.HyperVServerHostnameTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.HyperVServerHostnameTextbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HyperVServerHostnameTextbox.HotTrack = true;
            this.HyperVServerHostnameTextbox.Location = new System.Drawing.Point(0, 0);
            this.HyperVServerHostnameTextbox.Name = "HyperVServerHostnameTextbox";
            this.HyperVServerHostnameTextbox.SelectedIndex = 0;
            this.HyperVServerHostnameTextbox.Size = new System.Drawing.Size(551, 350);
            this.HyperVServerHostnameTextbox.TabIndex = 5;
            this.HyperVServerHostnameTextbox.SelectedIndexChanged += new System.EventHandler(this.TabContainerPane_TabIndexChanged);
            this.HyperVServerHostnameTextbox.TabIndexChanged += new System.EventHandler(this.TabContainerPane_TabIndexChanged);
            // 
            // TotalImageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 350);
            this.Controls.Add(this.HyperVServerHostnameTextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TotalImageManager";
            this.Text = "Total Image Manager";
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitBoxImage)).EndInit();
            this.ImageApplicationTab.ResumeLayout(false);
            this.ImageApplicationTab.PerformLayout();
            this.CaptureTab.ResumeLayout(false);
            this.CaptureTab.PerformLayout();
            this.HyperVServerHostnameTextbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TextBox VMRepoPathTextbox;
        private System.Windows.Forms.Label HyperVServerHostnameLabel;
        private System.Windows.Forms.TextBox VDIServerHostnameTextbox;
        private System.Windows.Forms.TextBox ImageRepoPathTextBox;
        private System.Windows.Forms.CheckBox EnableVDICheckbox;
        private System.Windows.Forms.CheckBox CompressionCheckBox;
        private System.Windows.Forms.CheckBox WriteBootSectorCheckBox;
        private System.Windows.Forms.RadioButton StandardFormatRadioButton;
        private System.Windows.Forms.RadioButton QuickFormatRadioButton;
        private System.Windows.Forms.CheckBox FormatDriveCheckBox;
        private System.Windows.Forms.Button SelectImageRepoButton;
        private System.Windows.Forms.TabPage ImageApplicationTab;
        private System.Windows.Forms.RadioButton VistaOrNewerRadioButton;
        private System.Windows.Forms.RadioButton XPBootSectorRadioButton;
        private System.Windows.Forms.Button ImageDriveButton;
        private System.Windows.Forms.CheckedListBox AvailibleDisks;
        private System.Windows.Forms.ComboBox AvailibleImages;
        private System.Windows.Forms.TabPage CaptureTab;
        private System.Windows.Forms.CheckedListBox AvalibleVolumes;
        private System.Windows.Forms.TextBox DestinationPathTextbox;
        private System.Windows.Forms.Button CaptureImages;
        private System.Windows.Forms.Button DestinationButton;
        private System.Windows.Forms.TabControl HyperVServerHostnameTextbox;
        private System.Windows.Forms.Button SelectVMRepoButton;
        private System.Windows.Forms.CheckedListBox AvailiblevSwitchesCheckedListBox;
        private System.Windows.Forms.Label AvailiblevSwitchLabel;
        private System.Windows.Forms.Button TestServerConnection;
        private System.Windows.Forms.Label PingPassedLabel;
        private System.Windows.Forms.Label GetvSwitchLabel;
        private System.Windows.Forms.Label HyperVPasswordLabel;
        private System.Windows.Forms.Label HyperVServerUsernameLabel;
        private System.Windows.Forms.TextBox HyperVServerPasswordTextbox;
        private System.Windows.Forms.TextBox HyperVUsernameTextbox;
        private System.Windows.Forms.PictureBox WaitBoxImage;

    }
}

