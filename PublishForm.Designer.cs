namespace WinFormsApp1
{
    partial class PublishForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 9.857143F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 83);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 29);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 81);
            textBox1.Margin = new Padding(6, 5, 6, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 9.857143F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 142);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 29);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9.857143F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(136, 209);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 29);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 9.857143F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(133, 275);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 29);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 142);
            textBox2.Margin = new Padding(6, 5, 6, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 34);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(270, 209);
            textBox3.Margin = new Padding(6, 5, 6, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 34);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(270, 275);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(139, 38);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(270, 421);
            button2.Margin = new Padding(6, 5, 6, 5);
            button2.Name = "button2";
            button2.Size = new Size(139, 38);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(535, 81);
            pictureBox1.Margin = new Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 232);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 9.857143F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(132, 344);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 29);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(270, 344);
            comboBox1.Margin = new Padding(6, 5, 6, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 36);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // PublishForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 27, 33);
            ClientSize = new Size(951, 577);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "PublishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label5;
        private ComboBox comboBox1;
    }
}