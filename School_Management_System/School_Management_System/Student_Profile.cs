using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace School_Management_System
{
    public partial class Student_Profile : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
       "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
       "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        byte[] img;
        string Email;
        public Student_Profile()
        {
            InitializeComponent();
        }
        public Student_Profile(string e)
        {
            InitializeComponent();
            Email = e;
        }

        private void Student_Profile_Load(object sender, EventArgs e)
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
                    string query = "Select Name, Father_Name, Gender, Student_Id, Class, Section, Address, Phone_No from students s JOIN Class_Sections cs ON s.class_section_id = cs.class_section_id where Email = :email";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("email", OracleType.VarChar).Value = Email;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                txt_std_name.Text = reader[0].ToString();
                                txt_father_name.Text = reader[1].ToString();
                                txt_gender.Text = reader[2].ToString();
                                txt_std_id.Text = reader[3].ToString();
                                txt_class.Text = reader[4].ToString();
                                txt_section.Text = reader[5].ToString();
                                txt_address.Text = reader[6].ToString();
                                txt_phoneNo.Text = reader[7].ToString();
                            }
                        }
                    }
                }
                LoadStudentImage();
                txt_std_name.ReadOnly = true;
                txt_father_name.ReadOnly = true;
                txt_gender.ReadOnly = true;
                txt_std_id.ReadOnly = true;
                txt_class.ReadOnly = true;
                txt_section.ReadOnly = true;
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

                    string query = "SELECT image FROM students WHERE Email = :email";

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

        private void txt_father_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void picbox_std_Click(object sender, EventArgs e)
        {

        }
    }
}
