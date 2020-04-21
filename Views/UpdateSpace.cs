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
    public partial class UpdateSpace : Form
    {
        public UpdateSpace(string uid)
        {
            InitializeComponent();
            label10.Text = uid;
           
        }
        Ownerdetails od = new Ownerdetails();
        Ownerdetailsc odc = new Ownerdetailsc();
        DataTable dt = new DataTable();
        private void UpdateSpace_Load(object sender, EventArgs e)
        {
            odc.Userid = label10.Text;
            dt = od.ownerfetch(odc);

            if (dt.Rows.Count == 1)
            {

                label2.Text = dt.Rows[0][6].ToString();
                label6.Text = dt.Rows[0][8].ToString();

            }
            if (label6.Text == "Active")
            {
                label6.BackColor = Color.Green;
            }
            else { label6.BackColor = Color.Red; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Active")
            {
                MessageBox.Show("You Are Allready Active ");
            }
            else
            {
                odc.Userid = label10.Text;


                int w = od.owneractive(odc);
                if (w > 0)
                {
                    MessageBox.Show("Thanks for coming back");

                    dt = od.ownerfetch(odc);

                    if (dt.Rows.Count == 1)
                    {

                        label2.Text = dt.Rows[0][6].ToString();
                        label6.Text = dt.Rows[0][8].ToString();

                    }

                    label6.BackColor = Color.Green;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Inactive")
            {
                MessageBox.Show("You Are Allready Inactive ");
            }
            else
            {
                odc.Userid = label10.Text;


                int w = od.ownerinactive(odc);
                if (w > 0)
                {
                    MessageBox.Show("Thanks for your service");

                    dt = od.ownerfetch(odc);

                    if (dt.Rows.Count == 1)
                    {

                        label2.Text = dt.Rows[0][6].ToString();
                        label6.Text = dt.Rows[0][8].ToString();

                    }

                    label6.BackColor = Color.Red;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OwnweDashBoard c = new OwnweDashBoard(label10.Text);
            this.Visible = false;
            c.Visible = true;
        }
    }
}
