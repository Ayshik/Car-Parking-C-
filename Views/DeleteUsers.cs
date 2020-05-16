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
    public partial class DeleteUsers : Form
    {
        public DeleteUsers()
        {
            InitializeComponent();
        }
        Parkerdetails pd = new Parkerdetails();
        Parkerdetailsc pdc = new Parkerdetailsc();
        Ownerdetails od = new Ownerdetails();
        Ownerdetailsc odc = new Ownerdetailsc();
        DataTable dt = new DataTable();
        Signup s = new Signup();
        Signupc sc = new Signupc();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUsers_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Rows.Count >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                row.ReadOnly = true;
                label3.Text = row.Cells["Userid"].Value.ToString();






            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label3.Text == "User ID")
            {
                MessageBox.Show("Please select an user");

            }

            else
            {
                sc.Userid = label3.Text;
                int i = s.Deleteowner(sc);
                if (i > 0)
                {
                    MessageBox.Show("Deleted");
                    dt = od.ownerdetails(odc);
                    dataGridView1.DataSource = dt;

                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label3.Text == "User ID")
            {
                MessageBox.Show("Please select an user");

            }

            else
            {
                sc.Userid = label3.Text;
                int i = s.Deleteparker(sc);
                if (i > 0)
                {
                    MessageBox.Show("Deleted");
                    dt = pd.perkerdetails(pdc);
                    dataGridView1.DataSource = dt;

                }

            }
        }
    }
}