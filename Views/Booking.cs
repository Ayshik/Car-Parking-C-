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
    public partial class Booking : Form
    {
        public Booking(string uid)
        {
            InitializeComponent();
            label10.Text = uid;
        }

        Ownerdetails od = new Ownerdetails();
        Ownerdetailsc odc = new Ownerdetailsc();
        DataTable dt = new DataTable();
        Booking0 s = new Booking0();
        Bookingc u = new Bookingc();

        private void Booking_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            odc.Userid = textBox1.Text;

            dt = od.ownerfetch(odc);




            if (dt.Rows.Count == 1)
            {

                label11.Text = dt.Rows[0][1].ToString();
                label12.Text = dt.Rows[0][6].ToString();
                label13.Text = dt.Rows[0][5].ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = (Convert.ToInt16(comboBox1.Text) * Convert.ToInt16(60)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("please select your time");
            }
            else
            {
                var minus = (Convert.ToInt16(label12.Text) - Convert.ToInt16(1)).ToString();



                u.ownerid = textBox1.Text;
                u.parkerid = label10.Text;
                u.freeslot = minus;
                u.estimatedtime = comboBox1.Text;
                u.estimatedcost = label6.Text;


                try
                {

                    int i = s.payment(u);
                    if (i > 0)
                    {
                        MessageBox.Show("Payment done.");
                        {
                            odc.space = minus;
                            odc.Userid = textBox1.Text;


                            int w = s.Updateowenplace(odc);
                            if (w > 0)
                            {
                                MessageBox.Show($"Dont forget to Reliese your car after {comboBox1.Text} Hour ");
                            }
                        }

                    }
                    else
                    {

                    }
                }
                catch { MessageBox.Show("Sorry ! please reliese your car first"); }
                //update er jonno space update


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parking p = new Parking(label10.Text);
            p.Visible = true;
            this.Visible = false;
        }
    }
}
