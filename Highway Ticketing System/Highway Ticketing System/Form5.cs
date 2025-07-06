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
    public partial class Form5 : Form
    {
        string connectionString = "Server=DESKTOP-5EDLUSN\\SQLEXPRESS;Database=HighwayDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";



        public Form5()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            btnSearch.Click += btnSearch_Click;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Populate vehicle types
            cmbVehicleType.Items.AddRange(new string[]
             {
                "Category 1 (Car,Jeep,Van)", "Category 2 (Bus,light weight Vehicle)", "Category 3 (Heavy Vehicle)"
                
             });

            cmbEntrance.Items.AddRange(new string[]
            {
                "Mattala",  "Kadawatha", 
                "Pinnaduwa", "Kurunegala"
            });

            cmbVehicleType.SelectedIndex = -1;
            cmbEntrance.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string vehicleNo = txtVehicleNo.Text.Trim();
            string vehicleType = cmbVehicleType.SelectedItem?.ToString();
            string entrance = cmbEntrance.SelectedItem?.ToString();
            DateTime entranceTime = DateTime.Now; // add current timestamp

            if (string.IsNullOrEmpty(vehicleNo) || string.IsNullOrEmpty(vehicleType) || string.IsNullOrEmpty(entrance))
            {
                MessageBox.Show("Please fill all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO VehicleEntry (VehicleNo, VehicleType, Entrance, EntranceTime) " +
                               "VALUES (@VehicleNo, @VehicleType, @Entrance, @EntranceTime)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@VehicleNo", vehicleNo);
                    cmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                    cmd.Parameters.AddWithValue("@Entrance", entrance);
                    cmd.Parameters.AddWithValue("@EntranceTime", entranceTime);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vehicle entry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) // duplicate vehicle no
                        {
                            MessageBox.Show("This vehicle number already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string vehicleNo = txtSearchVehicleNo.Text.Trim();

            if (string.IsNullOrWhiteSpace(vehicleNo))
            {
                MessageBox.Show("Please enter a vehicle number.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM VehicleEntry WHERE VehicleNo = @VehicleNo";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@VehicleNo", vehicleNo);

                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Open Form6 with vehicleNo
                                Form6 form6 = new Form6(vehicleNo);
                                form6.Show();
                                this.Hide(); // optional
                            }
                            else
                            {
                                MessageBox.Show("Vehicle number not found.");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error:\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:\n" + ex.Message);
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtVehicleNo.Clear();
            cmbVehicleType.SelectedIndex = -1;
            cmbEntrance.SelectedIndex = -1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchVehicleNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 help = new Form9();
            help.Show();
        }

        private void employeersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 employeers = new Form8();
            employeers.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 register = new Form3();
            register.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 about = new Form10();
            about.Show();
        }

        private void todayStatistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 todayStatist = new Form11();
            todayStatist.Show();
        }
    }
}