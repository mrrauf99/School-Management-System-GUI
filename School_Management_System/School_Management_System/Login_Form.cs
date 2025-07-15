using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Collections;
namespace School_Management_System
{
    public partial class Login_Form : Form
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        public Login_Form()
        {
            InitializeComponent();
        }

        private void lbl_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_show_pass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isFound = false;

            if (FoundAdmin())
            {
                isFound = true;
            }
            else if (FoundStudent())
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

        private bool FoundStudent()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string Query = "Select count(*) from Students where Email = :email and password = :password";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("email", OracleType.VarChar).Value = txt_email.Text;
                        cmd.Parameters.Add("password", OracleType.VarChar).Value = txt_pass.Text;
                        int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                        if (UserCount > 0)
                        {
                            // Welcome Name
                            string Name = "";
                            Query = "select name from students where Email = :email";
                            using (OracleCommand cmd1 = new OracleCommand(Query, con))
                            {
                                cmd1.Parameters.Add("email", OracleType.VarChar).Value = txt_email.Text;
                                using (OracleDataReader reader = cmd1.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Name = reader[0].ToString();
                                    }
                                }
                            }
                            MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Student_Main_Form std_main_form = new Student_Main_Form(Name, txt_email.Text);
                            this.Hide();
                            std_main_form.Show();
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

        private bool FoundTeacher()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string Query = "Select count(*) from Teachers where Email = :email and password = :password";
                    using (OracleCommand cmd = new OracleCommand(Query, con))
                    {
                        cmd.Parameters.Add("email", OracleType.VarChar).Value = txt_email.Text;
                        cmd.Parameters.Add("password", OracleType.VarChar).Value = txt_pass.Text;
                        int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                        if (UserCount > 0)
                        {
                            // Welcome Name 
                            Query = "select name from Teachers where Email = :email";
                            using (OracleCommand cmd1 = new OracleCommand(Query, con))
                            {
                                cmd1.Parameters.Add("email", OracleType.VarChar).Value = txt_email.Text;
                                using (OracleDataReader reader = cmd1.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Name = reader[0].ToString();
                                    }
                                }
                            }
                            MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Teacher_Main_Form teacher_Main_Form = new Teacher_Main_Form(Name, txt_email.Text);
                            this.Hide();
                            teacher_Main_Form.Show();
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
        private bool FoundAdmin()
        {
            if (txt_email.Text == "admin" && txt_pass.Text == "123")
            {
                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin_Main_Form main_Form = new Admin_Main_Form();
                this.Hide();
                main_Form.Show();
                return true;
            }
            return false;
        }

        private void lbl_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Click 'Yes' for Student or 'No' for Teacher",
                               "Select Role", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                Student_SignUp std_SignUp = new Student_SignUp();
                this.Hide();
                std_SignUp.ShowDialog();
                this.Show();
            }
            else if (Result == DialogResult.No)
            {
                Teacher_SignUp teacher_SignUp = new Teacher_SignUp();
                this.Hide();
                teacher_SignUp.ShowDialog();
                this.Show();
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {
            Forgot_Password forgot_Password = new Forgot_Password();
            this.Hide();
            forgot_Password.ShowDialog();
            this.Show();
        }
    }
}
