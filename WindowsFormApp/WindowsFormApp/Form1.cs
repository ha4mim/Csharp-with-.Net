using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtFirstName.Text = " ";
            txtLastName.Text = " ";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fullName = firstName + " " + lastName;
            MessageBox.Show("Welcome"+"\n "+fullName);
        }
    }
}
