using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace University
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void labelClearFields_Click(object sender, EventArgs e)
        {
            this.textBoxLogin.Text = "";
            this.textBoxPassword.Text = "";
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                this.textBoxPassword.UseSystemPasswordChar = false;
            } else
            {
                this.textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxLogin.Text.Trim() == "" && this.textBoxPassword.Text.Trim() == "")
            {

            } else
            {
                SqliteConnection sqlite_conn;
            }
            
        }
    }
}
