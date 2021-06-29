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
    public partial class frmRevenueAnalysis : Form
    {
        BikeRentalSYS parent;
        Rentals revenue = new Rentals();
        public frmRevenueAnalysis()
        {
            InitializeComponent();
        }

        public frmRevenueAnalysis(BikeRentalSYS Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            Utility.loadYears(cboRevenue);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";

                    }
                case 2:
                    {
                        return "FEB";

                    }
                case 3:
                    {
                        return "MAR";

                    }
                case 4:
                    {
                        return "APR";

                    }
                case 5:
                    {
                        return "MAY";

                    }
                case 6:
                    {
                        return "JUN";

                    }
                case 7:
                    {
                        return "JUL";

                    }
                case 8:
                    {
                        return "AUG";

                    }
                case 9:
                    {
                        return "SEP";

                    }
                case 10:
                    {
                        return "OCT";

                    }
                case 11:
                    {
                        return "NOV";

                    }
                case 12:
                    {
                        return "DEC";

                    }
                default: return "OTH";

            }
        }

        private void cboRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            chtRevenue.Visible = false;
            DataSet ds = Rentals.RevenueAnalysis(cboRevenue.Text.Substring(2,2));

            if (ds.Tables["RT"].Rows.Count == 0)
            {
                MessageBox.Show("No rental data for this year");
                return;
            }
            string[] Months = new string[12];
            decimal[] Revenue = new decimal[12];
            
            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(Convert.ToInt32(i + 1)); //save each month name in the array
                Revenue[i] = 0; //set revenue for every month to zero
            }

            //this loop updates the revenue for the months that DO have a value
       
            for (int i = 0; i < ds.Tables["RT"].Rows.Count; i++)
            {
                Revenue[Convert.ToInt32(ds.Tables["RT"].Rows[i][1]) - 1] = Convert.ToDecimal(ds.Tables["RT"].Rows[i][0]);
            }

            chtRevenue.Titles.Clear();
            chtRevenue.Titles.Add("Revenue " + cboRevenue.Text);
            chtRevenue.ChartAreas[0].AxisX.Interval = 1;
            chtRevenue.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtRevenue.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtRevenue.Series[0].LegendText = "Income in €";
            chtRevenue.Series[0].Points.DataBindXY(Months, Revenue);
            chtRevenue.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            chtRevenue.Series[0].Label = "#VALY";
            chtRevenue.Visible = true;
        }
    }
}