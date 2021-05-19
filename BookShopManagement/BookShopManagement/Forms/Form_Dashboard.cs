using BookShopManagement.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class Form_Dashboard : Form
    {

        int PanelWidth;
        bool isCollapsed;
        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            //UC_Home uch = new UC_Home();
            //AddControlsToPanel(uch);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPur);
            label4.Text = "View Books"; 
            ViewBooksForm frm2 = new ViewBooksForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm2);
            frm2.Show();

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm frm = new AddBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();

        }
        private void butnEdit_Click(object sender, EventArgs e)
        {
            EditBookForm frm1 = new EditBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true  };
            showpnl(frm1);
            frm1.Show();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10; 
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if(panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);

        }

            private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            //UC_Home uch = new UC_Home();
            //AddControlsToPanel(uch);
            label4.Text = "Home";
            showpnl(pnlHome);
        }


        private void showpnl(Control pnl)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(pnl);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
                    
            moveSidePanel(btnSold);
            label4.Text = "Sold Books";
            SalesBookForm frm2 = new SalesBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm2);
            frm2.Show();

        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExp);
            label4.Text = "About Us";
            AboutUsForm frm2 = new AboutUsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm2);
            frm2.Show();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            label4.Text = "Users";
            UsersForm frm2 = new UsersForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm2);
            frm2.Show();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnView);
            label4.Text = "View sales";
            SalesBookForm frm = new SalesBookForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();


        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
            label4.Text = "Settings";
            RegisterForm frm = new RegisterForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            showpnl(frm);
            frm.Show();

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
           
        private void label8_Click(object sender, EventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlHome_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        dbConnect dbCon = new dbConnect();

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {
            /** int existBooks;
             existBooks = dbCon.Execat($"SELECT * FROM existbooks  WHERE IDBooks = ( SELECT MAX(IDBooks) FROM existbooks )");
             lblnumbook.Text = Convert.ToString(existBooks);**/
           // строка подключения к БД
            string connStr = "server=localhost;user=root;database=bookshop;password=root;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            
            // устанавливаем соединение с БД
            conn.Open();
            //conn2.Open();
            // запрос
            string sql = "SELECT * FROM existbooks WHERE IDBooks = ( SELECT MAX(IDBooks) FROM existbooks )";
            string sql2 = "SELECT * FROM salesbooks WHERE IDBooks = ( SELECT MAX(IDBooks) FROM salesbooks )";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlCommand command2 = new MySqlCommand(sql2, conn);
            // выполняем запрос и получаем ответ
            string existBooks = command.ExecuteScalar().ToString();
            string salesBooks = command2.ExecuteScalar().ToString();
            // выводим ответ в консоль
            lblnumbook.Text = Convert.ToString(existBooks);
            lblnumSalesBook.Text = Convert.ToString(salesBooks);
            // закрываем соединение с БД
            conn.Close();

        }
    }
}
