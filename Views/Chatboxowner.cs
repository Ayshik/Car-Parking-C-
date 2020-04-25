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
    public partial class Chatboxowner : Form
    {
        public Chatboxowner(string uid)
        {
            InitializeComponent();
            label7.Text = uid;
        }
        Chatbox od = new Chatbox();
        Chatboxc odc = new Chatboxc();
        DataTable dt = new DataTable();

        private void Chatboxowner_Load(object sender, EventArgs e)
        {
           

            odc.Message = textBox1.Text;

            odc.To = label7.Text;
            {
                dt = od.Singlechat(odc);
                dataGridView1.DataSource = dt;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OwnweDashBoard c = new OwnweDashBoard(label7.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            odc.Message = textBox1.Text;

            odc.To = label7.Text;
            {
                dt = od.Singlechat(odc);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                odc.From = label7.Text;

                odc.Message = textBox1.Text;

                odc.To ="ADMIN" ;



                int j = od.Repley(odc);
                if (j > 0)
                {
                    MessageBox.Show("Message Sent");
                }
            }
            else
            {
                MessageBox.Show("Please write Message to send");
            }
        }
    }
}
