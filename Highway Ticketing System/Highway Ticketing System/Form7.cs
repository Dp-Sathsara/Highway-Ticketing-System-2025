using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Highway_Ticketing_System
{
    public partial class Form7 : Form
    {
        private string vehicleId;
        private string vehicleType;
        private string entrance;
        private string exit;
        private DateTime entranceTime;
        private string billText = "";
        private PrintDocument printDocument = new PrintDocument();

        public Form7(string vehicleId, string vehicleType, string entrance, string exit, DateTime entranceTime)
        {
            InitializeComponent();
            this.vehicleId = vehicleId;
            this.vehicleType = vehicleType;
            this.entrance = entrance;
            this.exit = exit;
            this.entranceTime = entranceTime;
            btnPrint.Click += new EventHandler(this.btnPrint_Click);


            // Set up the print page event
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Fill form fields
            txtVehicleNo.Text = vehicleId;
            txtVehicleType.Text = vehicleType;
            txtEntrance.Text = entrance;
            txtExit.Text = exit;
            txtEntranceTime.Text = entranceTime.ToString("g"); // e.g., 5/7/2025 2:30 PM

            LoadPrice(); // Fetch and display price from database
        }

        private void LoadPrice()
        {
            string connectionString = "Server=DESKTOP-5EDLUSN\\SQLEXPRESS;Database=HighwayDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"; // Replace with your actual DB connection

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Price FROM Prices WHERE Entrance = @entrance AND HighwayExit = @exit";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@entrance", entrance);
                    cmd.Parameters.AddWithValue("@exit", exit);

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtPrice.Text = result.ToString();
                        }
                        else
                        {
                            txtPrice.Text = "N/A";
                            MessageBox.Show("Price not found for this route.", "No Price Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving price: " + ex.Message);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrepareBillText();

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error printing bill: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void PrepareBillText()
        {
            billText =
                "         HighWay Bill\n\n" +
                "Vehicle No:     " + txtVehicleNo.Text + "\n" +
                "Vehicle Type:   " + txtVehicleType.Text + "\n" +
                "Entrance:       " + txtEntrance.Text + "\n" +
                "Exit:           " + txtExit.Text + "\n" +
                "Entrance Time:  " + txtEntranceTime.Text + "\n" +
                "Price:          Rs. " + txtPrice.Text + "\n\n" +
                "Thank you for using our highway!";
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            float x = 100;
            float y = 100;

            e.Graphics.DrawString(billText, font, Brushes.Black, new PointF(x, y));
        }
    }
    
}
