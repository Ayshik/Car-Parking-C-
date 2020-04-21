using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.Views;
using CarParkingManagementSystem.Models;
using CarParkingManagementSystem.Controller;

namespace CarParkingManagementSystem
{
    public partial class SignUpOwner : Form
    {
        public SignUpOwner()
        {
            InitializeComponent();
        }
        Signup s = new Signup();
        Signupc u = new Signupc();
        DataTable dt = new DataTable();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ownersignupback_Click(object sender, EventArgs e)
        {
            OwnerLogin c = new OwnerLogin();
            this.Visible = false;
            c.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "" || textBoxPass.Text == "" || textBoxEmail.Text == "" || textBoxMobile.Text == "" || comboBoxBlock.Text == "" || comboBoxRoad.Text == "" || textBoxHouse.Text == "")
            {
                MessageBox.Show("Value cannot be empty,image and signature cannot be empty,may be name or email address is not in valid format");
            }
            else
            {
                u.username = textBoxUname.Text;
                u.Password = textBoxPass.Text;
                u.email = textBoxEmail.Text;
                u.mobileno = textBoxMobile.Text;
                u.address = comboBoxBlock.Text;
                u.road = comboBoxRoad.Text;
                u.house = textBoxHouse.Text;
                u.space = numericUpDown1.Text;
                u.block = comboBoxBlock.Text;


                int i = s.CreateAccountowner(u);
                if (i > 0)
                {
                    MessageBox.Show("Account Created");
                }
                else
                {
                    MessageBox.Show("opss server is Busy");
                }
            }

            u.username = textBoxUname.Text;
            u.Password = textBoxPass.Text;
            u.email = textBoxEmail.Text;
            u.mobileno = textBoxMobile.Text;
            dt = s.ownerfetchid(u);

            if (dt.Rows.Count == 1)
            {

              
                label7.Text = dt.Rows[0][0].ToString();


            }






        }
    }
}
