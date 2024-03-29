﻿using System;
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
    public partial class Parking : Form
    {
        public Parking(string uid)
        {
            InitializeComponent();
            label10.Text = uid;
        }
        Ownerdetails od = new Ownerdetails();
        Ownerdetailsc odc = new Ownerdetailsc();
        DataTable dt = new DataTable();

        private void Parking_Load(object sender, EventArgs e)
        {
            dt = od.Ownerdetailsall(odc);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParkerDashBoard pd = new ParkerDashBoard(label10.Text);
            pd.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odc.block = comboBox2.Text;

            dt = od.Ownersearch(odc);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Booking b = new Booking(label10.Text);
            b.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = od.Ownerdetailsall(odc);
            dataGridView1.DataSource = dt;
        }
    }
}
