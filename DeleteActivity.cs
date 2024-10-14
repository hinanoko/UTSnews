using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DeleteActivity : Form
    {
        public DeleteActivity()
        {
            InitializeComponent();
            button1.Click += button1_Click; // 为按钮添加点击事件
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 获取输入的ID
            string activityId = textBox1.Text;

            // 验证输入的ID是否为空或无效
            if (string.IsNullOrWhiteSpace(activityId) || !int.TryParse(activityId, out int parsedId))
            {
                MessageBox.Show("请输入有效的活动 ID");
                return;
            }

            // 调用后端API删除指定ID的活动
            bool isDeleted = await DeleteActivityByIdAsync(parsedId);

            if (isDeleted)
            {
                MessageBox.Show($"活动 ID {activityId} 删除成功！");
            }
            else
            {
                MessageBox.Show($"无法删除活动 ID {activityId}，请检查是否存在该活动。");
            }
        }

        private async Task<bool> DeleteActivityByIdAsync(int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 发送 DELETE 请求到后端API
                    HttpResponseMessage response = await client.DeleteAsync($"https://localhost:5132/api/activity/{id}");

                    // 检查响应状态码，成功返回true
                    return response.IsSuccessStatusCode;
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
