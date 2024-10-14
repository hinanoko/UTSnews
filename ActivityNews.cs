using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class ActivityNews : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public ActivityNews()
        {
            InitializeComponent();
            LoadActivityNews();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            PublishActivity publishActivity = new PublishActivity();
            publishActivity.ShowDialog();
        }

        private async void LoadActivityNews()
        {
            List<NewsItem> newsItems = await GetActivityNewsAsync(); // 获取新闻数据

            flowLayoutPanel1.Controls.Clear(); // 清除旧的数据

            foreach (var news in newsItems)
            {
                // 创建新闻的 Panel
                Panel newsPanel = new Panel
                {
                    Width = flowLayoutPanel1.ClientSize.Width - 20,
                    Height = 150, // 设置高度，调整为合适的值
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(0, 0, 0, 10) // 设置垂直间距
                };

                // 创建标题的 Label
                Label titleLabel = new Label
                {
                    Text = news.Title,
                    AutoSize = false,
                    Width = newsPanel.Width - 20,
                    Height = 30, // 设置标题高度
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft,
                    ForeColor = Color.DarkBlue, // 可自定义颜色
                    Margin = new Padding(0, 0, 0, 5) // 标题和正文之间的间距
                };

                // 创建正文的 Label
                Label contentLabel = new Label
                {
                    Text = news.Content,
                    AutoSize = false,
                    Width = newsPanel.Width - 20,
                    Height = newsPanel.Height - 50, // 设置正文高度，调整合适的值
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    TextAlign = ContentAlignment.TopLeft
                };

                // 将标题和正文分别添加到 Panel 中
                newsPanel.Controls.Add(titleLabel);
                newsPanel.Controls.Add(contentLabel);

                // 控制标题和正文的布局
                titleLabel.Location = new Point(10, 10); // 标题位置
                contentLabel.Location = new Point(10, titleLabel.Bottom + 5); // 正文在标题下方

                // 添加新闻 Panel 到 FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(newsPanel);
            }
        }

        private async Task<List<NewsItem>> GetActivityNewsAsync()
        {
            try
            {
                string apiUrl = "https://localhost:5132/api/Activity"; // 后端API地址
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    List<NewsItem> newsItems = JsonConvert.DeserializeObject<List<NewsItem>>(content);
                    return newsItems;
                }
                else
                {
                    MessageBox.Show($"Failed to retrieve news. Status code: {response.StatusCode}");
                    return new List<NewsItem>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new List<NewsItem>();
            }
        }
    }

    // 定义新闻类
    public class NewsItem
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
