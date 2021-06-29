using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BikeRentalSYS
{
    class BikeType
    {
        private String type;
        private String description;
        private Decimal rate;

        public BikeType()
        {
            type = "";
            description = "";
            rate = 0;
        }

        public BikeType(string type, string description, decimal rate)
        {

            setType(type);
            setDescription(description);
            setRate(rate);
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public Decimal getRate(decimal rate)
        {
            return rate;
        }

        public void setRate(decimal rate)
        {
            if (rate > 0)
            {
                this.rate = rate;
            }
            else
                MessageBox.Show("Rate must be greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void addBikeTypes()
        {
            //define Sql query
            String strSQL = "Insert INTO BIKETYPES values('" + this.type + "','" + this.description + "'," + this.rate + ")";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare Oracle Command to excute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

    }
}
