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
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        Signupc c = new Signupc();
        Signup od = new Signup();
        Parkerdetailsc odc = new Parkerdetailsc();
        DataTable dt = new DataTable();

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDashboard ol = new AdminDashboard();
            ol.Visible = true;
            this.Visible = false;
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            dt = od.Admintable(odc);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Rows.Count >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                row.ReadOnly = true;
                label11.Text = row.Cells["Userid"].Value.ToString();
                label10.Text = row.Cells["Username"].Value.ToString();
                label14.Text = row.Cells["Password"].Value.ToString();

                label12.Text = row.Cells["Email"].Value.ToString();
                label13.Text = row.Cells["Mobileno"].Value.ToString();

                label16.Text = row.Cells["Nid"].Value.ToString();





            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                c.username = label10.Text;
                c.Password = label14.Text;
                c.email = label12.Text;
                c.mobileno = label13.Text;
                c.Userid = label11.Text;
                c.nid = label16.Text;


                int i = od.CreateAcccountfromadmin(c);
                if (i > 0)
                {
                    MessageBox.Show("Account Created for this person");
                }
            }

            {
                c.Userid = label11.Text;
                int i = od.Deleteuser(c);
                if (i > 0)
                {
                  
                    dt = od.Admintable(odc);
                    dataGridView1.DataSource = dt;

                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Userid = label11.Text;
            int i = od.Deleteuser(c);
            if (i > 0)
            {
                MessageBox.Show("Deleted");
                dt = od.Admintable(odc);
                dataGridView1.DataSource = dt;

            }
        }
    }
}
