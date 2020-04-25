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
   public class Chatbox
    {



        SqlConnection con;
        public Chatbox()
        {
            con = new SqlConnection(@"Data Source=desktop-mv1lceo\sqlaysh;Initial Catalog=Parkit;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }
        public int Report(Chatboxc c)
        {
            int i = 0;
            string query = "INSERT INTO Chatbox([From],Name,Subject,[To],Message,[Date&Time]) VALUES ('"+c.From +"','"+ c.Name +"','"+c.Subject+"','"+c.To+"','"+ c.Message+"','"+ DateTime.Now+"')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }



        public DataTable Allreport()
        {
            string query = string.Format("Select * from Chatbox");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }

        public int Repley(Chatboxc c)
        {
            int i = 0;
            string query = "INSERT INTO Reply([From],[To],Message,DT) VALUES ('" + c.From + "','" + c.To + "','" + c.Message + "','" + DateTime.Now + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            i = cmd.ExecuteNonQuery();

            return i;

        }


        public DataTable Singlechat(Chatboxc c)
        {
            string query = string.Format("SELECT * from dbo.Reply WHERE [From]='ADMIN' and [To]='" + c.To + "' or  [From]='" + c.To + "' and [To]='ADMIN' order by DT DESC");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            //con.Close();
            return dt;
        }

    }
}
