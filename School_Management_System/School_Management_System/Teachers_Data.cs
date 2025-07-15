using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace School_Management_System
{
    public partial class Teachers_Data : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";

        byte[] img;
        DataTable dt;
        public Teachers_Data()
        {
            InitializeComponent();
            datagrid_teacher.CellClick += Datagrid_teacher_CellClick;
            datagrid_teacher.DataBindingComplete += Datagrid_teacher_DataBindingComplete;
        }

        private void Datagrid_teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Header Row index is -1
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = datagrid_teacher.Rows[e.RowIndex];  // it copy data from DataGridView source
                datagrid_teacher.Rows[e.RowIndex].Selected = true;
                txt_teacher_id.Text = r.Cells[1].Value.ToString();
                txt_teacher_name.Text = r.Cells[2].Value.ToString();
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
                txt_address.Text = r.Cells[5].Value.ToString();
                txt_phoneNo.Text = r.Cells[6].Value.ToString();
                txt_degree.Text = r.Cells[7].Value.ToString();
                num_salary.Value = Convert.ToInt32(r.Cells[8].Value);
                txt_teacher_id.ReadOnly = true;
                LoadTeacherImage();
            }
        }

        private void Datagrid_teacher_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Formatting Grid View
            datagrid_teacher.Columns["Sr.No"].Width = 70;
            datagrid_teacher.Columns["Sr.No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_teacher.Columns["Degree"].Width = 80;
            datagrid_teacher.Columns["Degree"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_teacher.Columns["Gender"].Width = 80;
            datagrid_teacher.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_teacher.Columns["Salary"].Width = 80;
            datagrid_teacher.Columns["Salary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_teacher.Columns["Phone-No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_teacher.Columns["Teacher-ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Teachers_Data_Load(object sender, EventArgs e)
        {
            LoadTeachersData();
        }
        private void txt_degree_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagrid_teacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_father_name.Text == "" || txt_teacher_name.Text == "" || (rdbtn_std_female.Checked == false && rdbtn_std_male.Checked == false) || txt_address.Text == "" || txt_phoneNo.Text == "" || txt_degree.Text == "" || img == null || num_salary.Value == 0)
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
                        con.Open();
                        string query = "Update Teachers set Name = :name, Father_Name = :father_name, Gender = :gender, Address = :address, Phone_No = :phone_no, Degree = :degree, Image = :img, Salary = :salary where Teacher_ID = :teacher_id";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add("name", OracleType.VarChar).Value = txt_teacher_name.Text;
                            cmd.Parameters.Add("father_name", OracleType.VarChar).Value = txt_father_name.Text;
                            cmd.Parameters.Add("gender", OracleType.VarChar).Value = Gender;
                            cmd.Parameters.Add("address", OracleType.VarChar).Value = txt_address.Text;
                            cmd.Parameters.Add("phone_no", OracleType.VarChar).Value = txt_phoneNo.Text;
                            cmd.Parameters.Add("degree", OracleType.VarChar).Value = txt_degree.Text;
                            cmd.Parameters.Add("img", OracleType.Blob).Value = img;
                            cmd.Parameters.Add("salary", OracleType.Number).Value = num_salary.Value;
                            cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = txt_teacher_id.Text;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Teacher Data Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeachersData();
                            ClearText();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Teacher ID not found!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_teacher_id.Text == "" || txt_father_name.Text == "" || txt_teacher_name.Text == "" || (rdbtn_std_female.Checked == false && rdbtn_std_male.Checked == false) || txt_address.Text == "" || txt_phoneNo.Text == "" || txt_degree.Text == "" || img == null || num_salary.Value == 0)
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
                if (!FoundTeacherID())
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        con.Open();
                        string query = "Insert into Teachers (teacher_id, name, father_name, gender, address, phone_no, degree, image, Salary, Hire_date) values (:teacher_id, :name, :father_name, :gender, :address, :phone_no, :degree, :image, :salary, to_date(:hire_date, 'dd-mon-yyyy'))";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            // Same sequence me parameters add krne jaise query me likhe hn 
                            cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = txt_teacher_id.Text;
                            cmd.Parameters.Add("name", OracleType.VarChar).Value = txt_teacher_name.Text;
                            cmd.Parameters.Add("father_name", OracleType.VarChar).Value = txt_father_name.Text;
                            cmd.Parameters.Add("gender", OracleType.VarChar).Value = Gender;
                            cmd.Parameters.Add("address", OracleType.VarChar).Value = txt_address.Text;
                            cmd.Parameters.Add("phone_no", OracleType.VarChar).Value = txt_phoneNo.Text;
                            cmd.Parameters.Add("degree", OracleType.VarChar).Value = txt_degree.Text;
                            cmd.Parameters.Add("image", OracleType.Blob).Value = img;
                            cmd.Parameters.Add("salary", OracleType.Number).Value = num_salary.Value;
                            cmd.Parameters.Add("hire_date", OracleType.VarChar).Value = DateTime.Now.ToString("dd-MMM-yyyy");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Teacher Data Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeachersData();
                            ClearText();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Teacher-ID Already Exist!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_std_pic_Click(object sender, EventArgs e)
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
                    picbox_teacher.Image = Image.FromFile(openFileDialog1.FileName);
                    picbox_teacher.SizeMode = PictureBoxSizeMode.Zoom;
                    using (FileStream FS = new FileStream(@openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                    {
                        img = new byte[FS.Length];
                        FS.Read(img, 0, Convert.ToInt32(FS.Length));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeacherImage()
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT image FROM teachers WHERE teacher_id = :teacher_id";

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = txt_teacher_id.Text;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0))   //means "if the value is NOT null", so it’s safe to read the value.
                                {
                                    img = (byte[])reader["image"];

                                    using (MemoryStream ms = new MemoryStream(img))
                                    {
                                        picbox_teacher.Image = Image.FromStream(ms);
                                        picbox_teacher.SizeMode = PictureBoxSizeMode.Zoom;
                                    }
                                }
                                else
                                {
                                    picbox_teacher.Image = null;
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
                        cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = txt_teacher_id.Text;
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

        private void LoadTeachersData()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    string query = "Select Teacher_ID as \"Teacher-ID\", Name as \"Name\", Father_Name as \"Father Name\", Gender as \"Gender\", Address as \"Address\", Phone_No as \"Phone-No\", Degree as \"Degree\", Salary as \"Salary\" from teachers order by teacher_id";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        dt = new DataTable();
                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        // Fetch data from Oracle
                        adapter.Fill(dt);
                        // Stored data in table obj;
                        dt.Columns.Add("Sr.No");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["Sr.No"] = i + 1;
                        }
                        dt.Columns["Sr.No"].SetOrdinal(0);     // Move Sr.No to first column
                        datagrid_teacher.DataSource = dt;
                    }
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
                        string query = "Delete from teachers where teacher_id = :teacher_id";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = txt_teacher_id.Text;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Teacher Data Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTeachersData();
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
                if (txt_teacher_name.Text != "")
                {
                    filter += $"[Name] Like '%{txt_teacher_name.Text}%'";     // %  % Match anything before or after
                }                                                         // [ Column Name ] and ' ' to indicate string literals
                if (txt_father_name.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Father Name] Like '%{txt_father_name.Text}%'";
                }
                if (txt_teacher_id.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Teacher-ID] = '{txt_teacher_id.Text}'";
                }
                if (txt_address.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Address] Like '%{txt_address.Text}%'";
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
                if (txt_degree.Text != "")
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Degree] Like '{txt_degree.Text}'";
                }
                if (num_salary.Value != 0)
                {
                    if (filter != "")
                    {
                        filter += "AND ";
                    }
                    filter += $"[Salary] = '{num_salary.Value}'";
                }
                DataView dv = new DataView(dt);
                dv.RowFilter = filter;
                datagrid_teacher.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearText()
        {
            txt_teacher_id.ReadOnly = false;
            txt_teacher_id.Text = "";
            txt_teacher_name.Text = "";
            rdbtn_std_female.Checked = false;
            rdbtn_std_male.Checked = false;
            txt_address.Text = "";
            txt_phoneNo.Text = "";
            txt_degree.Text = "";
            picbox_teacher.Image = null;
            txt_father_name.Text = "";
            img = null;
            num_salary.Value = 0;
            LoadTeachersData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void picbox_teacher_Click(object sender, EventArgs e)
        {

        }
    }
}
