using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Highway_Ticketing_System
{
    public partial class Form4 : Form
    {

        private readonly string employeeId;
        public Form4(string empId)

        {
            InitializeComponent();
            employeeId = empId;
            buttonContinue.Click += new EventHandler(this.buttonContinue_Click);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Show a message indicating successful registration or login
            labelSuccess.Text = $"Success!\nYour Employee ID is: {employeeId}";

        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.Hide();

                
            using (Form2 loginForm = new Form2())
            {
                loginForm.ShowDialog();
            }
            this.Close();
        }

    }  
    
}
