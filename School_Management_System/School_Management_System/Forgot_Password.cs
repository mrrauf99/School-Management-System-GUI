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
    public partial class Forgot_Password : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isFound = false;

            if (FoundStudent())
            {
                isFound = true;
            }
            else if (FoundTeacher())
            {
                isFound = true;
            }
            if (!isFound)
            {
                MessageBox.Show("Invalid Username/Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        private bool FoundTeacher()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    // Step 1: Check if email exists in Teacher table
                    string query = "Select count(*) from Teachers where Email = :email";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            // Step 2: Update password
                            query = "Update Teacher set Password = :pass where Email = :email";
                            using (OracleCommand cmd1 = new OracleCommand(query, con))
                            {
                                cmd1.Parameters.Add("pass", OracleDbType.Varchar2).Value = txt_pass.Text;
                                cmd1.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Password Changed Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
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

        private bool FoundStudent()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    // Step 1: Check if email exists in Student table
                    string query = "Select count(*) from Students where Email = :email";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            // Step 2: Update password
                            query = "Update Student set Password = :pass where Email = :email";
                            using (OracleCommand cmd1 = new OracleCommand(query, con))
                            {
                                cmd1.Parameters.Add("pass", OracleDbType.Varchar2).Value = txt_pass.Text;
                                cmd1.Parameters.Add("email", OracleDbType.Varchar2).Value = txt_email.Text;
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Password Changed Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
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
            this.WindowState=FormWindowState.Minimized;
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

        private void Forgot_Password_Load(object sender, EventArgs e)
        {

        }
    }
}
