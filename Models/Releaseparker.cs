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
    class Releaseparker
    {
        SqlConnection con;
        public Releaseparker()
        {
            con = new SqlConnection(@"Data Source=desktop-mv1lceo\sqlaysh;Initial Catalog=Parkit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }

        public DataTable perkerdetais(Releaseparkerc u)
        {
            string query = string.Format("Select * from Booking where Parkerid='{0}'", u.parkerid);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            return dt;
        }

        public int parkerrelease(Releaseparkerc u)
        {
            int i = 0;
            string query = String.Format("Delete from Booking where Parkerid='" + u.parkerid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }


    }
}
