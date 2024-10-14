using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class CheckFeedback : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public CheckFeedback()
        {
            InitializeComponent();
            LoadFeedbacks();
        }

        private async void LoadFeedbacks()
        {
            try
            {
                string apiUrl = $"https://localhost:5132/api/Feedback/by-email?email={Uri.EscapeDataString(GlobalState.UserEmail)}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    List<FeedbackModel> feedbacks = JsonConvert.DeserializeObject<List<FeedbackModel>>(content);

                    DisplayFeedbacks(feedbacks);
                }
                else
                {
                    MessageBox.Show($"Failed to retrieve feedback. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DisplayFeedbacks(List<FeedbackModel> feedbacks)
        {
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.Controls.Clear();

            foreach (var feedback in feedbacks)
            {
                // 为每条反馈创建一个面板
                Panel panel = new Panel
                {
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Padding = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                    // 不设置 Width，让它自动适应 FlowLayoutPanel 的宽度
                };

                // 创建一个标签以显示日期和学生姓名
                Label lblInfo = new Label
                {
                    AutoSize = true,
                    Text = $"日期: {feedback.SubmissionDate:yyyy-MM-dd HH:mm}\n来自: {feedback.StudentName}"
                };

                // 创建一个标签显示反馈内容
                Label lblContent = new Label
                {
                    AutoSize = true, // 设置为 true 以允许其根据文本扩展
                    Text = feedback.message
                };

                // 将标签添加到面板中
                panel.Controls.Add(lblInfo);
                panel.Controls.Add(lblContent);

                // 调整标签的位置
                lblContent.Location = new Point(0, lblInfo.Height + 5); // 放在信息标签下方

                // 将面板添加到 FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(panel);
            }

            flowLayoutPanel1.ResumeLayout();
        }

    }

    public class FeedbackModel
    {
        public int Id { get; set; }
        public string TeacherEmail { get; set; }
        public string StudentName { get; set; }
        public string message { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
