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
    public partial class frmRemove : Form
    {
        BikeRentalSYS parent;
        private BikeAdd aBike = new BikeAdd();
        public frmRemove()
        {
            InitializeComponent();
        }

        public frmRemove(BikeRentalSYS Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRemove_Load(object sender, EventArgs e)
        {
            loadBikes();
        }

        private void loadBikes()
        {
            //retrive BikeId for all available bikes (use DataReader)
            DataSet ds = BikeAdd.getSummaryBikeID();

            //move records from ds into cboBikeID
            cboBikeID.Items.Clear();

            //load combo with id and type for all Bikes

            for (int i = 0; i < ds.Tables["WS"].Rows.Count; i++)
                cboBikeID.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " +
                   ds.Tables[0].Rows[i][1].ToString());
        }

        private void cboBikeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if selected index is changed because resetting UI, do nothing
            if (cboBikeID.SelectedIndex == -1)
                return;

            //create an instance of typeCode and call a method to instantiate it's instance variables

            Utility.getTypes(cboTypeCode);

            aBike.getBikes(Convert.ToInt32(cboBikeID.Text.Substring(0, 3)));

            //move values from instances variables to form controls
            txtBikeId.Text = aBike.getId().ToString();

            //Set typeCode to current typeCode

            cboTypeCode.SelectedIndex = 0;
            while (!cboTypeCode.Text.Substring(0, 2).Equals(aBike.getType()))
            {
                cboTypeCode.SelectedIndex++;
            }
            txtMan.Text = aBike.getManufacturer();
            txtGears.Text = aBike.getGears().ToString();
            txtWheels.Text = aBike.getWheelSize().ToString();

            //display data for editing
            grpBike.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                //instantiate an instance of a Bike with values in form controls
                aBike.setType(cboTypeCode.Text);
                aBike.setManufacturer(txtMan.Text);
                aBike.setGears(Convert.ToInt32(txtGears.Text));
                aBike.setWheelSize(Convert.ToInt32(txtWheels.Text));

                //invoke the removeBike() method
                aBike.removeBike();

                //display confirmation message
                MessageBox.Show("Bike " + cboBikeID.Text + " Successfully Removed Status changed to 'O' ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset UI
                grpBike.Visible = false;
                loadBikes();
                //reset the ComboBox to no value displayed
                cboBikeID.SelectedIndex = -1;
            
        }
    }
}
