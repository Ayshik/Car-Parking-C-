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
    class Currentstatus
    {

        SqlConnection con;
        public Currentstatus()
        {
            con = new SqlConnection(@"Data Source=desktop-mv1lceo\sqlaysh;Initial Catalog=parkori;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }





        public DataTable ownerfetchStatus(Currentstatusc u)
        {
            string query = string.Format("Select * from Booking where Ownerid='{0}' and Status='Active'", u.ownerid);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }


    }
}
