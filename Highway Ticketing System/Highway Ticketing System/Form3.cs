using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Highway_Ticketing_System
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxRePassword.PasswordChar = '*';


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string nic = textBoxNIC.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string age = textBoxAge.Text.Trim();
            string password = textBoxPassword.Text;
            string rePassword = textBoxRePassword.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(nic) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(age) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(rePassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != rePassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-5EDLUSN\\SQLEXPRESS;Initial Catalog=HighwayDB;Trusted_Connection=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int nextId = GetNextEmployeeId(connection);
                    string employeeId = $"HTS{nextId}";

                    string insertQuery = "INSERT INTO Employees (EmployeeId, Name, NIC, Address, Age, Password) " +
                                         "VALUES (@id, @name, @nic, @address, @age, @password)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@nic", nic);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@password", password);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful! Please login now.");

                    this.Hide();
                    using (Form4 successForm = new Form4(employeeId))
                    {
                        successForm.ShowDialog();
                    }
                    this.Close();

                    // Optional: Clear fields if you want to reuse this form without restarting
                    textBoxName.Clear();
                    textBoxNIC.Clear();
                    textBoxAddress.Clear();
                    textBoxAge.Clear();
                    textBoxPassword.Clear();
                    textBoxRePassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetNextEmployeeId(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Employees";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count + 1;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}
