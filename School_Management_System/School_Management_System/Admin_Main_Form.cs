using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Admin_Main_Form : Form
    {
        Dashboard dashboard1;
        Students_Data students_Data1;
        Teachers_Data teachers_Data1;
        Teacher_Assignments teacher_Assignments1;
        public Admin_Main_Form()
        {
            InitializeComponent();
            dashboard1 = new Dashboard();
            students_Data1 = new Students_Data();
            teachers_Data1 = new Teachers_Data();
            teacher_Assignments1 = new Teacher_Assignments();
            dashboard1.Dock = DockStyle.Fill;
            students_Data1.Dock = DockStyle.Fill;
            teachers_Data1.Dock = DockStyle.Fill;
            teacher_Assignments1.Dock = DockStyle.Fill;
            panel_form.Controls.Add(dashboard1);
            panel_form.Controls.Add(students_Data1);
            panel_form.Controls.Add(teachers_Data1);
            panel_form.Controls.Add(teacher_Assignments1);
            // All controls are added, but only the top - most one will be visible by default
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void lbl_cancel_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to close?", "Confimation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void add_Teachers1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_std_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            teachers_Data1.Visible = false;
            students_Data1.Visible = true;
            teacher_Assignments1.Visible = false;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            teachers_Data1.Visible = false;
            students_Data1.Visible = false;
            dashboard1.ReloadForm();
            dashboard1.Visible = true;
            teacher_Assignments1.Visible = false;
        }

        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            students_Data1.Visible = false;
            teachers_Data1.Visible = true;
            teacher_Assignments1.Visible = false;
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void lbl_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void students_Data1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load_2(object sender, EventArgs e)
        {

        }

        private void btn_assignments_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            students_Data1.Visible = false;
            teachers_Data1.Visible = false;
            teacher_Assignments1.FormReload();
            teacher_Assignments1.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
