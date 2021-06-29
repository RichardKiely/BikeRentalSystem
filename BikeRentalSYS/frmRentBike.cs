using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;



namespace BikeRentalSYS
{
    public partial class frmRentBike : Form
    {
        private BikeType aType = new BikeType();
        private BikeAdd aBike = new BikeAdd();
        private Rentals addRentals = new Rentals();
        private RentalItem addItems = new RentalItem();
        static Regex validate_emailaddress = email_validation();

        int difference = 0;

        BikeRentalSYS parent;
        public frmRentBike()
        {
            InitializeComponent();
        }

        public frmRentBike(BikeRentalSYS Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRentBike_Load(object sender, EventArgs e)
        {
            dtpDateFrom.MinDate = DateTime.Today;
            dtpDateTo.MinDate = dtpDateFrom.Value;
            txtRentID.Text = Rentals.getNextRentalId().ToString().PadLeft(3, '0');
         
        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
           

            if (!txtName.Text.All(char.IsLetter))
            {
                MessageBox.Show("Please enter your Full name", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
            }
            else if (validate_emailaddress.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }
            else
            {

                Rentals addRentals = new Rentals(Convert.ToInt32(txtRentID.Text), dtpDateFrom.Value, dtpDateTo.Value, txtName.Text, dtpDOB.Value, txtEmail.Text, txtPhoneNo.Text, Convert.ToDecimal(txtTotal.Text));

                addRentals.addRental();

                //loop for each item in listbox

                for (int i = 0; i < lstCart.Items.Count; i++)
                {
                    
                        RentalItem addItems = new RentalItem(Convert.ToInt32(txtRentID.Text), Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 3)), Convert.ToDecimal(lstCart.Items[i].ToString().Substring(8, 6)));
                       
                        addItems.addRentalItems();
                }
   

                String message = "Thanks for using our bike Rental System your rental ID is " + txtRentID.Text +
                                 "I hope you are satisfied with our service ";
                
                Utility.sendEmail(txtEmail.Text,message,Convert.ToInt32(txtRentID.Text));
                MessageBox.Show ( "Message Send Successfully");
                
                //Display Confirmation message
                
                txtRentID.Visible = true; lblRentalID.Visible = true;
                MessageBox.Show("Rented Successfully", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                //reset UI

                grpCustomer.Visible = false;
                grpListBoxes.Visible = false;
                dtpDateFrom.ResetText();
                dtpDateTo.ResetText();

               lblTypeCode.Visible = false;
                cboTypeCode.Visible = false;
                lstCart.ClearSelected();
                lstShowBikes.ClearSelected();
                txtRentID.Clear();
                txtRentID.Visible = false;
                lblRentalID.Visible = false;
                txtName.Clear();
                txtEmail.Clear();
                txtPhoneNo.Clear();
                txtTotal.Clear();
                
               
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
                return;
            }

            else
            lstShowBikes.Items.Add(lstCart.Text);
            
            DateTime dateFrom = dtpDateFrom.Value.Date;
            DateTime dateTo = dtpDateTo.Value.Date;
            
            difference = ((TimeSpan)(dateTo - dateFrom)).Days + 1;
           
            txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) - (Convert.ToDecimal(lstCart.Text.Substring(8,6)) * difference)).ToString("000.00");

            lstCart.Items.RemoveAt(lstCart.SelectedIndex);


        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
                return;
            }
            else
            grpCustomer.Visible = true;
        }

        private void cboTypes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // if selected index is changed because resetting UI, do nothing
            if (cboTypeCode.SelectedIndex == -1)
                return;

            Rentals.getAvailableBikes(lstShowBikes, cboTypeCode.Text.Substring(0, 2), dtpDateFrom.Value.ToString("dd-MMM-yy"), dtpDateTo.Value.ToString("dd-MMM-yy"));

            if (lstShowBikes.Items.Count != 0)
            {

                grpListBoxes.Visible = true;

            }
            else
            {
                MessageBox.Show("No bikes available please choose a different type!");
                return;
            }

        }

        private void btnAddBike_Click(object sender, EventArgs e)
        {
            if (lstShowBikes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!"); 
                return;
            }
            else
            //Add selected bike to shopping cart
            lstCart.Items.Add(lstShowBikes.Text);

                //Calculate the cost of this bike for dates 
                DateTime dateFrom = dtpDateFrom.Value.Date;
                DateTime dateTo = dtpDateTo.Value.Date;

                int difference = ((TimeSpan)(dateTo - dateFrom)).Days + 1;

                //Update total for shopping cart
                txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + (Convert.ToDecimal(lstShowBikes.Text.Substring(8, 6)) * difference)).ToString("000.00");

                //clear
                lstShowBikes.Items.RemoveAt(lstShowBikes.SelectedIndex);
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dtpDateFrom.Value > dtpDateTo.Value)
            {
                MessageBox.Show("Please select date before date To!");
                dtpDateFrom.Focus();
                return;
            }

            if (dtpDateFrom.Value.ToString() == "")
            {
                MessageBox.Show("Please select date!");
                dtpDateFrom.Focus();
                return;
            }
            if (dtpDateTo.Value.ToString() == "")
            {
                MessageBox.Show("Please select date!");
                dtpDateTo.Focus();
                return;
            }

            lblTypeCode.Visible = true;
            cboTypeCode.Visible = true;

            DateTime dateFrom = dtpDateFrom.Value.Date;
            DateTime dateTo = dtpDateTo.Value.Date;

            int difference = ((TimeSpan)(dateTo - dateFrom)).Days + 1;

            lblDays.Text = difference.ToString();

            cboTypeCode.Visible = true;

            Utility.getTypes(cboTypeCode);

            lstShowBikes.Visible = true;

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            string no = txtPhoneNo.Text;
            Regex regex = new Regex(@"^(^[0][1-9]\d{8}$)+$");
            Match match = regex.Match(no);
            if (match.Success)
            {
                lblError.ForeColor = Color.Green;
                lblError.Text = "Phone number is valid";
            }
            else
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Phone number is not valid";
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
