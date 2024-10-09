using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SubmitFeedback : Form
    {
        public SubmitFeedback()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 获取邮箱和反馈内容
            string teacherEmail = textBox1.Text;
            string feedbackContent = textBox2.Text;

            // 简单的校验
            if (string.IsNullOrEmpty(teacherEmail))
            {
                MessageBox.Show("Please enter the teacher's email.");
                return;
            }

            if (string.IsNullOrEmpty(feedbackContent))
            {
                MessageBox.Show("Please enter your feedback.");
                return;
            }

            // 这里你可以添加实际的提交逻辑，如发送到服务器或保存到数据库
            MessageBox.Show("Feedback submitted successfully!");

            // 清空输入框
            textBox1.Clear();
            textBox2.Clear();
        }

    }
}
