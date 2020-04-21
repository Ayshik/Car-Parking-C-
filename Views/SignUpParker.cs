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

namespace CarParkingManagementSystem
{
    public partial class SignUpParker : Form
    {
        public SignUpParker()
        {
            InitializeComponent();
            label5.Visible = false;
            label6.Visible = false;
        }
        Signup s = new Signup();
        Signupc u = new Signupc();
        DataTable dt = new DataTable();
        private void SignUpParker_Load(object sender, EventArgs e)
        {

        }

        private void parkersignupback_Click(object sender, EventArgs e)
        {
            ParkerLogin c = new ParkerLogin();
            this.Visible = false;
            c.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "" || textBoxPass.Text == "" || textBoxEmail.Text == "" || textBoxMobile.Text == "" || textBoxNid.Text == "")
            {
                MessageBox.Show("please fill all of your information");
            }
            else
            {
                u.username = textBoxUname.Text;
                u.Password = textBoxPass.Text;
                u.email = textBoxEmail.Text;
                u.mobileno = textBoxMobile.Text;

                u.nid = textBoxNid.Text;


                int i = s.CreateAccountparker(u);
                if (i > 0)
                {
                    MessageBox.Show("your Account is processing try to login after an hour");
                    label5.Visible = true;
                    label6.Visible = true;
                }
                else
                {
                    MessageBox.Show("opss server is Busy");
                }
            }

            u.nid = textBoxNid.Text;
           
            dt = s.Parkerfetchid(u);

            if (dt.Rows.Count == 1)
            {


                label8.Text = dt.Rows[0][0].ToString();


            }




        }
    }
}
