using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarParkingManagementSystem.Views;

namespace CarParkingManagementSystem
{
    public partial class OwnweDashBoard : Form
    {
        public OwnweDashBoard(String uid)
        {
            InitializeComponent();
            label1.Text = uid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OwnweDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OwnerLogin ol = new OwnerLogin();
            ol.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CurrentStatus c = new CurrentStatus(label1.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerProfile c = new OwnerProfile(label1.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateSpace i = new UpdateSpace(label1.Text);
            this.Visible = false;
            i.Visible = true;
        }
    }
}
