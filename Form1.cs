using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();

            // ���ñ�ǩ��ʽ
            label1.ForeColor = Color.Red; // ��������ɫ����Ϊ��ɫ
            label1.Font = new Font(label1.Font.FontFamily, 14, label1.Font.Style);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // ���������� label1 �����ʱ���߼�
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // �� textBox1 ���ݸı�ʱ���߼�����ѡ��
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // �� textBox1 ���ݸı�ʱ���߼�����ѡ��
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // �� textBox1 ���ݸı�ʱ���߼�����ѡ��
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // �� textBox1 ���ݸı�ʱ���߼�����ѡ��
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // ���������� label2 �����ʱ���߼�����ѡ��
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // ���������� label3 �����ʱ���߼�����ѡ��
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // ���������� label4 �����ʱ���߼�����ѡ��
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // ���������� label5 �����ʱ���߼�����ѡ��
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            // ��ȡ�û�����
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;

            // ����֤
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("����д�����ֶΣ�");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("�����ȷ�����벻ƥ�䣡");
                return;
            }

            // ׼���û�����
            var user = new
            {
                Name = name,
                Email = email,
                Password = password,
                Identity = "Student"
            };

            // ���л��û�����Ϊ JSON
            string jsonData = JsonSerializer.Serialize(user);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // ���� POST ���󵽺�� API
            try
            {
                HttpResponseMessage response = await client.PostAsync("https://localhost:5132/api/Users", content);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("ע��ʧ�ܣ����Ժ����ԡ�");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"����ʧ�ܣ�{ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // �� Form2
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
