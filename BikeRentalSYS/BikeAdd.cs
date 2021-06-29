using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalSYS
{
    class BikeAdd
    {
        private int id;
        private String type;
        private String manufacturer;
        private int gears;
        private int wheelSize;
        private String status;

        public BikeAdd()
        {
            id = 0;
            type = "";
            manufacturer = "";
            gears = 0;
            wheelSize = 0;
            status = "";
        }

        public BikeAdd(int id, string type, string manufacturer, int gears, int wheelSize, string status)
        {
            this.id = id;
            this.type = type;
            this.manufacturer = manufacturer;
            this.gears = gears;
            this.wheelSize = wheelSize;
            this.status = status;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public String getManufacturer()
        {
            return manufacturer;
        }

        public void setManufacturer(String manufacturer)
        {
            this.manufacturer = manufacturer;
        }
        public int getGears()
        {
            return gears;
        }

        public void setGears(int gears)
        {
            this.gears = gears;
        }
        public int getWheelSize()
        {
            return wheelSize;
        }

        public void setWheelSize(int wheelSize)
        {
            this.wheelSize = wheelSize;
        }

        public String getStatus()
        {
            return status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public static int getNextId()
        {
            int nextId = 0;
            
                //define SQL Query
                String strSQL = "SELECT MAX(BIKEID) FROM BIKES";

                //Declare an Oracle Connection
                OracleConnection conn = new OracleConnection(DBConnect.oraDB);
                conn.Open();

                //declare Oracle Command to excute
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //excute the command using an Oracle datareader

                OracleDataReader dr = cmd.ExecuteReader();

            //An aggrate function Always returns one record
            //which contains the largest ID in the table or null

            dr.Read();

            if(dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;

                conn.Close();
            }
                return nextId;
            
        }
        public void addBike()
        {
            //define Sql query
            String strSQL = "Insert INTO Bikes VALUES(" + this.id + ",'" + this.type + "','" +
                this.manufacturer + "'," + this.gears + "," + this.wheelSize + ",'" + this.status + "')";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare Oracle Command to excute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static DataSet getSummaryBikeID()
        {
            //define SQL Query
            String strSQL = "SELECT BikeID, TypeCode FROM Bikes WHERE Status = 'A' ORDER BY BikeID";

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

        public void updateBike()
        {

            //define Sql query
            String strSQL = "Update Bikes SET BIKEID =" + this.id + ", TYPECODE ='" + this.type + 
                "',MANUFACTURER ='" + this.manufacturer + "', GEARS =" + this.gears + ",WHEELSIZE =" + 
                this.wheelSize +",STATUS ='" + this.status + "' WHERE BIKEID = '" + this.id + "'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare Oracle Command to excute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void removeBike()
        {
            String strSQL = "Update Bikes SET Status = 'O' WHERE BIKEID = " + this.id + "";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //Declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void getBikes(int id)
        {
            //define Sql query
            String strSQL = "SELECT * FROM Bikes WHERE BIKEID = " + id + "";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();



            //declare an Oracle Command execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);


            OracleDataReader dr = cmd.ExecuteReader();


            //read the record returned in dr and use values to instantiate the object
            dr.Read();


            if (dr.HasRows)
            {

                this.id = dr.GetInt32(0);
                type = dr.GetString(1);
                manufacturer = dr.GetString(2);
                gears = dr.GetInt32(3);
                wheelSize = dr.GetInt32(4);
                status = dr.GetString(5);
            }


            //close database connection
            conn.Close();
        }
    }

}
