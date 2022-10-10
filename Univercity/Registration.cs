using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            addComboboxItems();
        }

        private void addComboboxItems()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=user.db;Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM faculty ORDER BY id";
              
                SQLiteCommand command = new SQLiteCommand(query, conn);
                try
                {
                    dt.Load(command.ExecuteReader());
                } catch (Exception ex)
                {
                    MessageBox.Show("Somthing wet wrong, try again later");
                }
            }
            this.comboBoxFaculty.DataSource = dt;
            this.comboBoxFaculty.ValueMember = "id";
            this.comboBoxFaculty.DisplayMember = "name";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool validCredentials = true;
            if (this.textBoxLogin.Text.Trim() == "")
            {
                this.labelLogin.ForeColor = Color.Red;
                validCredentials = false;
            }
            else
            {
                this.labelLogin.ForeColor = Color.MidnightBlue;
            }
            if (this.textBoxEmail.Text.Trim() == "" || !this.IsValidEmail(this.textBoxEmail.Text.Trim()))
            {
                this.label1.ForeColor = Color.Red;
                validCredentials = false;
            }
            else
            {
                this.label1.ForeColor = Color.MidnightBlue;
            }
            if (this.textBoxPassword.Text.Trim() == "" || this.textBoxRepeatPassword.Text.Trim() == "" || this.textBoxPassword.Text != this.textBoxRepeatPassword.Text)
            {
                this.labelPassword.ForeColor = Color.Red;
                this.labelRepeatPassowrd.ForeColor = Color.Red;
                validCredentials = false;
            }
            else
            {
                this.labelPassword.ForeColor = Color.MidnightBlue;
                this.labelRepeatPassowrd.ForeColor = Color.MidnightBlue;
            }

            if (validCredentials)
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=user.db;Version=3;"))
                {
                    conn.Open();
                    string query = "INSERT INTO user(username, password, email, faculty_id) VALUES(@user, @pass, @email, @faculty)";
                    using SQLiteCommand command = new SQLiteCommand(query, conn);
                    command.Parameters.AddWithValue("@user", this.textBoxLogin.Text);
                    command.Parameters.AddWithValue("@pass", this.textBoxPassword.Text);
                    command.Parameters.AddWithValue("@email", this.textBoxEmail.Text);
                    command.Parameters.AddWithValue("@faculty", this.comboBoxFaculty.SelectedIndex + 1);
                    try
                    {
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                        MessageBox.Show("Successfully registered.");
                        Close();
                    } catch (Exception ex)
                    {
                        if (ex.Message.Contains("constraint") && ex.Message.Contains("username"))
                        {
                            MessageBox.Show("User by this username already exists");
                            this.labelLogin.ForeColor = Color.Red;
                        } else if (ex.Message.Contains("constraint") && ex.Message.Contains("email"))
                        {
                            MessageBox.Show("User by this email already exists");
                            this.label1.ForeColor = Color.Red;
                        } else
                        {
                            MessageBox.Show(ex.ToString());
                            MessageBox.Show("Somthing wet wrong.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check credentials");
            }
        }
    }
}
