using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentalSYS
{
    public partial class AddBikeType : Form
    {
        
        BikeRentalSYS parent;
        public AddBikeType()
        {
            InitializeComponent();
        }

        public AddBikeType(BikeRentalSYS Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void mnuback_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //validate data
            if (!txtTypeCode.Text.All(char.IsLetter))
            {
                MessageBox.Show("Bike Type Code is Only Alphabets 2 characters in length");
               txtTypeCode.Focus();

            }
           
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("Please enter Bike Description.");
                txtDescription.Focus();
            }
            else if (!txtRate.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter Rate! Rate must be numberic");
                txtRate.Focus();

            }
            else
            {
                //add the bike type to the database
                BikeType bikeType = new BikeType(txtTypeCode.Text, txtDescription.Text, Convert.ToDecimal(txtRate.Text));

                bikeType.addBikeTypes();

                //display confirmation message
                MessageBox.Show(" Bike Type added ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Reset user interface

                txtTypeCode.Clear();
                txtDescription.Clear();
                txtRate.Clear();
                txtTypeCode.Focus();


            }
        }

    }
}
