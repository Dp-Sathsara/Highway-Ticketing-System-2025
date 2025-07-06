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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            LoadVehicleData();
        }

        private void LoadVehicleData()
        {
            // Replace this with your actual connection string if different
            string connectionString = "Server=DESKTOP-5EDLUSN\\SQLEXPRESS;Database=HighwayDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Id, VehicleNo,VehicleType, Entrance, EntranceTime FROM VehicleEntry";

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
