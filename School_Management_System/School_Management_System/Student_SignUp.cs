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
    public partial class Student_SignUp : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        public Student_SignUp()
        {
            InitializeComponent();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            StudentSignUp();
        }

        private void StudentSignUp()
        {
            if (txt_email.Text == "" || txt_std_id.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (FoundStudentID())
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        con.Open();
                        string query = "Select count(*) from students where student_id = :std_id And Email is NULL And Password is NULL";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add("std_id", OracleDbType.Varchar2).Value = txt_std_id.Text;
                            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                            {
                                query = "Update students set Email = :email, Password = :pass where student_id = :std_id";
                                using (OracleCommand cmd1 = new OracleCommand(query, con))
                                {
                                    cmd1.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                                    cmd1.Parameters.Add("pass", OracleDbType.Varchar2).Value = txt_pass.Text;
                                    cmd1.Parameters.Add("std_id", OracleDbType.Varchar2).Value = txt_std_id.Text;
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
                    MessageBox.Show("Student-ID Not Found!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FoundStudentID()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string Query = "Select count(*) from students where student_id = :std_id";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("std_id", OracleDbType.Varchar2).Value = txt_std_id.Text;
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

        private void lbl_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void Student_SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
