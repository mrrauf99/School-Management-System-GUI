using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace School_Management_System
{
    public partial class Teacher_Main_Form : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";

        Teacher_profile teacher_Profile;
        Mark_Attendence mark_Attendence;
        Mark_Marks mark_Marks;
        public Teacher_Main_Form(string name, string email)
        {
            InitializeComponent();
            txt_welcome.Text = $"Welcome, {name}";
            teacher_Profile = new Teacher_profile(email);
            mark_Attendence = new Mark_Attendence(email);
            mark_Marks = new Mark_Marks(email);
            teacher_Profile.Dock= DockStyle.Fill;
            mark_Attendence.Dock = DockStyle.Fill;
            mark_Marks.Dock = DockStyle.Fill;
            panel_form.Controls.Add(teacher_Profile);
            panel_form.Controls.Add(mark_Attendence);
            panel_form.Controls.Add(mark_Marks);
            // All controls are added, but only the top - most one will be visible by default
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {

        }

        private void lbl_minimise_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cancel_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_minimise_Click_1(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to logout?", "Confimation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Login_Form loginForm = new Login_Form();
                loginForm.Show();
                this.Close();
            }
        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_attendence_Click(object sender, EventArgs e)
        {
            mark_Attendence.Visible = true;
            mark_Attendence.ClearValues();
            teacher_Profile.Visible = false;
            mark_Marks.Visible = false;
        }

        private void btn_profile_Click_1(object sender, EventArgs e)
        {
            mark_Attendence.Visible=false;
            teacher_Profile.Visible = true;
            mark_Marks.Visible = false;
        }

        private void btn_marks_Click(object sender, EventArgs e)
        {
            mark_Attendence.Visible = false;
            teacher_Profile.Visible = false;
            mark_Marks.Visible = true;
            mark_Marks.ClearValues();
        }
    }
}
