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
    public partial class ParkerLogin : Form
    {
        public ParkerLogin()
        {
            InitializeComponent();
        }
        Login l = new Login();
        Loginc lc = new Loginc();
        DataTable dt = new DataTable();
        Boolean state = false;
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
                        dt = l.Loginparker(lc);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            ParkerDashBoard c = new ParkerDashBoard(parkerUname.Text);
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
