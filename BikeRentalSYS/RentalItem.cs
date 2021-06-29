using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalSYS
{
    class RentalItem
    {
        private int rentalId;
        private int bikeId;
        private decimal costPerDay;
      

        public RentalItem(int rentalId, int bikeId, decimal costPerDay)
        {
            this.rentalId = rentalId;
            this.bikeId = bikeId;
            this.costPerDay = costPerDay;
        }

        public RentalItem()
        {
            costPerDay = 0;
            
        }

        public int getRentalId()
        {
            return rentalId;
        }

        public void setRentalId(int rentalId)
        {
            this.rentalId = rentalId;
        }

        public int getId()
        {
            return bikeId;
        }

        public void setId(int bikeId)
        {
            this.bikeId = bikeId;
        }

        public decimal getCostPerDay()
        {
            return costPerDay;
        }

        public void setCostPerDay(int costPerDay)
        {
            this.costPerDay =  costPerDay;
        }

        public void addRentalItems()
        {
            //define Sql query
            String strSQL = "Insert INTO RentalItems VALUES(" + this.rentalId + "," + this.bikeId + "," + this.costPerDay + ")";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare Oracle Command to excute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void CollectRental(int rentalId)
        {
            String strSQL = "update (select status " +
                                   " from bikes b " +
                                   " INNER " +
                                   " JOIN rentalItems ri ON b.bikeid = ri.bikeid " +
                                   " WHERE ri.rentalid = " + rentalId + ") b " +
                           " set b.status = 'R'";
            
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //Declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }
    }
}
