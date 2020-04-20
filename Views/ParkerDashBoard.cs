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
    }
}
