using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
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

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

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
            if (this.textBoxEmail.Text.Trim() == "")
            {
                // REGEX CHECKING
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
                    SQLiteCommand command = new SQLiteCommand(query, conn);
                    command.Parameters.AddWithValue("@user", this.textBoxLogin.Text);
                    command.Parameters.AddWithValue("@pass", this.textBoxPassword.Text);
                    command.Parameters.AddWithValue("@email", this.textBoxEmail.Text);
                    command.Parameters.AddWithValue("@faculty", this.comboBoxFaculty.SelectedIndex + 1);
                    MessageBox.Show(this.textBoxLogin.Text);
                    MessageBox.Show(this.textBoxPassword.Text);
                    MessageBox.Show(this.textBoxEmail.Text);
                    MessageBox.Show((this.comboBoxFaculty.SelectedIndex + 1).ToString());
                    try
                    {
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("Somthing wet wrong.");
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
