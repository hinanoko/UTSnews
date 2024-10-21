namespace WinFormsApp1
{
    partial class LostAndFound
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LostAndFound));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(347, 81);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(366, 68);
            label1.TabIndex = 0;
            label1.Text = "Lost and Found";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Consolas", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(360, 169);
            tabControl1.Margin = new Padding(6, 5, 6, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(502, 335);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 36);
            tabPage1.Margin = new Padding(6, 5, 6, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(6, 5, 6, 5);
            tabPage1.Size = new Size(494, 295);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "lost";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 36);
            tabPage2.Margin = new Padding(6, 5, 6, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(6, 5, 6, 5);
            tabPage2.Size = new Size(494, 295);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "found";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-76, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 779);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // LostAndFound
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 27, 33);
            ClientSize = new Size(951, 577);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "LostAndFound";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lost and Found";
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox pictureBox1;
    }
}
