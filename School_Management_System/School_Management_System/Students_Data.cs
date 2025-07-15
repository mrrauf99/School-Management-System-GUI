using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace School_Management_System
{
    public partial class Students_Data : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";

        byte[] img;
        DataTable dt;
        public Students_Data()
        {
            InitializeComponent();
            datagrid_student.CellClick += Datagrid_student_CellClick;
            datagrid_student.DataBindingComplete += Datagrid_student_DataBindingComplete;
        }

        private void Datagrid_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Header Row index is -1
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = datagrid_student.Rows[e.RowIndex];  // it copy data from DataGridView source
                datagrid_student.Rows[e.RowIndex].Selected = true;
                txt_std_id.Text = r.Cells[1].Value.ToString();
                txt_std_name.Text = r.Cells[2].Value.ToString();
                txt_father_name.Text = r.Cells[3].Value.ToString();
                string gender = r.Cells[4].Value.ToString();
                if (gender == "Male")
                {
                    rdbtn_std_male.Checked = true;
                }
                else
                {
                    rdbtn_std_female.Checked = true;
                }
                txt_std_address.Text = r.Cells[5].Value.ToString();
                txt_phoneNo.Text = r.Cells[6].Value.ToString();
                cmb_class.SelectedItem = r.Cells[7].Value.ToString();
                cmb_section.SelectedItem = r.Cells[8].Value.ToString();
                cmb_status.SelectedItem = r.Cells[9].Value.ToString();
                txt_std_id.ReadOnly = true;
                LoadStudentImage();
            }
        }

        private void Datagrid_student_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Formatting Grid View 
            datagrid_student.Columns["Sr.No"].Width = 70;
            datagrid_student.Columns["Sr.No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_student.Columns["Phone-No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_student.Columns["Student-ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_student.Columns["Class"].Width = 60;
            datagrid_student.Columns["Class"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_student.Columns["Section"].Width = 60;
            datagrid_student.Columns["Section"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_student.Columns["Status"].Width = 90;
            datagrid_student.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_student.Columns["Gender"].Width = 80;
            datagrid_student.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Students_Data_Load(object sender, EventArgs e)
        {
            LoadStudentsData();
            LoadClasses();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_std_id.Text == "" || txt_father_name.Text == "" || txt_std_name.Text == "" || (rdbtn_std_female.Checked == false && rdbtn_std_male.Checked == false) || txt_std_address.Text == "" || txt_phoneNo.Text == "" || cmb_class.SelectedIndex == -1 || cmb_section.SelectedIndex == -1 || img == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Gender = "";
            if (rdbtn_std_female.Checked == true)
            {
                Gender = "Female";
            }
            else
            {
                Gender = "Male";
            }
            try
            {
                if (!FoundStudentID())
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        con.Open();
                        int class_section_id = 0;
                        // Finding Class Section ID
                        string query = "Select class_section_id from class_sections where Class = :class AND Section = :section";
                        using (OracleCommand cmd1 = new OracleCommand(query, con))
                        {
                            cmd1.Parameters.Add("class", OracleType.Int32).Value = Convert.ToInt32(cmb_class.SelectedItem);
                            cmd1.Parameters.Add("section", OracleType.VarChar).Value = cmb_section.SelectedItem.ToString();
                            class_section_id = Convert.ToInt32(cmd1.ExecuteScalar());
                        }
                        query = "Insert into Students (student_id, name, father_name, gender, address, phone_no, image, status, Admission_Date, Class_section_id) values (:std_id, :name, :father_name, :gender, :address, :phone_no, :image, :status, to_date(:admission_date, 'DD-MM-YYYY'), :class_section_id)";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            // Same sequence me parameters add krne jaise query me likhe hn 
                            cmd.Parameters.Add("std_id", OracleType.VarChar).Value = txt_std_id.Text;
                            cmd.Parameters.Add("name", OracleType.VarChar).Value = txt_std_name.Text;
                            cmd.Parameters.Add("father_name", OracleType.VarChar).Value = txt_father_name.Text;
                            cmd.Parameters.Add("gender", OracleType.VarChar).Value = Gender;
                            cmd.Parameters.Add("address", OracleType.VarChar).Value = txt_std_address.Text;
                            cmd.Parameters.Add("phone_no", OracleType.VarChar).Value = txt_phoneNo.Text;
                            cmd.Parameters.Add("image", OracleType.Blob).Value = img;
                            cmd.Parameters.Add("status", OracleType.VarChar).Value = cmb_status.SelectedItem.ToString();
                            cmd.Parameters.Add("admission_date", OracleType.VarChar).Value = DateTime.Now.ToString("dd-MM-yyyy");
                            cmd.Parameters.Add("class_section_id", OracleType.VarChar).Value = class_section_id;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Student Data Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudentsData();
                            ClearText();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Student-ID Already Exist!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            GetImageBytes();
        }

        private void GetImageBytes()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "[JPG,JPEG]|*.jpg; *.png";
            try
            {
                //If the user selects a file(i.e., DialogResult.OK), the code proceeds to read the file.
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image
                    picbox_std.Image = Image.FromFile(openFileDialog1.FileName);
                    picbox_std.SizeMode = PictureBoxSizeMode.Zoom;
                    using (FileStream FS = new FileStream(@openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        // .FileName contains the full file path of the selected file.
                        // FileStream can perform both reading and writing operations
                        img = new byte[FS.Length];
                        // FS.Length size of that img
                        FS.Read(img, 0, Convert.ToInt32(FS.Length));
                        /*   img – The destination byte array where the file data will be stored.
                             0 – The starting position in the byte array where data will be written.
                             Convert.ToInt32(FS.Length) – The number of bytes to read from the file.  */
                    }
                }
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

                    string query = "SELECT image FROM students WHERE student_id = :std_id";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("std_id", OracleType.VarChar).Value = txt_std_id.Text;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))   //means "if the value is NOT null", so it’s safe to read the value.
                                {
                                    img = (byte[])reader["image"];

                                    using (MemoryStream ms = new MemoryStream(img))
                                    {
                                        picbox_std.Image = Image.FromStream(ms);
                                        picbox_std.SizeMode = PictureBoxSizeMode.Zoom;
                                    }
                                }
                                else
                                {
                                    picbox_std.Image = null;
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
                        cmd.Parameters.Add("std_id", OracleType.VarChar).Value = txt_std_id.Text;
                        int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                        // cmd.ExecuteScaler() method return a single value like Sum, Count(*),Avg...etc
                        // It can also retrieve a single value from query
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

        private void LoadStudentsData()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    string query = "Select s.Student_ID as \"Student-ID\", s.Name as \"Name\", s.Father_Name as \"Father Name\", s.Gender as \"Gender\", s.Address as \"Address\", s.Phone_No as \"Phone-No\", cs.Class as \"Class\", cs.Section as \"Section\", s.Status as \"Status\" from Students s join Class_Sections cs using (class_section_id) order by student_id";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        dt = new DataTable();
                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        // Fetch data from Oracle
                        adapter.Fill(dt);
                        // Stored data in table obj
                        dt.Columns.Add("Sr.No");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["Sr.No"] = i + 1;
                        }
                        dt.Columns["Sr.No"].SetOrdinal(0);   // Move Sr.No to first column
                        datagrid_student.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_father_name.Text == "" || txt_std_name.Text == "" || (rdbtn_std_female.Checked == false && rdbtn_std_male.Checked == false) || txt_std_address.Text == "" || txt_phoneNo.Text == "" || cmb_class.SelectedIndex == -1 || cmb_section.SelectedIndex == -1 || img == null || cmb_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Gender = "";
            if (rdbtn_std_female.Checked == true)
            {
                Gender = "Female";
            }
            else
            {
                Gender = "Male";
            }
            try
            {
                DialogResult check = MessageBox.Show("Are you sure want to update?", "Confimation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        int class_section_id = 0;
                        con.Open();
                        string query = "Select class_section_id from class_sections where Class = :class AND Section = :section";
                        using (OracleCommand cmd1 = new OracleCommand(query, con))
                        {
                            cmd1.Parameters.Add("class", OracleType.Int32).Value = Convert.ToInt32(cmb_class.SelectedItem);
                            cmd1.Parameters.Add("section", OracleType.VarChar).Value = cmb_section.SelectedItem.ToString();
                            class_section_id = Convert.ToInt32(cmd1.ExecuteScalar());
                        }
                        query = "Update Students set Name = :name, Father_Name = :father_name, Gender = :gender, Address = :address, Phone_No = :phone_no, Status = :status,Image = :img, Class_Section_id = :class_section_id where Student_ID = :std_id";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add("name", OracleType.VarChar).Value = txt_std_name.Text;
                            cmd.Parameters.Add("father_name", OracleType.VarChar).Value = txt_father_name.Text;
                            cmd.Parameters.Add("gender", OracleType.VarChar).Value = Gender;
                            cmd.Parameters.Add("address", OracleType.VarChar).Value = txt_std_address.Text;
                            cmd.Parameters.Add("phone_no", OracleType.VarChar).Value = txt_phoneNo.Text;
                            cmd.Parameters.Add("status", OracleType.VarChar).Value = cmb_status.SelectedItem.ToString();
                            cmd.Parameters.Add("img", OracleType.Blob).Value = img;
                            cmd.Parameters.Add("class_section_id", OracleType.Int32).Value = class_section_id;
                            cmd.Parameters.Add("std_id", OracleType.VarChar).Value = txt_std_id.Text;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Student Data Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudentsData();
                            ClearText();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Student ID not found!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Are you sure want to delete?", "Confimation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        con.Open();
                        string query = "Delete from students where student_id = :std_id";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add("std_id", OracleType.VarChar).Value = txt_std_id.Text;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Student Data Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudentsData();
                            ClearText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = "";
                if (txt_std_name.Text != "")
                {
                    filter += $"[Name] Like '%{txt_std_name.Text}%'";     // %  % Match anything before or after
                }                                                         // [ Column Name ] and ' ' to indicate string literals
                if (txt_father_name.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Father Name] Like '%{txt_father_name.Text}%'";
                }
                if (txt_std_id.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Student-ID] = '{txt_std_id.Text}'";
                }
                if (txt_std_address.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Address] Like '%{txt_std_address.Text}%'";
                }
                if (txt_phoneNo.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Phone-No] Like '%{txt_phoneNo.Text}%'";
                }
                if (rdbtn_std_female.Checked == true || rdbtn_std_male.Checked == true)
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    string gender = "";
                    if (rdbtn_std_female.Checked == true)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        gender = "Male";
                    }
                    filter += $"[Gender] = '{gender}'";
                }
                if (cmb_class.SelectedIndex != -1)
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Class] = '{cmb_class.SelectedItem.ToString()}'";
                }
                if (cmb_section.SelectedIndex != -1 || cmb_section.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Section] = '{cmb_section.Text}'";
                }
                if (cmb_status.SelectedIndex != -1)
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Status] = '{cmb_status.SelectedItem.ToString()}'";
                }
                DataView dv = new DataView(dt);
                dv.RowFilter = filter;
                datagrid_student.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearText()
        {
            txt_std_id.ReadOnly = false;
            txt_std_id.Text = "";
            txt_std_name.Text = "";
            rdbtn_std_female.Checked = false;
            rdbtn_std_male.Checked = false;
            txt_std_address.Text = "";
            txt_phoneNo.Text = "";
            cmb_section.Items.Clear();
            cmb_section.Text = "";
            cmb_class.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;
            picbox_std.Image = null;
            txt_father_name.Text = "";
            img = null;
            LoadStudentsData();
        }

        private void txt_std_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void picbox_std_Click(object sender, EventArgs e)
        {

        }

        private void cmb_section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_class.SelectedIndex == -1)
            {
                cmb_section.Items.Clear();
                return;
            }
            else
            {
                cmb_section.SelectedIndex = -1;
                cmb_section.Items.Clear();
            }
            try
            {
                string selectedClass = cmb_class.SelectedItem.ToString();
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string query = "Select Section From Class_sections where Class = :class";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("class", OracleType.VarChar).Value = selectedClass;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmb_section.Items.Add(reader[0].ToString());
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

        private void LoadClasses()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string query = "Select distinct(Class) From Class_sections";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmb_class.Items.Add(reader[0].ToString());
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
