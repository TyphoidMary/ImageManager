namespace BackupWithWIM
{
    partial class TotalImageManger
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
            this.AvalibleVolumes = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DestinationButton = new System.Windows.Forms.Button();
            this.DestinationPathTextbox = new System.Windows.Forms.TextBox();
            this.CaptureImages = new System.Windows.Forms.Button();
            this.TabContainerPane = new System.Windows.Forms.TabControl();
            this.CaptureTab = new System.Windows.Forms.TabPage();
            this.ImageApplicationTab = new System.Windows.Forms.TabPage();
            this.VistaOrNewerRadioButton = new System.Windows.Forms.RadioButton();
            this.XPBootSectorRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageDriveButton = new System.Windows.Forms.Button();
            this.AvailibleDisks = new System.Windows.Forms.CheckedListBox();
            this.AvailibleImages = new System.Windows.Forms.ComboBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.CompressionCheckBox = new System.Windows.Forms.CheckBox();
            this.WriteBootSectorCheckBox = new System.Windows.Forms.CheckBox();
            this.StandardFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.QuickFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.FormatDriveCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectImageRepoButton = new System.Windows.Forms.Button();
            this.ImageRepoPathTextBox = new System.Windows.Forms.TextBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.TabContainerPane.SuspendLayout();
            this.CaptureTab.SuspendLayout();
            this.ImageApplicationTab.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvalibleVolumes
            // 
            this.AvalibleVolumes.AccessibleName = "Availible Volumes";
            this.AvalibleVolumes.FormattingEnabled = true;
            this.AvalibleVolumes.Location = new System.Drawing.Point(43, 21);
            this.AvalibleVolumes.Name = "AvalibleVolumes";
            this.AvalibleVolumes.ScrollAlwaysVisible = true;
            this.AvalibleVolumes.Size = new System.Drawing.Size(50, 89);
            this.AvalibleVolumes.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "wim";
            this.saveFileDialog1.Filter = "Windows Image Files|*.wim|All files|*.*";
            // 
            // DestinationButton
            // 
            this.DestinationButton.Location = new System.Drawing.Point(43, 182);
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.Size = new System.Drawing.Size(145, 22);
            this.DestinationButton.TabIndex = 1;
            this.DestinationButton.Text = "Select Image destination";
            this.DestinationButton.UseVisualStyleBackColor = true;
            this.DestinationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DestinationPathTextbox
            // 
            this.DestinationPathTextbox.Location = new System.Drawing.Point(194, 182);
            this.DestinationPathTextbox.Name = "DestinationPathTextbox";
            this.DestinationPathTextbox.Size = new System.Drawing.Size(201, 22);
            this.DestinationPathTextbox.TabIndex = 2;
            // 
            // CaptureImages
            // 
            this.CaptureImages.Location = new System.Drawing.Point(178, 55);
            this.CaptureImages.Name = "CaptureImages";
            this.CaptureImages.Size = new System.Drawing.Size(110, 22);
            this.CaptureImages.TabIndex = 4;
            this.CaptureImages.Text = "Capture Image!";
            this.CaptureImages.UseVisualStyleBackColor = true;
            this.CaptureImages.Click += new System.EventHandler(this.CaptureImages_Click);
            // 
            // TabContainerPane
            // 
            this.TabContainerPane.AccessibleName = "TabContainerPane";
            this.TabContainerPane.Controls.Add(this.CaptureTab);
            this.TabContainerPane.Controls.Add(this.ImageApplicationTab);
            this.TabContainerPane.Controls.Add(this.Settings);
            this.TabContainerPane.Controls.Add(this.AboutTab);
            this.TabContainerPane.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabContainerPane.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabContainerPane.HotTrack = true;
            this.TabContainerPane.Location = new System.Drawing.Point(13, 12);
            this.TabContainerPane.Name = "TabContainerPane";
            this.TabContainerPane.SelectedIndex = 0;
            this.TabContainerPane.Size = new System.Drawing.Size(492, 268);
            this.TabContainerPane.TabIndex = 5;
            this.TabContainerPane.SelectedIndexChanged += new System.EventHandler(this.TabContainerPane_TabIndexChanged);
            this.TabContainerPane.TabIndexChanged += new System.EventHandler(this.TabContainerPane_TabIndexChanged);
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
            this.CaptureTab.Size = new System.Drawing.Size(484, 242);
            this.CaptureTab.TabIndex = 0;
            this.CaptureTab.Text = "Image Capture and Sequencing";
            this.CaptureTab.ToolTipText = "Capture an disk image";
            this.CaptureTab.UseVisualStyleBackColor = true;
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
            this.ImageApplicationTab.Size = new System.Drawing.Size(484, 242);
            this.ImageApplicationTab.TabIndex = 1;
            this.ImageApplicationTab.Text = "Image Application";
            this.ImageApplicationTab.UseVisualStyleBackColor = true;
            // 
            // VistaOrNewerRadioButton
            // 
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
            this.ImageDriveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageDriveButton.Location = new System.Drawing.Point(311, 180);
            this.ImageDriveButton.Name = "ImageDriveButton";
            this.ImageDriveButton.Size = new System.Drawing.Size(98, 23);
            this.ImageDriveButton.TabIndex = 2;
            this.ImageDriveButton.Text = "Image Drive!";
            this.ImageDriveButton.UseVisualStyleBackColor = true;
            // 
            // AvailibleDisks
            // 
            this.AvailibleDisks.AccessibleName = "Availible Disks";
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
            this.AvailibleImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvailibleImages.FormattingEnabled = true;
            this.AvailibleImages.Location = new System.Drawing.Point(48, 30);
            this.AvailibleImages.Name = "AvailibleImages";
            this.AvailibleImages.Size = new System.Drawing.Size(121, 21);
            this.AvailibleImages.TabIndex = 0;
            this.AvailibleImages.Text = "Select Image...";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.CompressionCheckBox);
            this.Settings.Controls.Add(this.WriteBootSectorCheckBox);
            this.Settings.Controls.Add(this.StandardFormatRadioButton);
            this.Settings.Controls.Add(this.QuickFormatRadioButton);
            this.Settings.Controls.Add(this.FormatDriveCheckBox);
            this.Settings.Controls.Add(this.SelectImageRepoButton);
            this.Settings.Controls.Add(this.ImageRepoPathTextBox);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(484, 242);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings and configuration";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // CompressionCheckBox
            // 
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
            // 
            // ImageRepoPathTextBox
            // 
            this.ImageRepoPathTextBox.Location = new System.Drawing.Point(153, 22);
            this.ImageRepoPathTextBox.Name = "ImageRepoPathTextBox";
            this.ImageRepoPathTextBox.Size = new System.Drawing.Size(201, 22);
            this.ImageRepoPathTextBox.TabIndex = 3;
            this.ImageRepoPathTextBox.Text = "Select image repository";
            // 
            // AboutTab
            // 
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(484, 242);
            this.AboutTab.TabIndex = 3;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            this.AboutTab.Click += new System.EventHandler(this.AboutTab_Click);
            // 
            // TotalImageManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 292);
            this.Controls.Add(this.TabContainerPane);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TotalImageManger";
            this.Text = "Total Image Manager";
            this.TabContainerPane.ResumeLayout(false);
            this.CaptureTab.ResumeLayout(false);
            this.CaptureTab.PerformLayout();
            this.ImageApplicationTab.ResumeLayout(false);
            this.ImageApplicationTab.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox AvalibleVolumes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button DestinationButton;
        private System.Windows.Forms.TextBox DestinationPathTextbox;
        private System.Windows.Forms.Button CaptureImages;
        private System.Windows.Forms.TabControl TabContainerPane;
        private System.Windows.Forms.TabPage CaptureTab;
        private System.Windows.Forms.TabPage ImageApplicationTab;
        private System.Windows.Forms.Button ImageDriveButton;
        private System.Windows.Forms.CheckedListBox AvailibleDisks;
        private System.Windows.Forms.ComboBox AvailibleImages;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.CheckBox WriteBootSectorCheckBox;
        private System.Windows.Forms.RadioButton StandardFormatRadioButton;
        private System.Windows.Forms.RadioButton QuickFormatRadioButton;
        private System.Windows.Forms.CheckBox FormatDriveCheckBox;
        private System.Windows.Forms.Button SelectImageRepoButton;
        private System.Windows.Forms.TextBox ImageRepoPathTextBox;
        private System.Windows.Forms.RadioButton VistaOrNewerRadioButton;
        private System.Windows.Forms.RadioButton XPBootSectorRadioButton;
        private System.Windows.Forms.CheckBox CompressionCheckBox;
        private System.Windows.Forms.TabPage AboutTab;

    }
}

