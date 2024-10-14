using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private readonly HttpClient _httpClient;
        public Form2()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 获取用户输入的邮箱和密码
            var email = textBox1.Text;
            var password = textBox2.Text;

            // 创建要发送的用户对象
            var user = new User
            {
                Name = "xxx",
                Email = email,
                Password = password,
                Identity = "xxx"
            };

            // 调用后端 API 进行登录
            var response = await _httpClient.PostAsJsonAsync("https://localhost:5132/api/Users/login", user);

            if (response.IsSuccessStatusCode)
            {
                // 登录成功
                var result = await response.Content.ReadAsStringAsync();
                var userResponse = JsonConvert.DeserializeObject<LoginResponse>(result);

                GlobalState.UserName = userResponse.User.Name;
                GlobalState.UserEmail = userResponse.User.Email;
                GlobalState.UserRole = userResponse.User.Identity;

                // 显示成功消息
                MessageBox.Show($"Login successful! Welcome, {userResponse.User.Name}.");

                if(userResponse.User.Identity == "Admin")
                {
                    var AdminForm = new AdminForm();
                    AdminForm.Show();
                    this.Hide();
                }
                else if (userResponse.User.Identity == "Teacher")
                {
                    // 导航到老师窗体
                    var teacherForm = new TeacherForm();
                    teacherForm.Show();
                    this.Hide();
                }
                else if (userResponse.User.Identity == "Student")
                {
                    // 导航到学生窗体
                    var MainForm = new MainForm();
                    MainForm.Show();
                    this.Hide();
                }
                else
                {
                    // 未知身份，显示消息
                    MessageBox.Show("Unknown user identity.");
                }
            }
            else
            {
                // 登录失败
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Login failed: {error}");
            }
        }
    }

    public class User
    {
        public string Name {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Identity { get; set; }
    }

    // 定义登录响应类
    public class LoginResponse
    {
        public string Message { get; set; }
        public User User { get; set; }
    }
}
