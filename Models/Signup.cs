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
    class Signup
    {
        SqlConnection con;
        public Signup()
        {
            con = new SqlConnection(@"Data Source=desktop-mv1lceo\sqlaysh;Initial Catalog=Parkit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        public int CreateAccountowner(Signupc u)
        {
            int i = 0;
            string query = "INSERT INTO Loginowner(Username,Password,Email,Mobileno,Address,Space,Block,Status) VALUES ('" + u.username + "','" + u.Password + "', '" + u.email + "', '" + u.mobileno + "','Block-" + u.address + " Road-" + u.road + " House-" + u.house + "','" + u.space + "','" + u.block + "','Active')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }


        public int CreateAccountparker(Signupc u)
        {
            int i = 0;
            string query = "INSERT INTO Admintable(Username,Password,Email,Mobileno,Nid) VALUES ('" + u.username + "','" + u.Password + "', '" + u.email + "', '" + u.mobileno + "','" + u.nid + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }

        public DataTable Admintable(Parkerdetailsc u)
        {
            string query = string.Format("Select * from Admintable");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }


        public int CreateAcccountfromadmin(Signupc u)
        {
            int i = 0;
            string query = "INSERT INTO Loginparker(Userid,Username,Password,Email,Mobileno,Nid) VALUES ('" + u.Userid + "','" + u.username + "','" + u.Password + "', '" + u.email + "', '" + u.mobileno + "','" + u.nid + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }

        public int Deleteuser(Signupc u)
        {
            int i = 0;
            string query = String.Format("Delete from Admintable where Userid='" + u.Userid + "'");
            SqlCommand cmd = new SqlCommand(query, con);
            i = cmd.ExecuteNonQuery();
            return i;
        }




    }
}
