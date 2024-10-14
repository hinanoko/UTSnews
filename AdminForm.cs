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
    public partial class AdminForm : Form
    {
        public AdminForm()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenNewForm<TeacherSignUp>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenNewForm<LostAndFound>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenNewForm<ActivityNews>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenNewForm<PersonalProfile>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenNewForm<DeleteLost>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenNewForm<DeleteActivity>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenNewForm<CheckInformation>();
        }

    }
}
