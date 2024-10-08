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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // 创建 Form1 窗体实例
            form1.Show(); // 显示 Form1
            this.Hide(); // 隐藏当前的 Form3 窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // 创建 Form2 窗体实例
            form2.Show(); // 显示 Form2
            this.Hide(); // 隐藏当前的 Form3 窗体
        }
    }
}
