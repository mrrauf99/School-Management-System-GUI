using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace School_Management_System
{
    public partial class Teacher_SignUp : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        public Teacher_SignUp()
        {
            InitializeComponent();
        }

        private void Teacher_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            TeacherSignUp();
        }

        private bool FoundTeacherID()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string Query = "Select count(*) from teachers where teacher_id = :teacher_id";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("std_id", OracleDbType.Varchar2).Value = txt_teacher_id.Text;
                        int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                        if (UserCount == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void TeacherSignUp()
        {
            if (txt_email.Text == "" || txt_teacher_id.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (FoundTeacherID())
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        con.Open();
                        string query = "Select count(*) from teachers where teacher_id = :teacher_id And Email is NULL And Password is NULL";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add("teacher_id", OracleDbType.Varchar2).Value = txt_teacher_id.Text;
                            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                            {
                                query = "Update teachers set Email = :email, Password = :pass where teacher_id = :teacher_id";
                                using (OracleCommand cmd1 = new OracleCommand(query, con))
                                {
                                    cmd1.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                                    cmd1.Parameters.Add("pass", OracleDbType.Varchar2).Value = txt_pass.Text;
                                    cmd1.Parameters.Add("teacher_id", OracleDbType.Varchar2).Value = txt_teacher_id.Text;
                                    cmd1.ExecuteNonQuery();
                                    MessageBox.Show("Sign Up Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Already Sign Up!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Teacher-ID Not Found!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_pass_Click(object sender, EventArgs e)
        {
            if (txt_pass.PasswordChar == '*')
            {
                txt_pass.PasswordChar = '\0';   // Remove Masking
                pic_pass.Image = Properties.Resources.view;
            }
            else
            {
                txt_pass.PasswordChar = '*';    // Masking
                pic_pass.Image = Properties.Resources.hide;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
