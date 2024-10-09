using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class PublishForm : Form
    {
        private string selectedImagePath;

        public PublishForm()
        {
            InitializeComponent();

            comboBox1.Items.Add("lost");
            comboBox1.Items.Add("found");
            comboBox1.SelectedIndex = 0; // 默认选中第一个

            label1.Text = "联系方式";
            label2.Text = "物品描述";
            label3.Text = "物品名称";
            label4.Text = "选择图片";
            button1.Text = "选择图片";
            button2.Text = "提交";

            button1.Click += BtnSelectImage_Click;
            button2.Click += BtnSubmit_Click;
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    selectedImagePath = openFileDialog.FileName;
                }
            }
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            string contactInfo = textBox1.Text;
            string description = textBox2.Text;
            string itemName = textBox3.Text;
            string lostOrFound = comboBox1.SelectedItem.ToString(); // 获取选中的值

            if (string.IsNullOrWhiteSpace(contactInfo) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(itemName) ||
                string.IsNullOrWhiteSpace(selectedImagePath))
            {
                MessageBox.Show("请填写所有信息！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lostAndFound = new LostAndFoundModels
            {
                ItemName = itemName,
                Description = description,
                Phone = contactInfo,
                LostOrFound = lostOrFound, // 使用用户选择的值
                Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Publisher = GlobalState.UserName,
                PublisherID = GlobalState.UserEmail,
                Location = "某个地点", // 可以根据需要设置
            };

            await SendLostAndFoundDataAsync(lostAndFound, selectedImagePath);

            MessageBox.Show("发布成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;
            selectedImagePath = null;
        }

        private async Task SendLostAndFoundDataAsync(LostAndFoundModels lostAndFound, string imagePath)
        {
            using (HttpClient client = new HttpClient())
            {
                using (var content = new MultipartFormDataContent())
                {
                    var json = JsonConvert.SerializeObject(lostAndFound);
                    var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                    content.Add(stringContent, "lostAndFoundJson");

                    byte[] imageData = await File.ReadAllBytesAsync(imagePath);
                    var imageContent = new ByteArrayContent(imageData);
                    imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse(GetMimeType(imagePath));
                    content.Add(imageContent, "image", Path.GetFileName(imagePath));

                    try
                    {
                        var response = await client.PostAsync("https://localhost:5132/api/lostandfound", content);
                        if (!response.IsSuccessStatusCode)
                        {
                            var errorContent = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Error: {response.StatusCode}\n{errorContent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        response.EnsureSuccessStatusCode();
                    }
                    catch (HttpRequestException e)
                    {
                        MessageBox.Show($"Error: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string GetMimeType(string fileName)
        {
            string extension = Path.GetExtension(fileName).ToLowerInvariant();
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                case ".bmp":
                    return "image/bmp";
                default:
                    return "application/octet-stream";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class LostAndFoundModels
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string LostOrFound { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }

        public string Publisher { get; set; }

        public string PublisherID { get; set; }
    }
}