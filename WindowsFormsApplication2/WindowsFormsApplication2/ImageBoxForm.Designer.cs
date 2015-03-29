namespace WindowsFormsApplication2
{
    partial class ImageBoxForm
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
            this.posterPicBox = new System.Windows.Forms.PictureBox();
            this.ImgBoxLowerTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.posterPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // posterPicBox
            // 
            this.posterPicBox.Location = new System.Drawing.Point(12, 12);
            this.posterPicBox.Name = "posterPicBox";
            this.posterPicBox.Size = new System.Drawing.Size(371, 425);
            this.posterPicBox.TabIndex = 0;
            this.posterPicBox.TabStop = false;
            this.posterPicBox.Click += new System.EventHandler(this.posterPicBox_Click);
            // 
            // ImgBoxLowerTxtBox
            // 
            this.ImgBoxLowerTxtBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.ImgBoxLowerTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImgBoxLowerTxtBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgBoxLowerTxtBox.Location = new System.Drawing.Point(113, 443);
            this.ImgBoxLowerTxtBox.Name = "ImgBoxLowerTxtBox";
            this.ImgBoxLowerTxtBox.Size = new System.Drawing.Size(149, 13);
            this.ImgBoxLowerTxtBox.TabIndex = 1;
            // 
            // ImageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 482);
            this.Controls.Add(this.ImgBoxLowerTxtBox);
            this.Controls.Add(this.posterPicBox);
            this.Name = "ImageBoxForm";
            ((System.ComponentModel.ISupportInitialize)(this.posterPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox posterPicBox;
        private System.Windows.Forms.TextBox ImgBoxLowerTxtBox;
    }
}