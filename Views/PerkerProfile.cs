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
    public partial class PerkerProfile : Form
    {
        public PerkerProfile(string uid)
        {
            InitializeComponent();
            label1.Text = uid;
        }
        Parkerdetails od = new Parkerdetails();
        Parkerdetailsc odc = new Parkerdetailsc();
        DataTable dt = new DataTable();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PerkerProfile_Load(object sender, EventArgs e)
        {
            odc.Userid = label1.Text;

            dt = od.perkerfetch(odc);

            if (dt.Rows.Count == 1)
            {

                textBox1.Text = dt.Rows[0][1].ToString();
                textBox7.Text = dt.Rows[0][2].ToString();
                textBox2.Text = dt.Rows[0][3].ToString();
                textBox4.Text = dt.Rows[0][4].ToString();
                textBox3.Text = dt.Rows[0][5].ToString();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != textBox7.Text)//jodi password field khali thake ar ager pass er sathe jodi input pass na mele to..
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


                    int w = od.parkerupdate(odc);
                    if (w > 0)
                    {
                        MessageBox.Show("Password Changed");
                        PerkerProfile ow = new PerkerProfile(label1.Text);
                        ow.Visible = true;
                        this.Visible = false;

                    }
                }
                else { MessageBox.Show("Confirm Password didnot match"); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != textBox7.Text)
            {
                MessageBox.Show("please Check your Password");
            }
            else
            {
                if (textBox4.Text != "")
                {
                    odc.Userid = label1.Text;
                    odc.mobileno = textBox4.Text;
                    odc.Password = textBox7.Text;


                    int w = od.parkerupdate(odc);
                    if (w > 0)
                    {
                        MessageBox.Show("Number Changed");
                    }
                }
                else { MessageBox.Show("Server busy try again"); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParkerDashBoard c = new ParkerDashBoard(label1.Text);
            this.Visible = false;
            c.Visible = true;
        }
    }
}
