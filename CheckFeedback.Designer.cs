﻿namespace WinFormsApp1
{
    partial class CheckFeedback
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 0;
            label1.Text = "CheckFeedback";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(45, 65);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(656, 332);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown; // Set flow direction to top down
            flowLayoutPanel1.AutoScroll = true; // Enable scrolling
                                                // 
                                                // CheckFeedback
                                                // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "CheckFeedback";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}