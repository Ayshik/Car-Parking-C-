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
    public partial class Release : Form
    {
        public Release(string uid)
        {
            InitializeComponent();
            label13.Text = uid;
        }
        Ownerdetails od = new Ownerdetails();
        Ownerdetailsc odc = new Ownerdetailsc();
        Booking0 s = new Booking0();

        Releaseparker rp = new Releaseparker();
        Releaseparkerc rpc = new Releaseparkerc();
        DataTable dt = new DataTable();
        private void Release_Load(object sender, EventArgs e)
        {
            rpc.parkerid = label13.Text;

            dt = rp.perkerdetais(rpc);


            if (dt.Rows.Count == 1)
            {

                label8.Text = dt.Rows[0][0].ToString();
                label9.Text = dt.Rows[0][1].ToString();
                label11.Text = dt.Rows[0][2].ToString();
                label7.Text = dt.Rows[0][3].ToString();
                label4.Text = dt.Rows[0][4].ToString();
                label6.Text = dt.Rows[0][5].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParkerDashBoard pd = new ParkerDashBoard(label13.Text);
            pd.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var plus = (Convert.ToInt16(label11.Text) + Convert.ToInt16(1)).ToString();




            {
                rpc.parkerid = label13.Text;
                int i = rp.parkerrelease(rpc);
                if (i > 0)
                {

                    odc.space = plus;
                    odc.Userid = label8.Text;
                    int t = s.Updateowenplace(odc);
                    if (t > 0)
                    {
                        MessageBox.Show("Succesfully Released");
                    }
                }
                else
                {
                    MessageBox.Show("you have no car to release");
                }
            }
        }
    }
}
