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

namespace SchoolManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='school_management';username=root;password=");
        int i = 0;
        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM sms_admin WHERE EMAIL=@mail AND PASSWORD=@pass";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@mail", MySqlDbType.VarChar).Value = userTextBox.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordTextBox.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Empty or Invalid UserName or PassWord");
            }
            else
            {
                string adminType = table.Rows[0][5].ToString();
                if (adminType.ToLower() == "admin")
                {
                    this.Hide();
                    Admin ad = new Admin();
                    ad.Show();
                }
                else if (adminType.ToLower() == "accounts")
                {
                    this.Hide();
                    AccountsFrame ac = new AccountsFrame("accounts");
                    ac.Show();
                }
                else 
                {
                    this.Hide();
                    TeacherPanel tc = new TeacherPanel();
                    tc.Show();
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
