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
    public partial class StudentFrame : Form
    {
        string name;
        public StudentFrame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public StudentFrame(string name)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.name = name; 
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='school_management';username=root;password=");

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (name == "teacher")
            {
                this.Hide();
                TeacherPanel tc = new TeacherPanel();
                tc.Show();
            }
            else {
                this.Hide();
                Admin ad = new Admin();
                ad.Show();
            }
           
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM sms_student WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentId.Text;

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
                textBoxStudentId.Text = table.Rows[0][0].ToString();
                textBoxStudentName.Text = table.Rows[0][1].ToString();
                textBoxStudentCell.Text = table.Rows[0][2].ToString();
                textBoxStudentClass.Text = table.Rows[0][3].ToString();
                textBoxClassIncharge.Text = table.Rows[0][4].ToString();

                byte[] img = (byte[])table.Rows[0][5];
                MemoryStream ms = new MemoryStream(img);
                pictureBoxStudent.Image = Image.FromStream(ms);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            textBoxStudentId.Text = "";
            textBoxStudentName.Text = "";
            textBoxStudentCell.Text = "";
            textBoxStudentClass.Text = "";
            textBoxClassIncharge.Text = "";

            pictureBoxStudent.Image = null;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Choose Image (*.JPG;*.PNG) | *.jpg;*.png";

            if (img.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = Image.FromFile(img.FileName);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxStudent.Image.Save(ms, pictureBoxStudent.Image.RawFormat);
            byte[] img = ms.ToArray();
            string query = "INSERT INTO sms_student(ID,NAME,MOBILE,CLASS,INCHARGE,IMAGE) VALUES (@id,@name,@mob,@class,@teacher,@img)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentId.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxStudentName.Text;
            cmd.Parameters.Add("@mob", MySqlDbType.VarChar).Value = textBoxStudentCell.Text;
            cmd.Parameters.Add("@class", MySqlDbType.VarChar).Value = textBoxStudentClass.Text;
            cmd.Parameters.Add("@teacher", MySqlDbType.VarChar).Value = textBoxClassIncharge.Text;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecuteQuery(cmd, "Data inserted");
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

        private void StudentFrame_Load(object sender, EventArgs e)
        {
            ShowInfo("");
        }

        public void ShowInfo(string searchValue)
        {
            string query = "SELECT * FROM sms_student WHERE CONCAT(ID,NAME,MOBILE,CLASS,INCHARGE) LIKE '%" + searchValue + "%'";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewStudent.RowTemplate.Height = 60;
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.DataSource = table;
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)dataGridViewStudent.Columns[5];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {
            Byte[] bitImg = (Byte[])dataGridViewStudent.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(bitImg);
            pictureBoxStudent.Image = Image.FromStream(ms);
            textBoxStudentId.Text = dataGridViewStudent.CurrentRow.Cells[0].Value.ToString();
            textBoxStudentName.Text = dataGridViewStudent.CurrentRow.Cells[1].Value.ToString();
            textBoxStudentCell.Text = dataGridViewStudent.CurrentRow.Cells[2].Value.ToString();
            textBoxStudentClass.Text = dataGridViewStudent.CurrentRow.Cells[3].Value.ToString();
            textBoxClassIncharge.Text = dataGridViewStudent.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxStudent.Image.Save(ms, pictureBoxStudent.Image.RawFormat);
            byte[] img = ms.ToArray();
            string query = "UPDATE sms_student SET NAME=@name,MOBILE=@mob,CLASS=@class,INCHARGE=@teacher,IMAGE=@img WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentId.Text;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxStudentName.Text;
            cmd.Parameters.Add("@mob", MySqlDbType.VarChar).Value = textBoxStudentCell.Text;
            cmd.Parameters.Add("@class", MySqlDbType.VarChar).Value = textBoxStudentClass.Text;
            cmd.Parameters.Add("@teacher", MySqlDbType.VarChar).Value = textBoxClassIncharge.Text;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            ExecuteQuery(cmd, "Data Updated");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM sms_student WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentId.Text;

            ExecuteQuery(cmd, "Data Deleted");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowInfo(textBoxSearch.Text);
        }

        private void StudentFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
