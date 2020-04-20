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


namespace CarParkingManagementSystem.Views
{
    public partial class OwnerLogin : Form
    {
        public OwnerLogin()
        {
            InitializeComponent();
        }
        Login l = new Login();
        Loginc lc = new Loginc();
        DataTable dt = new DataTable();
        Boolean state = false;
        private void OwnerLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ownerUname.Text == "" || ownerPass.Text == "")
            {
                MessageBox.Show("Please write your user id and password");
            }
            else
            {
                lc.Userid = ownerUname.Text;
                lc.Password = ownerPass.Text;



                {
                    if (state == false)
                    {
                        dt = l.Loginowner(lc);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            OwnweDashBoard c = new OwnweDashBoard(ownerUname.Text);
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
