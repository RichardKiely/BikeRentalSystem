using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BikeRentalSYS
{
    class Utility
    {
        public static void getTypes(ComboBox cboName)
        {
            cboName.Items.Clear();

            //define Sql query
            String strSQL = "SELECT * FROM BikeTypes ORDER BY Description";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0) + " " + dr.GetString(1));
            }

            conn.Close();


        }
        public static void loadYears(ComboBox cboTime)
        {
            int year = DateTime.Now.Year;

            for (int i = 1; i <= 3; i++)
            {
                cboTime.Items.Add(year.ToString());
                year -= 1;
            }

        }
        public static void sendEmail(string emailAddress, string message, int id)
        {

            try
            {

                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("your email", "your password");
                MailMessage mail = new MailMessage();
                mail.To.Add(emailAddress);
                mail.From = new MailAddress("your email");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";
                client.Send(mail);
                MessageBox.Show("Email Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //I Got to code for emailing from here https://blog.elmah.io/how-to-send-emails-from-csharp-net-the-definitive-tutorial/
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("your email", "your password"),
                    EnableSsl = true,
                };

                smtpClient.Send("your email", emailAddress, message,
               "Thank you for chosing to bike rental service with us\n" +
               "Your Details are as follows:\n\n" +
               "Rental ID: " + id +
               "\n\nRegards" +
               "\nBike Rental Management");
            }
            catch
            {
                DialogResult userchoice = MessageBox.Show("Unable to connect to the network Please check your internet connection and try again. Would you like to continue without sending an email?", "No Internet Connection!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (userchoice == DialogResult.No)
                {
                    return;
                }
            }

        }     

    }

}
    
