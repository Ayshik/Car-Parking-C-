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
    public partial class Reportparker : Form
    {
        public Reportparker(string uid)
        {
            InitializeComponent();
            label1.Text = uid;
        }

        Chatbox s = new Chatbox();
        Chatboxc u = new Chatboxc();
        DataTable dt = new DataTable();

        private void Reportparker_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParkerDashBoard c = new ParkerDashBoard(label1.Text);
            this.Visible = false;
            c.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("please fill the the information");
            }
            else
            {
                u.From = label1.Text;
                u.Name = textBox1.Text;
                u.Subject = textBox2.Text;
                u.Message = textBox3.Text;

                u.To = "ADMIN";


                int i = s.Report(u);
                int j = s.Repley(u);
                if (j > 0)
                {
                    MessageBox.Show("Report Sent");
                }
                else
                {
                    MessageBox.Show("opss server is Busy");
                }
            }
        }
    }
}
