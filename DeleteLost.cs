using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DeleteLost : Form
    {
        public DeleteLost()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // 获取输入的ID
            string idText = textBox1.Text;

            // 验证输入
            if (string.IsNullOrEmpty(idText) || !int.TryParse(idText, out int id))
            {
                MessageBox.Show("请输入有效的ID");
                return;
            }

            // 调用删除API
            bool isDeleted = await DeleteLostAndFoundAsync(id);

            if (isDeleted)
            {
                MessageBox.Show("失物招领信息删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败，请检查ID是否正确。");
            }
        }

        // 调用后端API删除失物招领信息
        private async Task<bool> DeleteLostAndFoundAsync(int id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 设置后端API的URL
                    string url = $"https://localhost:5132/api/lostandfound/{id}";

                    // 发起DELETE请求
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    // 检查响应状态码
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
