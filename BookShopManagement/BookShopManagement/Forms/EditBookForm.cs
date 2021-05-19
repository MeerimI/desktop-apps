using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace BookShopManagement
{
    public partial class EditBookForm : Form
    {

        

        public EditBookForm()
        {
            InitializeComponent();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        public MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;Initial Catalog='bookshop';username=root;password=root;CharSet=utf8;");


        private void btnEdit_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picECover.Image.Save(ms, picECover.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand command = new MySqlCommand("UPDATE existbooks SET Title=@title, Author=@author, Publisher=@publisher,  YearPublish=@yearPublish, Cover=@cover, Price=@price WHERE IDBooks = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtEID.Text;
            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = txtETitle.Text;
            command.Parameters.Add("@author", MySqlDbType.VarChar).Value = txtEAuthor.Text;
            command.Parameters.Add("@publisher", MySqlDbType.VarChar).Value = txtEPublisher.Text;
            command.Parameters.Add("@yearPublish", MySqlDbType.VarChar).Value = txtEYear.Text;
            command.Parameters.Add("@cover", MySqlDbType.Blob).Value = img;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = txtEprice.Text;

            ExecMyQuery(command, "Data Updated");


        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
          
           
        }
        public void FillDGV(string valueToSearch)
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM existbooks WHERE CONCAT(IDBooks, Title, Author, Publisher, YearPublish, Price ) LIKE '%" + valueToSearch + "%'", connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgv1.RowTemplate.Height = 60;

            dgv1.AllowUserToAddRows = false;

            dgv1.DataSource = table;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dgv1.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void EditBookForm_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }


        private void loadEImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picECover.Image = Image.FromFile(opf.FileName);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dgv1.CurrentRow.Cells[5].Value;

            MemoryStream ms = new MemoryStream(img);

            picECover.Image = Image.FromStream(ms);

            txtEID.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            txtETitle.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            txtEAuthor.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            txtEPublisher.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            txtEYear.Text = dgv1.CurrentRow.Cells[4].Value.ToString();
            txtEprice.Text = dgv1.CurrentRow.Cells[6].Value.ToString();

        }

        public void ExecMyQuery(MySqlCommand mcomd, string myMsg)
        {
            connection.Open();
            if (mcomd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show(myMsg);

            }
            else
            {

                MessageBox.Show("Query Not Executed");

            }

            connection.Close();

            FillDGV("");
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM existbooks WHERE IDBooks = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtEID.Text;

            ExecMyQuery(command, "Data Deleted");

            txtETitle.Text = "";
            txtETitle.Focus();
            txtEAuthor.Text = "";
            txtEPublisher.Text = "";
            txtEYear.Text = "";
            txtEprice.Text = "";
            picECover.Image = null;

        }
    }
}
