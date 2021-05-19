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
    public partial class ViewBooksForm : Form
    {
        public ViewBooksForm()
        {
            InitializeComponent();
        }
        public MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='bookshop';username=root;password=root;CharSet=utf8;");

        public MySqlCommand command = new MySqlCommand();
        public MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable dt = new DataTable();
        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        public DataTable filldata()
        {
            //conn.Open();
            DataTable dt = new DataTable();
            command = new MySqlCommand("SELECT * FROM existbooks", conn);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
            dgvView.DataSource = filldata();
        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }
        SalesBookForm frmSale = new SalesBookForm();
     
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

               
                DataTable tbl = new DataTable();
                string loadd = "SELECT * FROM existbooks WHERE Title like '%" + txtSearch.Text + "%' OR Author like '%" + txtSearch.Text + "%' OR Publisher  like '%" + txtSearch.Text + "%'OR YearPublish  like '%" + txtSearch.Text + "%'";
                command = new MySqlCommand(loadd, conn);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(tbl);
                conn.Close();
                dgvView.DataSource = tbl;
           // dgvView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            //conn.Open();
            // string loadd = "DELETE FROM existbooks WHERE IDBooks = '" + dgvView.CurrentRow.Cells[0].Value.ToString() + "';";
            //command = new MySqlCommand(loadd, conn);
            //command.ExecuteNonQuery();
            // dgvView.DataSource = filldata();
            //dgvView.Refresh();
            // MessageBox.Show("Deleted done!");

            conn.Open();
            string loadd = "DELETE FROM existbooks WHERE IDBooks = '" + dgvView.CurrentRow.Cells[0].Value.ToString() + "';";
            command = new MySqlCommand(loadd, conn);
            command.ExecuteNonQuery();
            dgvView.DataSource = filldata();
            dgvView.Refresh();
            MessageBox.Show("Deleted done!");
        }

        private void dgvView_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dgvView.CurrentRow.Cells[5].Value;

            //MemoryStream ms = new MemoryStream(img);

            //picCover.Image = Image.FromStream(ms);

            //txtEID.Text = dgvView.CurrentRow.Cells[0].Value.ToString();
            //txtETitle.Text = dgvView.CurrentRow.Cells[1].Value.ToString();
            //txtEAuthor.Text = dgvView.CurrentRow.Cells[2].Value.ToString();
            //txtEPublisher.Text = dgvView.CurrentRow.Cells[3].Value.ToString();
            //txtEYear.Text = dgvView.CurrentRow.Cells[4].Value.ToString();
            //txtEprice.Text = dgvView.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
