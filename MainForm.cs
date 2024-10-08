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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenNewForm<T>() where T : Form, new()
        {
            var newForm = new T();
            this.Enabled = false; // 禁用主窗体
            newForm.FormClosed += (s, args) => { this.Enabled = true; }; // 新窗体关闭时重新启用主窗体
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenNewForm<LostAndFound>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenNewForm<PersonalProfile>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenNewForm<SubmitFeedback>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenNewForm<ActivityNews>();
        }
    }
}
