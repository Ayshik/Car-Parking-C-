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
    public partial class ChatBox : Form
    {
        public ChatBox()
        {
            InitializeComponent();

        }

        Chatbox od = new Chatbox();
        Chatboxc odc = new Chatboxc();
        DataTable dt = new DataTable();




        private void button1_Click(object sender, EventArgs e)
        {
            if (label10.Text == "")
            {
                MessageBox.Show("please Select a User Report");
            }
            else
            {
                if (textBox1.Text != "")
                {
                    odc.From = "ADMIN";
                   
                    odc.Message = textBox1.Text;

                    odc.To =label10.Text;



                    int j = od.Repley(odc);
                    if (j > 0)
                    {
                        MessageBox.Show("Message Sent");

                        dt = od.Singlechat(odc);
                        dataGridView1.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Please write Message to send");
                }
            }
        }

        private void ChatBox_Load(object sender, EventArgs e)
        {
            dt = od.Allreport();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label10.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label8.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDashboard c = new AdminDashboard();
            this.Visible = false;
            c.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = od.Singlechat(odc);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = od.Allreport();
            dataGridView1.DataSource = dt;
            label8.Text = "All Users";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
