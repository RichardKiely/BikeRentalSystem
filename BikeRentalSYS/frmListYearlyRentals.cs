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
    public partial class frmListYearlyRentals : Form
    {
        BikeRentalSYS parent;
        public frmListYearlyRentals()
        {
            InitializeComponent();
        }
        public frmListYearlyRentals(BikeRentalSYS Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmListYearlyRentals_Load(object sender, EventArgs e)
        {
            Utility.loadYears(cboTypes);
        }

        private void cboTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

            chtYearlyRentals.Visible = false;

            //this loop updates the revenue for the months that DO have a value
            DataSet ds = Rentals.YearlyRentals(cboTypes.Text.Substring(2, 2));
           
            //check that rentals exist

            if(ds.Tables["TC"].Rows.Count == 0)
            {
                MessageBox.Show("No rental data for this year");
                return;
            }

            string[] typecode = new string[ds.Tables["TC"].Rows.Count];
            decimal[] Revenue = new decimal[ds.Tables["TC"].Rows.Count];

            for (int i = 0; i < ds.Tables["TC"].Rows.Count; i++)
            {
                typecode[i] = ds.Tables["TC"].Rows[i][0].ToString(); 
                Revenue[i] = Convert.ToDecimal(ds.Tables["TC"].Rows[i][1]);
            }

            //Add titles, intervals to the chart
            chtYearlyRentals.Titles.Clear();
            chtYearlyRentals.Titles.Add("Revenue " + cboTypes.Text);
            chtYearlyRentals.ChartAreas[0].AxisX.Interval = 1;
            chtYearlyRentals.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtYearlyRentals.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtYearlyRentals.Series[0].LegendText = "Income in €";
            chtYearlyRentals.Series[0].Points.DataBindXY(typecode, Revenue);
            chtYearlyRentals.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

          
            chtYearlyRentals.Series[0].Label = "#VALY";
            chtYearlyRentals.Visible = true;

        }
    }
    }
