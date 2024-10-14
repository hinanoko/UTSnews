using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class PersonalProfile : Form
    {
        public PersonalProfile()
        {
            InitializeComponent();
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            // 从全局状态获取用户的角色、姓名和邮箱
            label2.Text = $"身份: {GlobalState.UserRole}";
            label3.Text = $"姓名: {GlobalState.UserName}";
            label4.Text = $"邮箱: {GlobalState.UserEmail}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 获取新密码
            string newPassword = textBox1.Text;

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("请输入新密码。");
                return;
            }

            // 调用后端API进行密码更新请求
            var success = await ChangePasswordAsync(newPassword);

            if (success)
            {
                MessageBox.Show("密码修改成功！");
            }
            else
            {
                MessageBox.Show("密码修改失败，请重试。");
            }
        }

        private async Task<bool> ChangePasswordAsync(string newPassword)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 构建请求内容，包含用户的邮箱和新密码
                    var content = new StringContent(JsonConvert.SerializeObject(new
                    {
                        Email = GlobalState.UserEmail,
                        NewPassword = newPassword
                    }), Encoding.UTF8, "application/json");

                    // 发送 PUT 请求到后端更改密码的 API
                    HttpResponseMessage response = await client.PutAsync("https://localhost:5132/api/users/changepassword", content);

                    // 检查响应状态码
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("密码修改成功！");
                        return true;
                    }
                    else
                    {
                        // 解析错误信息
                        string responseContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"修改密码失败: {response.ReasonPhrase} - {responseContent}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"请求失败: {ex.Message}");
                return false;
            }
        }

    }
}
