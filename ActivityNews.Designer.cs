namespace WinFormsApp1
{
    partial class ActivityNews
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;

        /// <summary>
        /// 清理正在使用的资源
        /// </summary>
        /// <param name="disposing">是否需要释放托管资源</param>
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
        /// 设计器生成的代码
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 0;
            label1.Text = "Activity News";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(16, 51);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(762, 382);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            button1.Location = new Point(609, 9);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 1;
            button1.Text = "Publish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ActivityNews
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ActivityNews";
            Text = "Activity News";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
    }
}
