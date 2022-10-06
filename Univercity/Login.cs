using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic.ApplicationServices;

namespace University
{
    public partial class Login : Form
    {
        private User user;
        public Login(User user)
        {
            InitializeComponent();
            this.user = user;
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
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=user.db;Version=3;"))
                {
                    conn.Open();
                    string query = "SELECT * FROM user WHERE username = @user AND password = @pass";
                    SQLiteCommand command = new SQLiteCommand(query, conn);
                    command.Parameters.AddWithValue("@user", this.textBoxLogin.Text);
                    command.Parameters.AddWithValue("@pass", this.textBoxPassword.Text);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string username = reader["username"].ToString();
                        this.user.id = id;
                        this.user.username = username;
                        MessageBox.Show("Hello, " + username);
                        Close();

                    } else
                    {
                        MessageBox.Show("Somthing wet wrong, try again");
                        this.textBoxLogin.Text = "";
                        this.textBoxPassword.Text = "";
                    }
                }
            }
            
        }
    }
}
