using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class TeacherPanel : Form
    {
        public TeacherPanel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentFrame st = new StudentFrame("teacher");
            st.Show();
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentGrade gr = new StudentGrade();
            gr.Show();
        }

        private void TeacherPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
