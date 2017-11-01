using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace SchoolManagement
{
    public partial class AdminFrame : Form
    {
        public AdminFrame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Choose Image (*.JPG;*.PNG) | *.jpg;*.png";

            if (img.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAdmin.Image = Image.FromFile(img.FileName);
            }
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='school_management';username=root;password=");

        private void AdminFrame_Load(object sender, EventArgs e)
        {
            FillDGV("");
        }

        public void FillDGV(string searchValue)
        {
            string query = "SELECT * FROM sms_admin WHERE CONCAT(ID,NAME,EMAIL,MOBILE,DESIGNATION) LIKE '%" + searchValue + "%'";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewAdmin.RowTemplate.Height = 60;
            dataGridViewAdmin.AllowUserToAddRows = false;
            dataGridViewAdmin.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridViewAdmin.Columns[6];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewAdmin_Click(object sender, EventArgs e)
        {
            Byte[] bitImg = (Byte[])dataGridViewAdmin.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(bitImg);
            pictureBoxAdmin.Image = Image.FromStream(ms);
            textBoxAdminId.Text = dataGridViewAdmin.CurrentRow.Cells[0].Value.ToString();
            textBoxAdminName.Text = dataGridViewAdmin.CurrentRow.Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewAdmin.CurrentRow.Cells[2].Value.ToString();
            textBoxAdminEmail.Text = dataGridViewAdmin.CurrentRow.Cells[3].Value.ToString();
            textBoxAdminCell.Text = dataGridViewAdmin.CurrentRow.Cells[4].Value.ToString();
            textBoxAdminPost.Text = dataGridViewAdmin.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxAdmin.Image.Save(ms, pictureBoxAdmin.Image.RawFormat);
            byte[] img = ms.ToArray();
            string query = "INSERT INTO sms_admin(ID,NAME,PASSWORD,EMAIL,MOBILE,DESIGNATION,IMAGE) VALUES (@id,@name,@pass,@email,@mob,@post,@img)";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.Add("@id",MySqlDbType.VarChar).Value = textBoxAdminId.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxAdminName.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxAdminEmail.Text;
            cmd.Parameters.Add("@mob", MySqlDbType.VarChar).Value = textBoxAdminCell.Text;
            cmd.Parameters.Add("@post", MySqlDbType.VarChar).Value = textBoxAdminPost.Text;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecuteQuery(cmd,"Data inserted");
         }

        public void ExecuteQuery(MySqlCommand cmd,string msg)
        {
            con.Open();
            if(cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Insertion Failed");
            }

            con.Close();
            FillDGV("");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxAdmin.Image.Save(ms, pictureBoxAdmin.Image.RawFormat);
            byte[] img = ms.ToArray();
            string query = "UPDATE sms_admin SET NAME=@name,PASSWORD=@pass,EMAIL=@email,MOBILE=@mob,DESIGNATION=@post,IMAGE=@img WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxAdminId.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxAdminName.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxAdminEmail.Text;
            cmd.Parameters.Add("@mob", MySqlDbType.VarChar).Value = textBoxAdminCell.Text;
            cmd.Parameters.Add("@post", MySqlDbType.VarChar).Value = textBoxAdminPost.Text;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecuteQuery(cmd, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM sms_admin WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxAdminId.Text;

            ExecuteQuery(cmd, "Data Deleted");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillDGV(textBoxSearch.Text);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM sms_admin WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxAdminId.Text;

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
                textBoxAdminId.Text = table.Rows[0][0].ToString();
                textBoxAdminName.Text = table.Rows[0][1].ToString();
                textBoxAdminEmail.Text = table.Rows[0][2].ToString();
                textBoxAdminCell.Text = table.Rows[0][3].ToString();
                textBoxAdminPost.Text = table.Rows[0][4].ToString();

                byte[] img = (byte[])table.Rows[0][5];
                MemoryStream ms = new MemoryStream(img);
                pictureBoxAdmin.Image = Image.FromStream(ms);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            textBoxAdminId.Text = "";
            textBoxAdminName.Text = "";
            textBoxAdminEmail.Text = "";
            textBoxAdminCell.Text = "";
            textBoxAdminPost.Text = "";

            pictureBoxAdmin.Image = null;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }

        private void AdminFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
