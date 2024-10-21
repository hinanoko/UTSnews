namespace WinFormsApp1
{
    partial class PersonalProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalProfile));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(416, 109);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 68);
            label1.TabIndex = 0;
            label1.Text = "Personal Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.857143F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(433, 229);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(181, 28);
            label2.TabIndex = 1;
            label2.Text = "Role: Teacher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9.857143F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(433, 272);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(311, 28);
            label3.TabIndex = 2;
            label3.Text = "Email: user@example.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9.857143F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(433, 189);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(194, 28);
            label4.TabIndex = 3;
            label4.Text = "Name: John Doe";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 50, 58);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(433, 390);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(378, 38);
            button1.TabIndex = 4;
            button1.Text = "Update Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(433, 330);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter new password";
            textBox1.Size = new Size(378, 34);
            textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-38, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 779);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // PersonalProfile
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 27, 33);
            ClientSize = new Size(951, 577);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Impact", 9.857143F);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "PersonalProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}
