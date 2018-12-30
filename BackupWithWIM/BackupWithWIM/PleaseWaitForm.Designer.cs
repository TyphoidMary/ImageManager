namespace BackupWithWIM
{
    partial class PleaseWaitForm
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
            this.WaitBoxImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WaitBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WaitBoxImage
            // 
            this.WaitBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitBoxImage.Image = global::BackupWithWIM.Properties.Resources.ajax_loader;
            this.WaitBoxImage.Location = new System.Drawing.Point(252, 64);
            this.WaitBoxImage.Name = "WaitBoxImage";
            this.WaitBoxImage.Size = new System.Drawing.Size(35, 33);
            this.WaitBoxImage.TabIndex = 25;
            this.WaitBoxImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Capturing image, Please wait... ";
            // 
            // PleaseWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WaitBoxImage);
            this.Name = "PleaseWaitForm";
            this.Text = "PleaseWaitForm";
            this.Shown += new System.EventHandler(this.PleaseWaitForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.WaitBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WaitBoxImage;
        private System.Windows.Forms.Label label1;
    }
}