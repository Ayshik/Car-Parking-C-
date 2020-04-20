using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarParkingManagementSystem.Controller;
using System.Data;
using System.Data.SqlClient;



namespace CarParkingManagementSystem.Models
{
    public class Booking0
    {
        SqlConnection con;
        public Booking0()
        {
            con = new SqlConnection(@"Data Source=desktop-mv1lceo\sqlaysh;Initial Catalog=parkori;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }
        public int payment(Bookingc u)
        {
            int i = 0;
            string query = "INSERT INTO Booking(Ownerid,Parkerid,Freeslot,Datetime,Estimatedtime,Estimatedcost,Status) VALUES ('" + u.ownerid + "','" + u.parkerid + "', '" + u.freeslot + "', '" + DateTime.Now + "','" + u.estimatedtime + "','" + u.estimatedcost + "','Active')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }

        public int Updateowenplace(Ownerdetailsc u)
        {
            int i = 0;
            string query = String.Format("UPDATE Loginowner SET Space='" + u.space + "' WHERE Userid='" + u.Userid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }



















    }
}
