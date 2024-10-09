using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class LostAndFound : Form
    {
        private Button btnPublish;
        private HttpClient httpClient;
        private const string BaseUrl = "https://localhost:5132/api/lostandfound"; // Update this with your actual API URL
        private FlowLayoutPanel lostItemsPanel;
        private FlowLayoutPanel foundItemsPanel;

        public LostAndFound()
        {
            InitializeComponent();
            InitializePublishButton();
            InitializeItemPanels();
            InitializeHttpClient();
            LoadLostAndFoundItems();
        }

        private void InitializePublishButton()
        {
            btnPublish = new Button();
            btnPublish.Location = new Point(700, 10);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(75, 30);
            btnPublish.Text = "发布";
            btnPublish.UseVisualStyleBackColor = true;
            btnPublish.Click += BtnPublish_Click;

            this.Controls.Add(btnPublish);
        }

        private void InitializeHttpClient()
        {
            httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        private void InitializeItemPanels()
        {
            lostItemsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true
            };
            foundItemsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true
            };

            tabPage1.Controls.Add(lostItemsPanel);
            tabPage2.Controls.Add(foundItemsPanel);
        }

        private async void LoadLostAndFoundItems()
        {
            await LoadLostItems();
            await LoadFoundItems();
        }

        private async Task LoadLostItems()
        {
            try
            {
                string response = await httpClient.GetStringAsync($"{BaseUrl}/lost");
                List<NewLostAndFoundModels> lostItems = JsonConvert.DeserializeObject<List<NewLostAndFoundModels>>(response);

                lostItemsPanel.SuspendLayout();
                foreach (var item in lostItems)
                {
                    var itemControl = new ItemControl(item)
                    {
                        Width = 300,
                        Margin = new Padding(10)
                    };
                    lostItemsPanel.Controls.Add(itemControl);
                }
                lostItemsPanel.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading lost items: {ex.Message}");
            }
        }

        private async Task LoadFoundItems()
        {
            try
            {
                string response = await httpClient.GetStringAsync($"{BaseUrl}/found");
                List<NewLostAndFoundModels> foundItems = JsonConvert.DeserializeObject<List<NewLostAndFoundModels>>(response);

                foundItemsPanel.SuspendLayout();
                foreach (var item in foundItems)
                {
                    var itemControl = new ItemControl(item)
                    {
                        Width = 300,
                        Margin = new Padding(10)
                    };
                    foundItemsPanel.Controls.Add(itemControl);
                }
                foundItemsPanel.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading found items: {ex.Message}");
            }
        }

        private Image ConvertBase64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String.Split(',')[1]);
                using (var ms = new System.IO.MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    return Image.FromStream(ms, true);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void BtnPublish_Click(object sender, EventArgs e)
        {
            PublishForm publishForm = new PublishForm();
            publishForm.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class NewLostAndFoundModels
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string LostOrFound { get; set; }
        public string Publisher { get; set; }
        public string PublisherID { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
    }

    public class ItemControl : UserControl
    {
        public ItemControl(NewLostAndFoundModels item)
        {
            InitializeComponent();
            labelItemName.Text = $"Item: {item.ItemName}";
            labelDescription.Text = $"Description: {item.Description}";
            labelPhone.Text = $"Phone: {item.Phone}";
            labelPublisher.Text = $"Publisher: {item.Publisher}";
            labelTime.Text = $"Time: {item.Time}";
            labelLocation.Text = $"Location: {item.Location}";
            if (!string.IsNullOrEmpty(item.Image))
            {
                pictureBoxItem.Image = ConvertBase64ToImage(item.Image);
                pictureBoxItem.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private Label labelItemName;
        private Label labelDescription;
        private Label labelPhone;
        private Label labelPublisher;
        private Label labelTime;
        private Label labelLocation;
        private PictureBox pictureBoxItem;

        private void InitializeComponent()
        {
            this.labelItemName = new Label();
            this.labelDescription = new Label();
            this.labelPhone = new Label();
            this.labelPublisher = new Label();
            this.labelTime = new Label();
            this.labelLocation = new Label();
            this.pictureBoxItem = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();

            // 设置标签
            this.labelItemName = new Label { AutoSize = true, Location = new Point(3, 3) };
            this.labelDescription = new Label { AutoSize = true, Location = new Point(3, 20) };
            this.labelPhone = new Label { AutoSize = true, Location = new Point(3, 37) };
            this.labelPublisher = new Label { AutoSize = true, Location = new Point(3, 54) };
            this.labelTime = new Label { AutoSize = true, Location = new Point(3, 71) };
            this.labelLocation = new Label { AutoSize = true, Location = new Point(3, 88) };

            // 设置图片框
            this.pictureBoxItem = new PictureBox
            {
                Location = new Point(3, 105),
                Size = new Size(280, 180),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            // 添加控件
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.pictureBoxItem);

            // 设置 UserControl 大小
            this.Size = new Size(300, 300);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Image ConvertBase64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String.Split(',')[1]);
                using (var ms = new System.IO.MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    return Image.FromStream(ms, true);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
