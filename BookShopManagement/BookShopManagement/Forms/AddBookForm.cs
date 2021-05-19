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
    public partial class AddBookForm : Form
    {
        static string filename = string.Empty;

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPublisher_OnValueChanged(object sender, EventArgs e)
        {

        }
        dbConnect dbCon1 = new dbConnect();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != null && txtAuthor.Text != null && txtPublisher.Text != null && txtYear.Text != null)
            {
                dbCon1.Execat("INSERT INTO existbooks(Title, Author, Publisher, YearPublish, Price, Cover)" +

                 $"VALUES ('{txtTitle.Text}','{txtAuthor.Text}','{txtPublisher.Text}','{txtYear.Text}', '{txtPrice.Text}', '{picCover.Image}') ");
                MessageBox.Show("Save data successfull!");
            }
            else if (txtTitle.Text == null | txtAuthor.Text == null | txtPublisher.Text == null | txtYear.Text == null)
            {
                MessageBox.Show("Error!");
            }


        }
        private void btnNewBook_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtTitle.Focus();
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtYear.Text = "";
            txtPrice.Text = "";
            picCover.Image = null;


        }


        private void loadImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg; *.png", ValidateNames = true, Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    picCover.Image = Image.FromFile(filename);
                }
            }
        }

        private void txtYear_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
