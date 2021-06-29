using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentalSYS
{
    public partial class frmBikeAdd : Form
    {
        BikeRentalSYS parent;

        public frmBikeAdd()
        {
            InitializeComponent();
        }

        public frmBikeAdd(BikeRentalSYS Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmBikeAdd_Load(object sender, EventArgs e)
        {
            Utility.getTypes(cboTypes);
            //get next Bike Id and load on UI
            txtid.Text = BikeAdd.getNextId().ToString();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            //validate data
    
            if (txtManufactuer.Text == "")
            {
                MessageBox.Show("Manufacturer must be entered");
                txtManufactuer.Focus();
            }
            else if (!txtGears.Text.All(char.IsDigit))
            {
                MessageBox.Show("Gears must be numberic");
                txtGears.Focus();

            }
            else if (!txtWheelSize.Text.All(char.IsDigit))
            {
                MessageBox.Show("Wheelsize must be numberic");
                txtWheelSize.Focus();

            }
            else
            {
                //add the bike to the database
                BikeAdd addB = new BikeAdd(Convert.ToInt32(txtid.Text), cboTypes.Text.Substring(0,2),
                txtManufactuer.Text, Convert.ToInt32(txtGears.Text), Convert.ToInt32(txtWheelSize.Text), "A");

                addB.addBike();

                //display confirmation message
                MessageBox.Show("Bike Added Status = 'A' ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //reset the UI
                cboTypes.SelectedIndex = -1;
                txtManufactuer.Clear();
                txtGears.Clear();
                txtWheelSize.Clear();
                txtid.Text = BikeAdd.getNextId().ToString();
                cboTypes.Focus();
  
            }

        }

        private void mnuback_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
