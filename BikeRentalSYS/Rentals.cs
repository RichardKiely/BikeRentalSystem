using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentalSYS
{
    class Rentals
    {
        private int rentalId;
        private DateTime dateFrom;
        private DateTime dateTo;
        private String name;
        private DateTime dob;
        private String email;
        private String phoneNum;
        private decimal totalCost;

        public Rentals()
        {
            
            rentalId = 0;
            dateFrom = default;
            dateTo = default;
            name = "";
            dob = default;
            email = "";
            phoneNum = "";
            totalCost = 0;

        }

        public Rentals(int rentalId, DateTime dateFrom, DateTime dateTo, string name, DateTime dob, string email, string phoneNum, decimal totalCost)
        {
            this.rentalId = rentalId;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.name = name;
            this.dob = dob;
            this.email = email;
            this.phoneNum = phoneNum;
            this.totalCost = totalCost;
        }
        public int getRentalId()
        {
            return rentalId;
        }

        public void setRentalId(int rentalId)
        {
            this.rentalId = rentalId;
        }

        public DateTime getDateFrom()
        {
            return dateFrom;
        }

        public void setDateFrom(DateTime dateFrom)
        {
            this.dateFrom = dateFrom;
        }

        public DateTime getDateTo()
        {
            return dateTo;
        }

        public void setDateTo(DateTime dateTo)
        {
            this.dateTo = dateTo;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public DateTime getDob()
        {
            return dob;
        }

        public void setDob(DateTime dob)
        {
            this.dob = dob;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getPhoneNum()
        {
            return phoneNum;
        }

        public void setPhoneNum(String phoneNum)
        {
            this.phoneNum = phoneNum;
        }

        public decimal getTotalCost()
        {
            return totalCost;
        }

        public void setTotalCost(decimal totalCost)
        {
            this.totalCost = totalCost;
        }
  
       

        public static int getNextRentalId()
        {
            int nextId = 0;

            //define SQL Query
            String strSQL = "SELECT MAX(RentalID) FROM Rentals";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare Oracle Command to excute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //excute the command using an Oracle datareader

            OracleDataReader dr = cmd.ExecuteReader();

            //An aggrate function Always returns one record
            //which contains the largest RentalID in the table or null

            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;

                conn.Close();
            }
            return nextId;

        }

        public void addRental()  
        {
            //define Sql query
            String strSQL = "Insert INTO Rentals VALUES(" + this.rentalId + ",'" + String.Format("{0:dd-MMM-yy}",this.dateFrom) + "','" +
                String.Format("{0:dd-MMM-yy}", this.dateTo) + "','" + this.name + "','" + String.Format("{0:dd-MMM-yy}",this.dob) + "','" + this.email + "','" + this.phoneNum +"'," + this.totalCost + ")";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare Oracle Command to excute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static void getAvailableBikes(ListBox lstBikes, String bikeType, String dateFrom, String dateTo)
        {

            String strSQL = " Select b.bikeid, bt.typecode,b.manufacturer,bt.description,bt.rate " +
            " FROM Bikes b JOIN BikeTypes bt ON b.typecode = bt.typecode " +
            " WHERE b.typecode = '" + bikeType + "' AND " +
                "   b.bikeid NOT IN(SELECT ri.bikeid " +
                                   " FROM rentalitems ri join Rentals r ON r.rentalid = ri.rentalid " +
                                   " WHERE(r.datefrom >= '" + dateFrom + "' AND r.dateTo <= '" + dateTo + "') OR " +
                                       "  (r.datefrom <= '" + dateFrom + "' AND r.dateTo <= '" + dateTo + "') OR " +
                                        " ((r.datefrom <= '" + dateFrom + "') AND (r.dateTo BETWEEN '" + dateFrom + "' AND '" + dateTo + "')) OR " +
                                       "  ((r.datefrom BETWEEN '" + dateFrom + "' AND '" + dateTo + "') AND(r.dateTo >= '" + dateTo + "'))) " +
           " ORDER BY b.bikeid ";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object
            lstBikes.Items.Clear();

            while (dr.Read())
            {
                lstBikes.Items.Add(dr.GetInt16(0).ToString("000") + " " + dr.GetString(1) + " " + "€" + dr.GetDouble(4).ToString("000.00") + " " + dr.GetString(2).PadRight(20, ' '));
            }

            conn.Close();


        }

        public void CancelRental()
        {
            String strSQL = "DELETE FROM Rentals WHERE RentalID = '" + this.rentalId + "'";
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //Declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void ReturnRental()
        {
            String strSQL = "Update Bikes Set status = 'A'";
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //Declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public static DataSet getRentalIDs()
        {
            //define SQL Query
            String strSQL = "SELECT RENTALID FROM Rentals ORDER BY RENTALID";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "WS");

            //Close database connection
            conn.Close();

            return ds;

        }


        public static DataSet getRentalIDsForCollect()
        {
            //define SQL Query
            String strSQL = "SELECT r.RENTALID " +
                                  "  FROM Rentals r " +
                                  "  Left JOIN RentalItems rt ON rt.rentalid = r.rentalid " +
                                  "  LEFT JOIN Bikes b ON rt.bikeid = b.bikeid " +
                                  "  WHERE r.rentalID = r.rentalid AND b.status = 'A' " +
                           " ORDER BY r.RENTALID";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "RC");

            //Close database connection
            conn.Close();

            return ds;

        }

        public static DataSet getRentalIDsForReturn()
        {
            //define SQL Query
            String strSQL = "SELECT r.RENTALID " +
                                  "  FROM Rentals r " +
                                  "  Left JOIN RentalItems rt ON rt.rentalid = r.rentalid " +
                                  "  LEFT JOIN Bikes b ON rt.bikeid = b.bikeid " +
                                  "  WHERE r.rentalID = r.rentalid AND b.status = 'R' " +
                           " ORDER BY r.RENTALID";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "RR");

            //Close database connection
            conn.Close();

            return ds;

        }


        public void getRentals(int rentalId)
        {

            //define Sql query
            String strSQL = "SELECT r.rentalID, r.datefrom, r.name, r.dob, r.email, r.phonenumber, rt.bikeid " +
                            " FROM Rentals r " +
                            " Left join rentalitems rt ON rt.rentalId = r.rentalId " +
                            " WHERE r.rentalID = " + rentalId + "";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object
            dr.Read();

           this.rentalId = dr.GetInt32(0);
            this.dateFrom = dr.GetDateTime(1);
            this.name = dr.GetString(2);
           this.dob = dr.GetDateTime(3);
           this.email = dr.GetString(4);
           this.phoneNum = dr.GetString(5);

            //close database connection
            conn.Close();

        }
        
        public static DataSet RevenueAnalysis(String year)
        {
          
            String strSQL = "SELECT SUM(TotalCost), to_Char(dateFrom,'MM') FROM Rentals " +
                    "WHERE dateFrom LIKE '%" + year + "'" +
                    " GROUP BY to_Char(dateFrom,'MM') " +
                    " ORDER BY to_char(dateFrom,'MM')";

            
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
           
            DataSet ds = new DataSet();

            da.Fill(ds, "RT");

          
            conn.Close();

            return ds;

        }
        public static DataSet YearlyRentals(String year)
        {

            String strSQL = " SELECT bt.typecode,SUM(COSTPERDAY)  " +
                            " FROM biketypes bt JOIN BIKES B ON bt.typecode = b.typecode " +
                                              " LEFT JOIN rentalitems RI ON ri.bikeid = b.bikeid " +
                                              " JOIN rentals R ON r.rentalid = ri.rentalid " +
                               " WHERE R.DateFrom LIKE '%" + year + "' " +
                               " GROUP BY Bt.TypeCode " +
                               " ORDER BY BT.TypeCode";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "TC");


            conn.Close();

            return ds;
        }
    }
}
