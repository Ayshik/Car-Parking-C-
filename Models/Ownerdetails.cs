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
    class Ownerdetails
    {

        SqlConnection con;
        public Ownerdetails()
        {
            con = new SqlConnection(@"Data Source=desktop-mv1lceo\sqlaysh;Initial Catalog=Parkit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public DataTable Ownerdetailsall(Ownerdetailsc u)
        {
            string query = string.Format("Select * from Loginowner where Status='Active'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable Ownersearch(Ownerdetailsc u)
        {
            string query = string.Format("Select * from Loginowner where [Block]='{0}'", u.block);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            // con.Close();
            return dt;
        }

        public DataTable ownerfetch(Ownerdetailsc u)
        {
            string query = string.Format("Select * from Loginowner where Userid='{0}'", u.Userid);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }

        public int owneractive(Ownerdetailsc u)
        {
            int i = 0;
            string query = String.Format("UPDATE Loginowner SET Status='Active' where Userid='{0}'", u.Userid);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }

        public int ownerinactive(Ownerdetailsc u)
        {
            int i = 0;
            string query = String.Format("UPDATE Loginowner SET Status='Inactive' where Userid='{0}'", u.Userid);
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}

