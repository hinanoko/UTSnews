namespace WinFormsApp1
{
    partial class SubmitFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitFeedback));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(377, 72);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(422, 68);
            label1.TabIndex = 0;
            label1.Text = "Submit Feedback";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 9.857143F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(387, 158);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 29);
            label2.TabIndex = 1;
            label2.Text = "Teacher Email";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(387, 192);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 36);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9.857143F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(387, 244);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 29);
            label3.TabIndex = 3;
            label3.Text = "Feedback";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(387, 278);
            textBox2.Margin = new Padding(5);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(476, 153);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 50, 58);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(387, 468);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(476, 38);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-67, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 779);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // SubmitFeedback
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 27, 33);
            ClientSize = new Size(951, 577);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Impact", 9.857143F);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "SubmitFeedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}