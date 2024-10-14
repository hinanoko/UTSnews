using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class SubmitFeedback : Form
    {
        private static readonly HttpClient client = new HttpClient(new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true // Bypass SSL validation for testing
        });

        public SubmitFeedback()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submit button clicked!"); // Log to check if button click works

            // 获取邮箱和反馈内容
            string teacherEmail = textBox1.Text;
            string feedbackContent = textBox2.Text;
            string studentName = "APP"; // Static student name for now
            DateTime submissionDate = DateTime.Now;

            // 简单的校验
            if (string.IsNullOrEmpty(teacherEmail))
            {
                MessageBox.Show("Please enter the teacher's email.");
                return;
            }

            if (string.IsNullOrEmpty(feedbackContent))
            {
                MessageBox.Show("Please enter your feedback.");
                return;
            }

            // 创建反馈对象，包含教师邮箱、学生姓名、反馈消息和提交日期
            var feedback = new
            {
                TeacherEmail = teacherEmail,
                StudentName = studentName,
                Message = feedbackContent,
                SubmissionDate = submissionDate.ToString("yyyy-MM-dd")
            };

            // Log the feedback object for debugging
            MessageBox.Show($"Sending feedback:\nTeacherEmail: {teacherEmail}\nMessage: {feedbackContent}\nDate: {submissionDate.ToString("yyyy-MM-dd")}");

            // 将反馈对象转换为JSON
            var json = JsonConvert.SerializeObject(feedback);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                // 调用API将反馈信息提交到后端
                var response = await client.PostAsync("https://localhost:5132/api/Feedback/Create", content); // Updated port and case

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Feedback submitted successfully!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show($"Failed to submit feedback. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
