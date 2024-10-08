using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();

            // 设置标签样式
            label1.ForeColor = Color.Red; // 将字体颜色设置为红色
            label1.Font = new Font(label1.Font.FontFamily, 14, label1.Font.Style);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 这里可以添加 label1 被点击时的逻辑
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // 当 textBox1 内容改变时的逻辑（可选）
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // 当 textBox1 内容改变时的逻辑（可选）
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // 当 textBox1 内容改变时的逻辑（可选）
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // 当 textBox1 内容改变时的逻辑（可选）
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // 这里可以添加 label2 被点击时的逻辑（可选）
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // 这里可以添加 label3 被点击时的逻辑（可选）
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // 这里可以添加 label4 被点击时的逻辑（可选）
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // 这里可以添加 label5 被点击时的逻辑（可选）
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            // 获取用户输入
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;

            // 简单验证
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("请填写所有字段！");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("密码和确认密码不匹配！");
                return;
            }

            // 准备用户数据
            var user = new
            {
                Name = name,
                Email = email,
                Password = password,
                Identity = "Student"
            };

            // 序列化用户数据为 JSON
            string jsonData = JsonSerializer.Serialize(user);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // 发送 POST 请求到后端 API
            try
            {
                HttpResponseMessage response = await client.PostAsync("https://localhost:5132/api/Users", content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("注册失败，请稍后再试。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"请求失败：{ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // 打开 Form2
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
