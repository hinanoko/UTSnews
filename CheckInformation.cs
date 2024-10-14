using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CheckInformation : Form
    {
        public CheckInformation()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 清空 flowLayoutPanel1 之前的内容
            flowLayoutPanel1.Controls.Clear();

            string email = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }

            // 调用后端 API 查询用户信息
            try
            {
                var users = await GetUsersByEmail(email);

                if (users == null || users.Length == 0)
                {
                    // 如果没有找到用户，显示“无”
                    Label label = new Label
                    {
                        Text = "无",
                        AutoSize = true
                    };
                    flowLayoutPanel1.Controls.Add(label);
                }
                else
                {
                    // 显示找到的用户信息（不显示密码）
                    foreach (var user in users)
                    {
                        var userInfo = $"Name: {user.Name}, Email: {user.Email}, Identification: {user.Identity}";
                        Label label = new Label
                        {
                            Text = userInfo,
                            AutoSize = true
                        };
                        flowLayoutPanel1.Controls.Add(label);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user information: {ex.Message}");
            }
        }

        // 调用后端 API 获取用户信息
        private async Task<CheckUser[]> GetUsersByEmail(string email)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://localhost:5132/api/users/getbyname/{email}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Received JSON: {jsonString}"); // Add this line for debugging
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    };
                    var result = JsonSerializer.Deserialize<CheckUser[]>(jsonString, options);
                    if (result != null)
                    {
                        foreach (var user in result)
                        {
                            Console.WriteLine($"Deserialized user: Id={user.Id}, Name={user.Name}, Email={user.Email}， Identification={user.Identity}"); // Add this line for debugging
                        }
                    }
                    return result;
                }
                else
                {
                    Console.WriteLine($"API request failed with status code: {response.StatusCode}"); // Add this line for debugging
                    return null;
                }
            }
        }
    }

    // 定义与后端相对应的 User 模型类（不包含密码）
    public class CheckUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string Identity { get; set; }
    }
}
