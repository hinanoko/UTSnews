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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = "这是第二个窗体";
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(50, 50); // 设置标签位置
            this.Controls.Add(label); // 添加标签到 Form2
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
