using Oracle.ManagedDataAccess.Client;
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
    public partial class BikeRentalSYS : Form
    {

        public BikeRentalSYS()
        {
            InitializeComponent();
        }

       

        private void picMain_Click(object sender, EventArgs e)
        {

        }
        private void mnuAddDate_Click(object sender, EventArgs e)
        {
            frmBikeAdd nextForm = new frmBikeAdd(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuChangeBike_Click(object sender, EventArgs e)
        {
            frmBikeUpdate nextForm = new frmBikeUpdate(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuAddBike_Click(object sender, EventArgs e)
        {
            AddBikeType nextForm = new AddBikeType(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuAnalyseRev_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysis nextForm = new frmRevenueAnalysis(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //ask user to confirm exit

            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialog1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            frmRemove nextForm = new frmRemove(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRentBike_Click(object sender, EventArgs e)
        {
            frmRentBike nextForm = new frmRentBike(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuReturnBike_Click(object sender, EventArgs e)
        {
           frmReturnBike nextForm = new frmReturnBike(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuCancelRental_Click_1(object sender, EventArgs e)
        {
            frmCancel nextForm = new frmCancel(this);
            this.Hide();
            nextForm.Show();
        }

     

        private void mnuCollectBike_Click(object sender, EventArgs e)
        {
            frmCollectBike nextForm = new frmCollectBike(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRemove_Click(object sender, EventArgs e)
        {
            frmRemove nextForm = new frmRemove(this);
            this.Hide();
            nextForm.Show();
        }

        private void BikeRentalSYS_Load(object sender, EventArgs e)
        {

        }

        private void mnuYearly_Click(object sender, EventArgs e)
        {
            frmListYearlyRentals nextForm = new frmListYearlyRentals(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRental_Click(object sender, EventArgs e)
        {

        }
    }
}
