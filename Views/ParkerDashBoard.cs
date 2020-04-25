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
    public partial class ParkerDashBoard : Form
    {
        public ParkerDashBoard(string uid)
        {
            InitializeComponent();
            label1.Text = uid;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ParkerLogin ol = new ParkerLogin();
            ol.Visible = true;
            this.Visible = false;
        }

        private void ParkerDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parking ol = new Parking(label1.Text);
            ol.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerkerProfile ol = new PerkerProfile(label1.Text);
            ol.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Release ol = new Release(label1.Text);
            ol.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chatboxparker ol = new Chatboxparker(label1.Text);
            ol.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reportparker ol = new Reportparker(label1.Text);
            ol.Visible = true;
            this.Visible = false;
        }
    }
}
