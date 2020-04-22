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
    public partial class OwnerProfile : Form
    {
        public OwnerProfile(string uid)
        {
            InitializeComponent();
            label1.Text = uid;
        }
        Ownerdetails od = new Ownerdetails();
        Ownerdetailsc odc = new Ownerdetailsc();
        DataTable dt = new DataTable();
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OwnerProfile_Load(object sender, EventArgs e)
        {
            odc.Userid = label1.Text;

            dt = od.ownerfetch(odc);




            if (dt.Rows.Count == 1)
            {

                textBox1.Text = dt.Rows[0][1].ToString();
                textBox7.Text = dt.Rows[0][2].ToString();
                textBox2.Text = dt.Rows[0][3].ToString();
                textBox4.Text = dt.Rows[0][4].ToString();
                textBox5.Text = dt.Rows[0][5].ToString();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           OwnweDashBoard c = new OwnweDashBoard(label1.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != textBox7.Text)
            {
                MessageBox.Show("please Check your Password ");
            }
            else
            {
                if (textBox4.Text !="")
                {
                    odc.Userid = label1.Text;
                    odc.mobileno = textBox4.Text;
                    odc.Password = textBox7.Text;


                    int w = od.ownerupdate(odc);
                    if (w > 0)
                    {
                        MessageBox.Show("Number Changed");
                    }
                }
                else { MessageBox.Show("Server busy try again"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox11.Text != textBox7.Text)//jodi password field khali thake ar ager pass er sathe jodi input pass na mele to..
            {
                MessageBox.Show("please Check your Password");
            }
            else
            {
                if (textBox10.Text == textBox9.Text)
                {
                    odc.Userid = label1.Text;
                    odc.mobileno = textBox4.Text;
                    odc.Password = textBox10.Text;


                    int w = od.ownerupdate(odc);
                    if (w > 0)
                    {
                        MessageBox.Show("Password Changed");
                        OwnerProfile ow = new OwnerProfile(label1.Text);
                        ow.Visible = true;
                        this.Visible = false;

                    }
                }
                else { MessageBox.Show("Confirm Password didnot match"); }
            }
        }
    }
}
