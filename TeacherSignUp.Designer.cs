namespace WinFormsApp1
{
    partial class TeacherSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherSignUp));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 50, 58);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(421, 472);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(415, 38);
            button1.TabIndex = 0;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 9.857143F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(421, 149);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 29);
            label1.TabIndex = 1;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 184);
            textBox1.Margin = new Padding(6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 259);
            textBox2.Margin = new Padding(6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(415, 34);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(421, 334);
            textBox3.Margin = new Padding(6);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(415, 34);
            textBox3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 9.857143F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(421, 224);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 29);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9.857143F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(421, 299);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 29);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 9.857143F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(421, 374);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(166, 29);
            label4.TabIndex = 7;
            label4.Text = "Password again";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(421, 409);
            textBox4.Margin = new Padding(6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(415, 34);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 23.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(403, 67);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(423, 67);
            label6.TabIndex = 13;
            label6.Text = "Sign up a teacher";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-33, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 779);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // TeacherSignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 27, 33);
            ClientSize = new Size(951, 577);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(6);
            Name = "TeacherSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Label label6;
        private PictureBox pictureBox1;
    }
}