using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.Models;
using CarParkingManagementSystem.Controller;
using CarParkingManagementSystem.Views;

namespace CarParkingManagementSystem.Views
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        Login l = new Login();
        Loginc lc = new Loginc();
        DataTable dt = new DataTable();
        Boolean state = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (parkerUname.Text == "" || parkerPass.Text == "")
            {
                MessageBox.Show("Please write your user id and password");
            }
            else
            {
                lc.Userid = parkerUname.Text;
                lc.Password = parkerPass.Text;



                {
                    if (state == false)
                    {
                        dt = l.Loginadmin(lc);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            AdminDashboard c = new AdminDashboard();
                            this.Visible = false;
                            c.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }


                    if (state == false)
                    {
                        MessageBox.Show("Invalid userid or password");
                    }
                }





            }
        }
    }
}
