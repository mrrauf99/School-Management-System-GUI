using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Student_Main_Form : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";

        Student_Profile student_Profile1;
        View_Attendence View_Attendence1;
        View_Marks View_Marks;
        public Student_Main_Form(string name, string email)
        {
            InitializeComponent();
            txt_welcome.Text = $"Welcome, {name}";
            student_Profile1 = new Student_Profile(email);
            View_Attendence1 = new View_Attendence(email);
            View_Marks = new View_Marks(email);
            student_Profile1.Dock = DockStyle.Fill;
            View_Attendence1.Dock = DockStyle.Fill;
            View_Marks.Dock = DockStyle.Fill;
            panel_usercontrol.Controls.Add(student_Profile1);
            panel_usercontrol.Controls.Add(View_Attendence1);
            panel_usercontrol.Controls.Add(View_Marks);
            // All controls are added, but only the top - most one will be visible by default
        }
        private void lbl_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            student_Profile1.Visible = true;
            View_Attendence1.Visible = false;
            View_Marks.Visible = false;
        }

        private void lbl_welcom_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_Profile1_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to logout?", "Confimation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login_Form loginForm = new Login_Form();
                loginForm.Show();
                this.Close();
            }
        }

        private void student_Profile1_Load_1(object sender, EventArgs e)
        {

        }

        private void student_Profile1_Load_2(object sender, EventArgs e)
        {

        }

        private void panel_usercontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_attendence_Click(object sender, EventArgs e)
        {
            student_Profile1.Visible = false;
            View_Attendence1.Visible = true;
            View_Attendence1.ReloadForm();
            View_Marks.Visible = false;
        }

        private void btn_marks_Click(object sender, EventArgs e)
        {
            student_Profile1.Visible = false;
            View_Attendence1.Visible = false;
            View_Marks.Visible = true;
        }
    }
}
