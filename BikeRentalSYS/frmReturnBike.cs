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
    public partial class frmReturnBike : Form
    {
        BikeRentalSYS parent;
        private Rentals aRental = new Rentals();
        public frmReturnBike()
        {
            InitializeComponent();
        }

        public frmReturnBike(BikeRentalSYS Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmReturnBike_Load(object sender, EventArgs e)
        {
            loadDetails();
        }
        private void loadDetails()
        {
            //retrive RentalId for all rented bikes (use DataReader)
            DataSet ds = Rentals.getRentalIDsForReturn();

            //move records from ds into cboRentalID()
            cboRentalID.Items.Clear();

            //load combo with rentalID for all rented bikes

            for (int i = 0; i < ds.Tables["RR"].Rows.Count; i++)
                cboRentalID.Items.Add(ds.Tables[0].Rows[i][0]);

        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboRentalID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if selected index is changed because resetting UI, do nothing
            if (cboRentalID.SelectedIndex == -1)
                return;

            //create an instance of RentalID and call a method to instantiate it's instance variables

            aRental.getRentals(Convert.ToInt32(cboRentalID.Text));

            //move values from instances variables to form controls
            dtpReturnDate.Text = aRental.getDateFrom().ToString();
            txtRentalID.Text = aRental.getRentalId().ToString();
            txtName.Text = aRental.getName();
            dtpDOB.Text = aRental.getDob().ToString();
            txtEmail.Text = aRental.getEmail();
            txtNumber.Text = aRental.getPhoneNum();


            grpReturn.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            if (dtpActualDate.Value > dtpReturnDate.Value)
            {
                MessageBox.Show("Bike " + txtRentalID.Text + " Bike returned late. status set to Available (A)", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Bike " + txtRentalID.Text + " Returned on time Bike status set to Available (A)", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            aRental.setRentalId(Convert.ToInt32(txtRentalID.Text));
            aRental.setName(txtName.Text);
            aRental.setDob(dtpDOB.Value);
            aRental.setEmail(txtEmail.Text);
            aRental.setPhoneNum(txtNumber.Text);
            aRental.ReturnRental();

            //Reset UI
            grpReturn.Visible = false;

            loadDetails();

            //reset the ComboBox to no value displayed
            cboRentalID.SelectedIndex = -1;
            return;
        }
    }
}
