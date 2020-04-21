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
    public partial class CurrentStatus : Form
    {
        public CurrentStatus(string uid)
        {
            InitializeComponent();
            label10.Text = uid;
        }
        Currentstatus od = new Currentstatus();
        Currentstatusc odc = new Currentstatusc();
        DataTable dt = new DataTable();
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnweDashBoard c = new OwnweDashBoard(label10.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void CurrentStatus_Load(object sender, EventArgs e)
        {
            odc.ownerid = label10.Text;
            dt = od.ownerfetchStatus(odc);
            dataGridView1.DataSource = dt;
        }
    }
}
