using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace School_Management_System
{
    public partial class Teacher_profile : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        byte[] img;
        string Email;
        public Teacher_profile()
        {
            InitializeComponent();
        }

        public Teacher_profile(string e)
        {
            InitializeComponent();
            Email = e;
        }
        private void Teacher_profile_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string query = "Select Name, Father_Name, Gender, Teacher_Id, Degree, Salary, Address, Phone_No from teachers where Email = :email";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("email", OracleType.VarChar).Value = Email;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txt_name.Text = reader[0].ToString();
                                txt_father_name.Text = reader[1].ToString();
                                txt_gender.Text = reader[2].ToString();
                                txt_teacher_id.Text = reader[3].ToString();
                                txt_degree.Text = reader[4].ToString();
                                txt_salary.Text = reader[5].ToString();
                                txt_address.Text = reader[6].ToString();
                                txt_phoneNo.Text = reader[7].ToString();
                            }
                        }
                    }
                }
                LoadStudentImage();
                txt_name.ReadOnly = true;
                txt_father_name.ReadOnly = true;
                txt_gender.ReadOnly = true;
                txt_teacher_id.ReadOnly = true;
                txt_degree.ReadOnly = true;
                txt_salary.ReadOnly = true;
                txt_address.ReadOnly = true;
                txt_phoneNo.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentImage()
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT image FROM teachers WHERE Email = :email";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("email", OracleType.VarChar).Value = Email;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0)) 
                                {
                                    img = (byte[])reader["image"];

                                    using (MemoryStream ms = new MemoryStream(img))
                                    {
                                        picbox.Image = Image.FromStream(ms);
                                        picbox.SizeMode = PictureBoxSizeMode.Zoom;
                                    }
                                }
                                else
                                {
                                    picbox.Image = null;
                                    MessageBox.Show("No image found!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
