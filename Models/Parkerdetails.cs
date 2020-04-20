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
    class Parkerdetails
    {
        SqlConnection con;
        public Parkerdetails()
        {
            con = new SqlConnection(@"Data Source=desktop-mv1lceo\sqlaysh;Initial Catalog=parkori;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }

        public DataTable perkerfetch(Parkerdetailsc u)
        {
            string query = string.Format("Select * from Loginparker where Userid='{0}'", u.Userid);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }


        public int parkerupdate(Parkerdetailsc u)
        {
            int i = 0;
            string query = String.Format("UPDATE Loginparker SET Password='" + u.Password + "',Mobileno='" + u.mobileno + "' WHERE Userid='" + u.Userid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }





    }
}
