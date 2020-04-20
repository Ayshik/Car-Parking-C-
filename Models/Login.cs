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
    class Login
    {

        SqlConnection con;
        public Login()
        {
            con = new SqlConnection(@"Data Source=desktop-mv1lceo\sqlaysh;Initial Catalog=Parkit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public DataTable Loginowner(Loginc l)
        {

            string query = string.Format("Select * from Loginowner where UserId= '" + l.Userid + "' and Password='" + l.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }

        public DataTable Loginparker(Loginc l)
        {

            string query = string.Format("Select * from Loginparker where UserId= '" + l.Userid + "' and Password='" + l.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }


        public DataTable Loginadmin(Loginc l)
        {

            string query = string.Format("Select * from Admin where Id= '" + l.Userid + "' and Password='" + l.Password + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;

        }


    }
}
