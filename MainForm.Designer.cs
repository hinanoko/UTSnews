namespace WinFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 50, 58);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 9.857143F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(417, 323);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(419, 38);
            button1.TabIndex = 0;
            button1.Text = "Lost and found";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(43, 50, 58);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 9.857143F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(417, 227);
            button2.Margin = new Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new Size(419, 38);
            button2.TabIndex = 1;
            button2.Text = "PersonalProfile";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(43, 50, 58);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Consolas", 9.857143F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(417, 371);
            button3.Margin = new Padding(6, 5, 6, 5);
            button3.Name = "button3";
            button3.Size = new Size(419, 38);
            button3.TabIndex = 2;
            button3.Text = "Submit feedback";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(43, 50, 58);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Consolas", 9.857143F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(417, 275);
            button4.Margin = new Padding(6, 5, 6, 5);
            button4.Name = "button4";
            button4.Size = new Size(419, 38);
            button4.TabIndex = 3;
            button4.Text = "Acitivity news";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(402, 139);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 68);
            label1.TabIndex = 4;
            label1.Text = "Student";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 779);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 27, 33);
            ClientSize = new Size(951, 577);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox1;
    }
}