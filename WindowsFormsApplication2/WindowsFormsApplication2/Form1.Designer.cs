namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxRuntimeGenere = new System.Windows.Forms.TextBox();
            this.textBoxAwards = new System.Windows.Forms.TextBox();
            this.pictureBox4Awards = new System.Windows.Forms.PictureBox();
            this.textBox3Title = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.pictureBoxHR2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHR1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3popMovies = new System.Windows.Forms.TabPage();
            this.tabPage4popTv = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Awards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(233, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 385);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(271, 492);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(226, 63);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(296, 455);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Søk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3popMovies);
            this.tabControl1.Controls.Add(this.tabPage4popTv);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 639);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Databasesøk";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxRuntimeGenere);
            this.tabPage2.Controls.Add(this.textBoxAwards);
            this.tabPage2.Controls.Add(this.pictureBox4Awards);
            this.tabPage2.Controls.Add(this.textBox3Title);
            this.tabPage2.Controls.Add(this.textBoxRating);
            this.tabPage2.Controls.Add(this.pictureBoxHR2);
            this.tabPage2.Controls.Add(this.pictureBoxHR1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detaljer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxRuntimeGenere
            // 
            this.textBoxRuntimeGenere.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRuntimeGenere.Location = new System.Drawing.Point(409, 57);
            this.textBoxRuntimeGenere.Name = "textBoxRuntimeGenere";
            this.textBoxRuntimeGenere.Size = new System.Drawing.Size(347, 13);
            this.textBoxRuntimeGenere.TabIndex = 9;
            // 
            // textBoxAwards
            // 
            this.textBoxAwards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.textBoxAwards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAwards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAwards.Location = new System.Drawing.Point(400, 333);
            this.textBoxAwards.Name = "textBoxAwards";
            this.textBoxAwards.Size = new System.Drawing.Size(348, 14);
            this.textBoxAwards.TabIndex = 8;
            this.textBoxAwards.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4Awards
            // 
            this.pictureBox4Awards.Location = new System.Drawing.Point(387, 321);
            this.pictureBox4Awards.Name = "pictureBox4Awards";
            this.pictureBox4Awards.Size = new System.Drawing.Size(378, 40);
            this.pictureBox4Awards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4Awards.TabIndex = 7;
            this.pictureBox4Awards.TabStop = false;
            // 
            // textBox3Title
            // 
            this.textBox3Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3Title.Location = new System.Drawing.Point(409, 29);
            this.textBox3Title.Name = "textBox3Title";
            this.textBox3Title.Size = new System.Drawing.Size(277, 22);
            this.textBox3Title.TabIndex = 6;
            // 
            // textBoxRating
            // 
            this.textBoxRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRating.Location = new System.Drawing.Point(493, 144);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(189, 13);
            this.textBoxRating.TabIndex = 5;
            // 
            // pictureBoxHR2
            // 
            this.pictureBoxHR2.Location = new System.Drawing.Point(387, 225);
            this.pictureBoxHR2.Name = "pictureBoxHR2";
            this.pictureBoxHR2.Size = new System.Drawing.Size(378, 16);
            this.pictureBoxHR2.TabIndex = 4;
            this.pictureBoxHR2.TabStop = false;
            // 
            // pictureBoxHR1
            // 
            this.pictureBoxHR1.Location = new System.Drawing.Point(387, 87);
            this.pictureBoxHR1.Name = "pictureBoxHR1";
            this.pictureBoxHR1.Size = new System.Drawing.Size(378, 16);
            this.pictureBoxHR1.TabIndex = 3;
            this.pictureBoxHR1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(202)))), ((int)(((byte)(76)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(437, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(24, 17);
            this.textBox2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(418, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 66);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 500);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage3popMovies
            // 
            this.tabPage3popMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPage3popMovies.Name = "tabPage3popMovies";
            this.tabPage3popMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3popMovies.Size = new System.Drawing.Size(811, 613);
            this.tabPage3popMovies.TabIndex = 2;
            this.tabPage3popMovies.Text = "Popular Movies";
            this.tabPage3popMovies.UseVisualStyleBackColor = true;
            this.tabPage3popMovies.Click += new System.EventHandler(this.tabPage3popMovies_Click);
            // 
            // tabPage4popTv
            // 
            this.tabPage4popTv.Location = new System.Drawing.Point(4, 22);
            this.tabPage4popTv.Name = "tabPage4popTv";
            this.tabPage4popTv.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4popTv.Size = new System.Drawing.Size(811, 613);
            this.tabPage4popTv.TabIndex = 3;
            this.tabPage4popTv.Text = "Popular TV";
            this.tabPage4popTv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(812, 635);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film & Serie Databasesøker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Awards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBoxHR2;
        private System.Windows.Forms.PictureBox pictureBoxHR1;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBox3Title;
        private System.Windows.Forms.PictureBox pictureBox4Awards;
        private System.Windows.Forms.TextBox textBoxAwards;
        private System.Windows.Forms.TextBox textBoxRuntimeGenere;
        private System.Windows.Forms.TabPage tabPage3popMovies;
        private System.Windows.Forms.TabPage tabPage4popTv;





    }
}

