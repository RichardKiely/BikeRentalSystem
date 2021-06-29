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
    public partial class frmCancel : Form
    {
        BikeRentalSYS parent;
        private Rentals aRental = new Rentals();
        public frmCancel()
        {
            InitializeComponent();
        }

        public frmCancel(BikeRentalSYS Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmCancel_Load(object sender, EventArgs e)
        {
            loadDetails();
        }

        private void loadDetails()
        {
            //retrive RentalId  for all available bikes (use DataReader)
            DataSet ds = Rentals.getRentalIDs();

            //move records from ds into cboRentalID
            cboRentalID.Items.Clear();

            //load combo with rentalID for all available Bikes

            for (int i = 0; i < ds.Tables["WS"].Rows.Count; i++)
                cboRentalID.Items.Add(ds.Tables[0].Rows[i][0]);

        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if selected index is changed because resetting UI, do nothing
            if (cboRentalID.SelectedIndex == -1)
                return;

            //create an instance of rentalID and call a method to instantiate it's instance variables

            aRental.getRentals(Convert.ToInt32(cboRentalID.Text));

            //move values from instances variables to form controls
            txtRentalID.Text = aRental.getRentalId().ToString();
            txtName.Text = aRental.getName();
            dtpDOB.Text = aRental.getDob().ToString();
            txtEmail.Text = aRental.getEmail();
            txtNumber.Text = aRental.getPhoneNum();
            

            grpCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            aRental.setRentalId(Convert.ToInt32(txtRentalID.Text));
            aRental.setName(txtName.Text);
            aRental.setDob(dtpDOB.Value);
            aRental.setEmail(txtEmail.Text);
            aRental.setPhoneNum(txtNumber.Text);
            aRental.CancelRental();

            //display confirmation message
            MessageBox.Show("Rental " + txtRentalID.Text + " Cancelled", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grpCancel.Visible = false;

            loadDetails();

            //reset the ComboBox to no value displayed
            cboRentalID.SelectedIndex = -1;
            return;
        }
    }
}
