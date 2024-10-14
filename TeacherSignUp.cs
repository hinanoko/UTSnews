using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TeacherSignUp : Form
    {
        public TeacherSignUp()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            string confirmPassword = textBox4.Text;

            // Simple validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            var newTeacher = new
            {
                Name = name,
                Email = email,
                Password = password,
                Identity = "Teacher"
            };

            // Convert the teacher data to JSON
            string jsonData = JsonConvert.SerializeObject(newTeacher);

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5132/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                try
                {
                    // Post the data to the register API
                    HttpResponseMessage response = await client.PostAsync("api/Users/register", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Teacher registered successfully!");
                        // Clear the fields after successful registration
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Registration failed: {errorResponse}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
