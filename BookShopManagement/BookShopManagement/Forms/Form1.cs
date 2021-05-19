using BookShopManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace BookShopManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection(@"");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int count = 0, count2 = 4;

        private void button1_Click(object sender, EventArgs e)
        {
            dbConnect dbCon = new dbConnect();

            string log = textBox2.Text;
            string pass = textBox1.Text;
            if (count <= 3)
            {

                if (dbCon.ReadData($"SELECT * FROM users WHERE login='{log}' AND password ='{pass}'") == 1)
                {
                    using (Forms.Form_Dashboard fd = new Form_Dashboard())
                    {
                        fd.ShowDialog();
                    }
                }
                else
                {
                    count2--;
                    label4.Text = $"Incorrect username or password. {count2} - attempts left";
                    count++;
                }
            }
            else
            {
                label4.Text = "No attempts!";
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
