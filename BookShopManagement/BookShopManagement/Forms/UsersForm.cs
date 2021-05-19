using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
        public MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='bookshop';username=root;password=root;CharSet=utf8;");

        public MySqlCommand command = new MySqlCommand();
        public MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();

        dbConnect dbCon1 = new dbConnect();

        public DataTable filldata()
        {
            conn.Open();
            DataTable dt = new DataTable();
            command = new MySqlCommand("SELECT * FROM users", conn);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
       

        private void btnSaleBook_Click(object sender, EventArgs e)
        {

        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {


            dgvSale.DataSource = filldata();
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            DataTable tbl = new DataTable();
            string loadd = "SELECT * FROM users WHERE name like '%" + txtSearch1.Text + "%' OR surname like '%" + txtSearch1.Text + "%' OR login  like '%" + txtSearch1.Text + "%' "; 
            command = new MySqlCommand(loadd, conn);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(tbl);
            conn.Close();
            dgvSale.DataSource = tbl;
        }
    }
}
