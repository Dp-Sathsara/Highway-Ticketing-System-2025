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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Highway_Ticketing_System
{
    public partial class Form6 : Form
    {
        private string connectionString = "Server=DESKTOP-5EDLUSN\\SQLEXPRESS;Database=HighwayDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private string vehicleNo;

        public Form6(string vehicleNoFromForm5)
        {
            InitializeComponent();
            vehicleNo = vehicleNoFromForm5;
            button1.Click += new EventHandler(this.button1_Click);
            buttonBack.Click += new EventHandler(this.buttonBack_Click);



        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadVehicleDetails();
            LoadExitPlaces();
        }

        private void LoadVehicleDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT VehicleType, EntranceTime FROM VehicleEntry WHERE VehicleNo = @VehicleNo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VehicleNo", vehicleNo);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtVehicleNo.Text = vehicleNo;
                    txtVehicleType.Text = reader["VehicleType"].ToString();
                    textBoxEntranceTime.Text = reader["EntranceTime"].ToString();
                }
                else
                {
                    MessageBox.Show("Vehicle not found!");
                }
                conn.Close();
            }
        }

        private void LoadExitPlaces()
        {
            cmbHighwayExit.Items.Clear();
            cmbHighwayExit.Items.Add("Agunakolpelassa");
            cmbHighwayExit.Items.Add("Imaduwa");
            cmbHighwayExit.Items.Add("Beliatta");
            cmbHighwayExit.Items.Add("Peliyagoda");
            cmbHighwayExit.Items.Add("Mirigama");
            cmbHighwayExit.SelectedIndex = 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Close(); // or navigate to previous form
        }






        private void button1_Click(object sender, EventArgs e)
        {
            string vehicleNo = txtVehicleNo.Text;
            string exit = cmbHighwayExit.Text;

            if (string.IsNullOrEmpty(vehicleNo) || string.IsNullOrEmpty(exit))
            {
                MessageBox.Show("Please enter Vehicle No and select Exit.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //string connectionString = "Server=DESKTOP-5EDLUSN\\SQLEXPRESS;Database=HighwayDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT VehicleType, Entrance, EntranceTime FROM VehicleEntry WHERE VehicleNo = @vehicleNo";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@vehicleNo", vehicleNo);

                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string vehicleType = reader["VehicleType"].ToString();
                                string entrance = reader["Entrance"].ToString();
                                DateTime entranceTime = Convert.ToDateTime(reader["EntranceTime"]);

                                // ✅ Open Form7 with all details
                                Form7 billForm = new Form7(vehicleNo, vehicleType, entrance, exit, entranceTime);
                                billForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Vehicle not found in database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }


        }
    }
}

