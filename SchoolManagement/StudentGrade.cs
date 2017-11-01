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
    public partial class StudentGrade : Form
    {
        public StudentGrade()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherPanel tc = new TeacherPanel();
            tc.Show();
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='school_management';username=root;password=");

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM sms_grades WHERE ID=@id";
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
                textBoxBengali.Text = table.Rows[0][1].ToString();
                textBoxEnglish.Text = table.Rows[0][2].ToString();
                textBoxICT.Text = table.Rows[0][3].ToString();
                textBoxScience.Text = table.Rows[0][4].ToString();
                textBoxMath.Text = table.Rows[0][5].ToString();
                textBoxRelStudies.Text = table.Rows[0][6].ToString();
                textBoxTotal.Text = table.Rows[0][7].ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            textBoxStudentId.Text = "";
            textBoxBengali.Text = "";
            textBoxEnglish.Text = "";
            textBoxICT.Text = "";
            textBoxScience.Text = "";
            textBoxMath.Text = "";
            textBoxRelStudies.Text = "";
            textBoxTotal.Text = "";
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

        public void ShowInfo(string searchValue)
        {
            string query = "SELECT sms_student.ID,sms_student.NAME,sms_student.CLASS,sms_grades.BENGALI,sms_grades.ENGLISH,sms_grades.ICT,sms_grades.SCIENCE,sms_grades.MATH,sms_grades.RELIGIOUS,sms_grades.TOTAL from sms_grades inner join sms_student on sms_student.ID=sms_grades.ID WHERE sms_student.ID LIKE '%" + searchValue + "%'";
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewGrade.RowTemplate.Height = 60;
            dataGridViewGrade.AllowUserToAddRows = false;
            dataGridViewGrade.DataSource = table;
            dataGridViewGrade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try {
                int ban = Convert.ToInt32(textBoxBengali.Text);
                int eng = Convert.ToInt32(textBoxBengali.Text);
                int ict = Convert.ToInt32(textBoxBengali.Text);
                int sc = Convert.ToInt32(textBoxBengali.Text);
                int math = Convert.ToInt32(textBoxBengali.Text);
                int rel = Convert.ToInt32(textBoxBengali.Text);

                if ((ban > 100 || ban < 0) && (eng > 100 || eng < 0) && (math > 100 || math < 0) && (sc > 100 || sc < 0) && (rel > 100 || rel < 0) && (ict > 100 || ict < 0))
                {
                    MessageBox.Show("Invalid Marks");
                }
                else
                {
                    int result = ban + eng + ict + sc + math + rel;
                    textBoxTotal.Text = result.ToString();


                    try
                    {
                        string query = "INSERT INTO sms_grades(ID,BENGALI,ENGLISH,ICT,SCIENCE,MATH,RELIGIOUS,TOTAL) VALUES (@id,@ban,@eng,@ict,@sc,@math,@rs,@tot)";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentId.Text;
                        cmd.Parameters.Add("@ban", MySqlDbType.VarChar).Value = textBoxBengali.Text;
                        cmd.Parameters.Add("@eng", MySqlDbType.VarChar).Value = textBoxEnglish.Text;
                        cmd.Parameters.Add("@ict", MySqlDbType.VarChar).Value = textBoxICT.Text;
                        cmd.Parameters.Add("@sc", MySqlDbType.VarChar).Value = textBoxScience.Text;
                        cmd.Parameters.Add("@math", MySqlDbType.VarChar).Value = textBoxMath.Text;
                        cmd.Parameters.Add("@rs", MySqlDbType.VarChar).Value = textBoxRelStudies.Text;
                        cmd.Parameters.Add("@tot", MySqlDbType.VarChar).Value = textBoxTotal.Text;

                        ExecuteQuery(cmd, "Data inserted");
                    }
                    catch (Exception ev)
                    {
                        MessageBox.Show("Something went wrong.Reload and try again");
                    }
                }

            }catch(Exception ev)
            {
                MessageBox.Show("Something went wrong.Reload and try again");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int ban = Convert.ToInt32(textBoxBengali.Text);
            int eng = Convert.ToInt32(textBoxBengali.Text);
            int ict = Convert.ToInt32(textBoxBengali.Text);
            int sc = Convert.ToInt32(textBoxBengali.Text);
            int math = Convert.ToInt32(textBoxBengali.Text);
            int rel = Convert.ToInt32(textBoxBengali.Text);

            if ((ban > 100 || ban < 0) && (eng > 100 || eng < 0) && (math > 100 || math < 0) && (sc > 100 || sc < 0) && (rel > 100 || rel < 0) && (ict > 100 || ict < 0))
            {
                MessageBox.Show("Invalid Marks");
            }
            else
            {
                int result = ban + eng + ict + sc + math + rel;
                textBoxTotal.Text = result.ToString();

                try
                {
                    string query = "UPDATE sms_grades SET ID=@id,BENGALI=@ban,ENGLISH=@eng,ICT=@ict,SCIENCE=@sc,MATH=@math,RELIGIOUS=@rs,TOTAL=@tot WHERE ID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentId.Text;
                    cmd.Parameters.Add("@ban", MySqlDbType.VarChar).Value = textBoxBengali.Text;
                    cmd.Parameters.Add("@eng", MySqlDbType.VarChar).Value = textBoxEnglish.Text;
                    cmd.Parameters.Add("@ict", MySqlDbType.VarChar).Value = textBoxICT.Text;
                    cmd.Parameters.Add("@sc", MySqlDbType.VarChar).Value = textBoxScience.Text;
                    cmd.Parameters.Add("@math", MySqlDbType.VarChar).Value = textBoxMath.Text;
                    cmd.Parameters.Add("@rs", MySqlDbType.VarChar).Value = textBoxRelStudies.Text;
                    cmd.Parameters.Add("@tot", MySqlDbType.VarChar).Value = textBoxTotal.Text;

                    ExecuteQuery(cmd, "Data updated");
                }
                catch (Exception ev)
                {
                    MessageBox.Show("Something went wrong.Reload and try again");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM sms_grades WHERE ID=@id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textBoxStudentId.Text;

            ExecuteQuery(cmd, "Data Deleted");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            ShowInfo(textBoxSearch.Text);
        }

        private void dataGridViewGrade_Click(object sender, EventArgs e)
        {
            textBoxStudentId.Text = dataGridViewGrade.CurrentRow.Cells[0].Value.ToString();
            textBoxBengali.Text = dataGridViewGrade.CurrentRow.Cells[3].Value.ToString();
            textBoxEnglish.Text = dataGridViewGrade.CurrentRow.Cells[4].Value.ToString();
            textBoxICT.Text = dataGridViewGrade.CurrentRow.Cells[5].Value.ToString();
            textBoxScience.Text = dataGridViewGrade.CurrentRow.Cells[6].Value.ToString();
            textBoxMath.Text = dataGridViewGrade.CurrentRow.Cells[7].Value.ToString();
            textBoxRelStudies.Text = dataGridViewGrade.CurrentRow.Cells[8].Value.ToString();
            textBoxTotal.Text = dataGridViewGrade.CurrentRow.Cells[9].Value.ToString();
        }

        private void StudentGrade_Load(object sender, EventArgs e)
        {
            ShowInfo("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentGrade sc = new StudentGrade();
            sc.Show();
        }

        private void StudentGrade_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
