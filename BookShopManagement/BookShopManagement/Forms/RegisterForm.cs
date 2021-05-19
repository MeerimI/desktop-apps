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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        dbConnect dbCon = new dbConnect();
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            dbCon.Execat("INSERT INTO users(name, surname, dateB, login, password)" +
                $"VALUES ('{txtName.Text}','{txtSurname.Text}','{dateBirth.Text}','{txtUsername.Text}','{txtPassword.Text}') ");
            MessageBox.Show("Registered Successfully");
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void dateBirth_onValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            dateBirth.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
