using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PublishActivity : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public PublishActivity()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 获取用户输入的标题和内容
            string title = textBox1.Text;
            string content = textBox2.Text;

            // 检查标题和内容是否为空
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Title and Content cannot be empty");
                return;
            }

            // 创建一个 ActivityModels 对象
            var activity = new
            {
                Title = title,
                Content = content
            };

            try
            {
                // 将对象序列化为 JSON
                string jsonContent = JsonConvert.SerializeObject(activity);

                // 构建 POST 请求
                var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // 发送请求到后端 API
                HttpResponseMessage response = await client.PostAsync("https://localhost:5132/api/Activity", httpContent);

                // 检查响应是否成功
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Activity published successfully!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to publish activity. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
