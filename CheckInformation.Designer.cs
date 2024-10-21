namespace WinFormsApp1
{
    partial class CheckInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInformation));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(393, 62);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(433, 136);
            label1.TabIndex = 0;
            label1.Text = "Check someone's\r\ninformation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(406, 210);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 29);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(406, 242);
            textBox1.Margin = new Padding(6, 5, 6, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 34);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(43, 50, 58);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(406, 286);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(398, 38);
            button1.TabIndex = 3;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(406, 334);
            flowLayoutPanel1.Margin = new Padding(6, 5, 6, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(398, 180);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-58, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 779);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // CheckInformation
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 27, 33);
            ClientSize = new Size(951, 577);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            Name = "CheckInformation";
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
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
    }
}