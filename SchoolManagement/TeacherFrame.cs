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
    public partial class TeacherFrame : Form
    {
        public TeacherFrame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='school_management';username=root;password=");

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM sms_teacher WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxTeacherId.Text;

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
                textBoxTeacherId.Text = table.Rows[0][0].ToString();
                textBoxTeacherName.Text = table.Rows[0][1].ToString();
                textBoxTeacherEmail.Text = table.Rows[0][2].ToString();
                textBoxTeacherCell.Text = table.Rows[0][3].ToString();
                textBoxTeacherScale.Text = table.Rows[0][4].ToString();

                byte[] img = (byte[])table.Rows[0][5];
                MemoryStream ms = new MemoryStream(img);
                pictureBoxTeacher.Image = Image.FromStream(ms);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            textBoxTeacherId.Text = "";
            textBoxTeacherName.Text = "";
            textBoxTeacherEmail.Text = "";
            textBoxTeacherCell.Text = "";
            textBoxTeacherScale.Text = "";

            pictureBoxTeacher.Image = null;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Choose Image (*.JPG;*.PNG) | *.jpg;*.png";

            if (img.ShowDialog() == DialogResult.OK)
            {
                pictureBoxTeacher.Image = Image.FromFile(img.FileName);
            }
        }

        public void ShowInfo(string searchValue)
        {
            string query = "SELECT * FROM sms_teacher WHERE CONCAT(ID,NAME,EMAIL,MOBILE,SCALE) LIKE '%" + searchValue + "%'";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewAdmin.RowTemplate.Height = 60;
            dataGridViewAdmin.AllowUserToAddRows = false;
            dataGridViewAdmin.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridViewAdmin.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxTeacher.Image.Save(ms, pictureBoxTeacher.Image.RawFormat);
            byte[] img = ms.ToArray();
            string query = "INSERT INTO sms_teacher(ID,NAME,EMAIL,MOBILE,SCALE,IMAGE) VALUES (@id,@name,@email,@mob,@scale,@img)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxTeacherId.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxTeacherName.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxTeacherEmail.Text;
            cmd.Parameters.Add("@mob", MySqlDbType.VarChar).Value = textBoxTeacherCell.Text;
            cmd.Parameters.Add("@scale", MySqlDbType.VarChar).Value = textBoxTeacherScale.Text;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecuteQuery(cmd, "Data inserted");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowInfo(textBoxSearch.Text);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxTeacher.Image.Save(ms, pictureBoxTeacher.Image.RawFormat);
            byte[] img = ms.ToArray();
            string query = "UPDATE sms_teacher SET NAME=@name,EMAIL=@email,MOBILE=@mob,SCALE=@scale,IMAGE=@img WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxTeacherId.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxTeacherName.Text;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxTeacherEmail.Text;
            cmd.Parameters.Add("@mob", MySqlDbType.VarChar).Value = textBoxTeacherCell.Text;
            cmd.Parameters.Add("@scale", MySqlDbType.VarChar).Value = textBoxTeacherScale.Text;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecuteQuery(cmd, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM sms_teacher WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxTeacherId.Text;

            ExecuteQuery(cmd, "Data Deleted");
        }

        private void dataGridViewAdmin_Click(object sender, EventArgs e)
        {
            Byte[] bitImg = (Byte[])dataGridViewAdmin.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(bitImg);
            pictureBoxTeacher.Image = Image.FromStream(ms);
            textBoxTeacherId.Text = dataGridViewAdmin.CurrentRow.Cells[0].Value.ToString();
            textBoxTeacherName.Text = dataGridViewAdmin.CurrentRow.Cells[1].Value.ToString();
            textBoxTeacherEmail.Text = dataGridViewAdmin.CurrentRow.Cells[2].Value.ToString();
            textBoxTeacherCell.Text = dataGridViewAdmin.CurrentRow.Cells[3].Value.ToString();
            textBoxTeacherScale.Text = dataGridViewAdmin.CurrentRow.Cells[4].Value.ToString();
        }

        private void TeacherFrame_Load(object sender, EventArgs e)
        {
            ShowInfo("");
        }

        private void TeacherFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
