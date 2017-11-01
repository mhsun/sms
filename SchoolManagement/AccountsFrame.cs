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
    public partial class AccountsFrame : Form
    {
        string name;
        public AccountsFrame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public AccountsFrame(string name)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.name = name;
            if (name == "accounts")
            {
                buttonBack.Visible = false;
            }
              
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='school_management';username=root;password=");

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM sms_accounts WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentID.Text;

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found");
                clearFields();
            }
            else
            {
                textBoxStudentID.Text = table.Rows[0][0].ToString();
                textBoxLibraryFee.Text = table.Rows[0][1].ToString();
                textBoxTuitionFee.Text = table.Rows[0][2].ToString();
                textBoxExamFee.Text = table.Rows[0][3].ToString();
                textBoxOthersFee.Text = table.Rows[0][4].ToString();
            }
        }

        public void ShowInfo(string searchValue)
        {
            string query = "SELECT sms_student.ID,sms_student.NAME,sms_student.MOBILE,sms_student.CLASS,sms_student.INCHARGE,sms_accounts.LIBRARAY,sms_accounts.TUITION,sms_accounts.EXAM,sms_accounts.OTHERS from sms_accounts inner join sms_student on sms_student.ID=sms_accounts.ID WHERE sms_student.ID LIKE '%" + searchValue + "%'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adptr.Fill(table);
            dataGridViewAdmin.RowTemplate.Height = 60;
            dataGridViewAdmin.AllowUserToAddRows = false;
            dataGridViewAdmin.DataSource = table;
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AccountsFrame_Load(object sender, EventArgs e)
        {
            ShowInfo("");
        }

        public void ExecuteQuery(MySqlCommand cmd, string msg)
        {
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Insertion Failed");
            }

            con.Close();
            ShowInfo("");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            textBoxStudentID.Text = "";
            textBoxLibraryFee.Text = "";
            textBoxTuitionFee.Text = "";
            textBoxExamFee.Text = "";
            textBoxOthersFee.Text = "";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowInfo(textBoxSearch.Text);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO sms_accounts(ID,LIBRARAY,TUITION,EXAM,OTHERS) VALUES (@id,@lib,@tuition,@exam,@others)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentID.Text;
            cmd.Parameters.Add("@lib", MySqlDbType.VarChar).Value = textBoxLibraryFee.Text;
            cmd.Parameters.Add("@tuition", MySqlDbType.VarChar).Value = textBoxTuitionFee.Text;
            cmd.Parameters.Add("@exam", MySqlDbType.VarChar).Value = textBoxExamFee.Text;
            cmd.Parameters.Add("@others", MySqlDbType.VarChar).Value = textBoxOthersFee.Text;

            ExecuteQuery(cmd, "Data inserted");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE sms_accounts SET LIBRARAY=@lib,TUITION=@tuition,EXAM=@exam,OTHERS=@others WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentID.Text;
            cmd.Parameters.Add("@lib", MySqlDbType.VarChar).Value = textBoxLibraryFee.Text;
            cmd.Parameters.Add("@tuition", MySqlDbType.VarChar).Value = textBoxTuitionFee.Text;
            cmd.Parameters.Add("@exam", MySqlDbType.VarChar).Value = textBoxExamFee.Text;
            cmd.Parameters.Add("@others", MySqlDbType.VarChar).Value = textBoxOthersFee.Text;

            ExecuteQuery(cmd, "Data Updated");
        }

        private void dataGridViewAdmin_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = dataGridViewAdmin.CurrentRow.Cells[0].Value.ToString();
            textBoxLibraryFee.Text = dataGridViewAdmin.CurrentRow.Cells[5].Value.ToString();
            textBoxTuitionFee.Text = dataGridViewAdmin.CurrentRow.Cells[6].Value.ToString();
            textBoxExamFee.Text = dataGridViewAdmin.CurrentRow.Cells[7].Value.ToString();
            textBoxOthersFee.Text = dataGridViewAdmin.CurrentRow.Cells[8].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM sms_accounts WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentID.Text;

            ExecuteQuery(cmd, "Data Deleted");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
             this.Hide();
             Admin ad = new Admin();
             ad.Show();
        }

        private void AccountsFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
