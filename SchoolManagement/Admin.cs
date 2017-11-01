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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            StudentFrame st = new StudentFrame();
            st.Show();
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TeacherFrame tc = new TeacherFrame();
            tc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AdminFrame ad = new AdminFrame();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AccountsFrame ad = new AccountsFrame("admin");
            ad.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
