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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 77);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "Personal Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 162);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 1;
            label2.Text = "Role: Teacher"; // 示例内容，可根据用户角色动态设置
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 206);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 2;
            label3.Text = "Email: user@example.com"; // 示例内容，可根据用户邮箱动态设置
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 116);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 3;
            label4.Text = "Name: John Doe"; // 示例内容，可根据用户姓名动态设置
            // 
            // button1
            // 
            button1.Location = new Point(449, 247);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Update Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new EventHandler(button1_Click);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 5;
            textBox1.PlaceholderText = "Enter new password"; // 添加占位符
            // 
            // PersonalProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonalProfile";
            Text = "Personal Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
    }
}
