using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Highway_Ticketing_System
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            // Replace this with your actual connection string if different
            string connectionString = "Server=DESKTOP-5EDLUSN\\SQLEXPRESS;Database=HighwayDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT EmployeeId, Name, NIC, Address, Age FROM Employees";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee data: " + ex.Message);
                }
            }
        }
    }
}
