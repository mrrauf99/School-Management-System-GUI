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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace School_Management_System
{
    public partial class Mark_Attendence : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        DataTable dt;
        string Email;
        string teacherId;
        public Mark_Attendence()
        {
            InitializeComponent();
        }

        private void Mark_Attendence_Load(object sender, EventArgs e)
        {
            GetTeacherAssignmentDetails();
        }

        public Mark_Attendence(string e)
        {
            InitializeComponent();
            Email = e;
            teacherId = "";
        }

        private void cmb_class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void GetTeacherAssignmentDetails()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(ConnectionString))
                {
                    conn.Open();

                    // Step 1: Get teacher_id from teachers table using email
                    string Query = "SELECT teacher_id FROM teachers WHERE Email = :email";
                    using (OracleCommand cmd = new OracleCommand(Query, conn))
                    {
                        cmd.Parameters.Add("email", OracleType.VarChar).Value = Email;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                teacherId = reader["teacher_id"].ToString();
                            }
                        }
                    }

                    // Step 2: Get class_section_id 
                    Query = "SELECT class_section_id FROM teacher_assignments WHERE Teacher_id = :teacher_id";
                    using (OracleCommand cmd = new OracleCommand(Query, conn))
                    {
                        cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = teacherId;
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int classSectionId = Convert.ToInt32(reader["class_section_id"]);

                                // Step 3: Get Assign Classes
                                Query = "SELECT class FROM class_sections WHERE Class_Section_id = :class_section_id";
                                using (OracleCommand cmd1 = new OracleCommand(Query, conn))
                                {
                                    cmd1.Parameters.Add("class_section_id", OracleType.Int32).Value = classSectionId;
                                    using (OracleDataReader reader1 = cmd1.ExecuteReader())
                                    {
                                        while (reader1.Read())
                                        {
                                            int Class = Convert.ToInt32(reader1["class"]);
                                            if (!cmb_class.Items.Contains(Class))   // if class exist in cmb_class it returns true, otherwise it returns false
                                            {
                                                cmb_class.Items.Add(Class);
                                            }
                                        }
                                    }
                                }
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

        private void datagrid_teacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cell Content Fires only when you click directly on the content(text/checkbox) of a cell.

            // Header Row index is -1
            if (e.RowIndex >= 0 && (e.ColumnIndex == datagrid_students.Columns["Present"].Index ||
                                    e.ColumnIndex == datagrid_students.Columns["Absent"].Index))
            {
                DataGridViewRow row = datagrid_students.Rows[e.RowIndex];

                if (e.ColumnIndex == datagrid_students.Columns["Present"].Index)
                {
                    row.Cells["Present"].Value = true;
                    row.Cells["Absent"].Value = false;
                }
                else if (e.ColumnIndex == datagrid_students.Columns["Absent"].Index)
                {
                    row.Cells["Present"].Value = false;
                    row.Cells["Absent"].Value = true;
                }
            }
        }

        private void LoadStudents()
        {
            if (cmb_class.SelectedIndex == -1 || cmb_section.SelectedIndex == -1 || cmb_subject.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    int class_section_id = 0;
                    con.Open();
                    // Finding Class Section ID
                    string query = "select class_section_id from class_sections where Class = :class and Section = :section";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("class", OracleType.Int32).Value = Convert.ToInt32(cmb_class.SelectedItem);
                        cmd.Parameters.Add("section", OracleType.VarChar).Value = cmb_section.SelectedItem.ToString();
                        class_section_id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Displaying Student Data
                    query = "Select Student_ID as \"Student-ID\", Name as \"Name\" from students where class_section_id = :class_section_id order by student_id";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("class_section_id", OracleType.Int32).Value = class_section_id;
                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        dt = new DataTable();
                        adapter.Fill(dt);
                        dt.Columns.Add("Sr.No");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["Sr.No"] = i + 1;
                        }
                        dt.Columns["Sr.No"].SetOrdinal(0);     // Move Sr.No to first column
                        datagrid_students.DataSource = dt;

                        // Remove checkbox columns if they exist (from previous DataSource assignment)
                        if (datagrid_students.Columns.Contains("Present"))
                        {
                            datagrid_students.Columns.Remove("Present");
                        }

                        if (datagrid_students.Columns.Contains("Absent"))
                        {
                            datagrid_students.Columns.Remove("Absent");
                        }

                        // Add checkbox columns for Present and Absent

                        DataGridViewCheckBoxColumn presentCol = new DataGridViewCheckBoxColumn();
                        presentCol.HeaderText = "Present";
                        presentCol.Name = "Present";
                        datagrid_students.Columns.Add(presentCol);

                        DataGridViewCheckBoxColumn absentCol = new DataGridViewCheckBoxColumn();
                        absentCol.HeaderText = "Absent";
                        absentCol.Name = "Absent";
                        datagrid_students.Columns.Add(absentCol);

                        // Setting position of columns in dgv
                        datagrid_students.Columns["Present"].DisplayIndex = 3;
                        datagrid_students.Columns["Absent"].DisplayIndex = 4;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void InsertAttendanceData()
        {
            int allChecked = 0;
            for (int i = 0; i < datagrid_students.Rows.Count; i++)
            {
                if ((bool)datagrid_students.Rows[i].Cells["Present"].Value == true)
                {
                    allChecked++;
                }
                else if ((bool)datagrid_students.Rows[i].Cells["Absent"].Value == true)
                {
                    allChecked++;
                }
            }
            if (allChecked == datagrid_students.Rows.Count)
            {
                try
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        con.Open();
                        // Get the current date and time in the required format
                        string attendanceDate = DateTime.Now.ToString("dd-MMM-yyyy hh:mm tt");

                        // Get the Student ID and Attendance status from the current row
                        for (int i = 0; i < datagrid_students.Rows.Count; i++)
                        {
                            string studentId = datagrid_students.Rows[i].Cells["Student-ID"].Value.ToString();
                            string status = "";

                            // Check which attendance status is selected (Present or Absent)
                            if (Convert.ToBoolean(datagrid_students.Rows[i].Cells["Present"].Value))
                            {
                                status = "Present";
                            }
                            else if (Convert.ToBoolean(datagrid_students.Rows[i].Cells["Absent"].Value))
                            {
                                status = "Absent";
                            }

                            // Finding subject id
                            int subject_id = 0;
                            string query = "select subject_id from subjects where Subject_Name = :subject_name";
                            using (OracleCommand cmd = new OracleCommand(query, con))
                            {
                                cmd.Parameters.Add("subject_name", OracleType.VarChar).Value = cmb_subject.SelectedItem.ToString();
                                subject_id = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // Finding Attendence ID
                            int attendence_id = 0;
                            query = "select count(*) from Attendence";
                            using (OracleCommand cmd = new OracleCommand(query, con))
                            {
                                attendence_id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                            }

                            // Insert Data into Attendence Table
                            string insertQuery = "INSERT INTO Attendence (Attendence_Id, Student_id, Subject_id, Attendence_date, Status) " +
                                                 "VALUES (:attendence_id, :student_id, :subject_id,:attendence_date, :status)";
                            using (OracleCommand cmd = new OracleCommand(insertQuery, con))
                            {
                                cmd.Parameters.Add("attendence_id", OracleType.Int32).Value = attendence_id;
                                cmd.Parameters.Add("student_id", OracleType.VarChar).Value = studentId;
                                cmd.Parameters.Add("subject_id", OracleType.Int32).Value = subject_id;
                                cmd.Parameters.Add("attendence_date", OracleType.DateTime).Value = Convert.ToDateTime(attendanceDate);
                                cmd.Parameters.Add("status", OracleType.VarChar).Value = status;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Attendance Data Saved Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearValues();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select Present or Absent to Mark Attendance!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            InsertAttendanceData();
            ClearValues();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            ClearValues();
        }

        public void ClearValues()
        {
            cmb_subject.SelectedIndex = -1;
            cmb_subject.Items.Clear();
            cmb_section.SelectedIndex = -1;
            cmb_class.SelectedIndex = -1;
            datagrid_students.Columns.Clear();
        }

        private void cmb_class_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_class.SelectedIndex == -1)
            {
                cmb_section.Items.Clear();
                return;
            }
            else
            {
                cmb_section.SelectedIndex = -1;
                cmb_subject.SelectedIndex = -1;
                cmb_section.Items.Clear();
                cmb_subject.Items.Clear();
            }
                try
                {
                    using (OracleConnection con = new OracleConnection(ConnectionString))
                    {
                        con.Open();

                        int Class = Convert.ToInt32(cmb_class.SelectedItem);
                        // Get Assign Sections of Class
                        string query = "Select Section From Teacher_Assignments ta join Class_Sections cs ON ta.class_section_id = cs.class_section_id where Class = :class and Teacher_ID = :teacher_id";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add("class", OracleType.Number).Value = Class;
                            cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = teacherId;
                            using (OracleDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (!cmb_section.Items.Contains(reader[0].ToString()))
                                    {
                                        cmb_section.Items.Add(reader[0].ToString());
                                    }
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

        private void cmb_section_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_section.SelectedIndex == -1)
            {
                return;
            }
            using (OracleConnection con = new OracleConnection(ConnectionString))
            {
                con.Open();
                int class_section_id = 0;
                // Get class_section_id from Class_Sections
                string Query = "SELECT class_section_id FROM Class_Sections WHERE class = :class and section = :section";
                using (OracleCommand cmd = new OracleCommand(Query, con))
                {
                    cmd.Parameters.Add("class", OracleType.Int32).Value = Convert.ToInt32(cmb_class.SelectedItem);
                    cmd.Parameters.Add("section", OracleType.VarChar).Value = cmb_section.SelectedItem.ToString();
                    class_section_id = Convert.ToInt32(cmd.ExecuteScalar());
                }

                int subject_id = 0;
                //Get Subject_Name
                Query = "SELECT subject_id FROM Teacher_Assignments WHERE class_section_id = :class_section_id and Teacher_id = :teacher_id";
                using (OracleCommand cmd = new OracleCommand(Query, con))
                {
                    cmd.Parameters.Add("class_section_id", OracleType.Int32).Value = class_section_id;
                    cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = teacherId;
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subject_id = Convert.ToInt32(reader[0]);

                            // Query subject_name
                            Query = "SELECT subject_name FROM subjects WHERE Subject_id = :subject_id";
                            using (OracleCommand cmd1 = new OracleCommand(Query, con))
                            {
                                cmd1.Parameters.Add("subject_id", OracleType.Int32).Value = subject_id;
                                using (OracleDataReader reader1 = cmd1.ExecuteReader())
                                {
                                    if (reader1.Read())
                                    {
                                        cmb_subject.Items.Add(reader1[0].ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cmb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
