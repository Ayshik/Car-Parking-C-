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
    public partial class Allusers : Form
    {
        public Allusers()
        {
            InitializeComponent();
        }
        Parkerdetails pd = new Parkerdetails();
        Parkerdetailsc pdc = new Parkerdetailsc();
        Ownerdetails od = new Ownerdetails();
        Ownerdetailsc odc = new Ownerdetailsc();
        DataTable dt = new DataTable();
        private void Allusers_Load(object sender, EventArgs e)
        {
           
            dt = pd.perkerdetails(pdc);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label2.Text = "Owner Details";
            dt = od.ownerdetails(odc);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = "Parker Details";
            dt = pd.perkerdetails(pdc);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard ol = new AdminDashboard();
            ol.Visible = true;
            this.Visible = false;
        }
    }
}
