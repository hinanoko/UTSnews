namespace WinFormsApp1
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(398, 63);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 68);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 50, 58);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 9.857143F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(412, 195);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(465, 38);
            button1.TabIndex = 1;
            button1.Text = "Signup a teacher";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(43, 50, 58);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 9.857143F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(412, 435);
            button2.Margin = new Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new Size(465, 38);
            button2.TabIndex = 2;
            button2.Text = "Lost and found";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(43, 50, 58);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Consolas", 9.857143F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(412, 387);
            button3.Margin = new Padding(6, 5, 6, 5);
            button3.Name = "button3";
            button3.Size = new Size(465, 38);
            button3.TabIndex = 3;
            button3.Text = "Activity news";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(43, 50, 58);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Consolas", 9.857143F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(412, 147);
            button4.Margin = new Padding(6, 5, 6, 5);
            button4.Name = "button4";
            button4.Size = new Size(465, 38);
            button4.TabIndex = 4;
            button4.Text = "Personal Profile";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(43, 50, 58);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Consolas", 9.857143F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(412, 243);
            button5.Margin = new Padding(6, 5, 6, 5);
            button5.Name = "button5";
            button5.Size = new Size(465, 38);
            button5.TabIndex = 5;
            button5.Text = "Delete lost and found";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(43, 50, 58);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Consolas", 9.857143F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(412, 291);
            button6.Margin = new Padding(6, 5, 6, 5);
            button6.Name = "button6";
            button6.Size = new Size(465, 38);
            button6.TabIndex = 6;
            button6.Text = "Delete activity news";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(43, 50, 58);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Consolas", 9.857143F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(412, 339);
            button7.Margin = new Padding(6, 5, 6, 5);
            button7.Name = "button7";
            button7.Size = new Size(465, 38);
            button7.TabIndex = 7;
            button7.Text = "Check information";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 779);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 27, 33);
            ClientSize = new Size(951, 577);
            Controls.Add(pictureBox1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private PictureBox pictureBox1;
    }
}