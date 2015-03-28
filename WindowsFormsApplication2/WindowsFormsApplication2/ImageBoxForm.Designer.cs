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
            // 
            // ImageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 449);
            this.Controls.Add(this.posterPicBox);
            this.Name = "ImageBoxForm";
            ((System.ComponentModel.ISupportInitialize)(this.posterPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox posterPicBox;
    }
}