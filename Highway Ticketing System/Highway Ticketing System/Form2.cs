using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Highway_Ticketing_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string employeeID = textBoxUserID.Text.Trim();
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(employeeID) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter Employee ID and Password.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-5EDLUSN\\SQLEXPRESS;Initial Catalog=HighwayDB;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "SELECT EmployeeId FROM Employees WHERE EmployeeId = @id AND Password = @password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", employeeID);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            MessageBox.Show("Login Successful!");

                            this.Hide();
                            using (Form5 dashboardForm = new Form5())
                            {
                                dashboardForm.ShowDialog();
                            }
                            this.Close(); // after Form5 closes
                        }
                        else
                        {
                            MessageBox.Show("Invalid Employee ID or Password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
