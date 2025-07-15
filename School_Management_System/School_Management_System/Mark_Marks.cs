using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.OracleClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace School_Management_System
{
    public partial class Mark_Marks : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        DataTable dt;
        string Email;
        string teacherId;
        public Mark_Marks()
        {
            InitializeComponent();
        }

        public Mark_Marks(string e)
        {
            InitializeComponent();
            Email = e;
            teacherId = "";
            datagrid_students.CellValueChanged += Datagrid_teacher_CellValueChanged;
        }

        private void Datagrid_teacher_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Header Row index is -1
            if (e.RowIndex >= 0 && e.ColumnIndex == datagrid_students.Columns["Obtained Marks"].Index)
            {
                int Total_Marks = Convert.ToInt32(datagrid_students.Rows[e.RowIndex].Cells["Total Marks"].Value);
                var obtained_cell = datagrid_students.Rows[e.RowIndex].Cells["Obtained Marks"];
                // var is a C# keyword that allows the compiler to automatically determine the data type based on the value assigned.
                // The compiler predict that obtainedCell is of type DataGridViewCell because you are assigning a cell from a DataGridView to it.
                // obtained_cell varaible hold reference of dgv cell object

                string value = obtained_cell.Value?.ToString();

                /* ? stands for Null Conditional Operator
                   In this case : "If obtained_cell.Value is not null, call the ToString() method to convert it to a string."
                   If obtained_cell.Value is null, the ?. operator ensures that ToString() is not called, and instead, null is returned immediately, preventing a NullReferenceException*/


                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                // Check the value is in digit form or in string form
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        MessageBox.Show($"Obtained Marks must be between 0 and {Total_Marks}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        obtained_cell.Value = null;
                        return;
                    }
                }
                double obtained_marks = Convert.ToDouble(value);
                if (obtained_marks > Total_Marks)
                {
                    MessageBox.Show($"Obtained Marks must be between 0 and {Total_Marks}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    obtained_cell.Value = null;
                }
            }
        }

        private void Mark_Marks_Load(object sender, EventArgs e)
        {
            GetAssignClasses();
        }

        private void GetAssignClasses()
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            if (cmb_class.SelectedIndex == -1 || cmb_section.SelectedIndex == -1 || cmb_subject.SelectedIndex == -1 || cmb_exam_type.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    int class_section_id = 0;
                    int total_marks = 0;
                    int subject_id = 0;
                    con.Open();

                    // Retrieve Subject ID
                    string query = "select subject_id from subjects where subject_name = :subject_name";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("subject_name", OracleType.VarChar).Value = cmb_subject.SelectedItem.ToString();
                        subject_id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Retrieve Total Marks
                    query = "select total_marks from exam_template where subject_id = :subject_id";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("subject_id", OracleType.Int32).Value = subject_id;
                        total_marks = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Retrieve Class Section ID
                    query = "select class_section_id from class_sections where Class = :class and Section = :section";
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
                        dt.Columns.Add("Total Marks");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["Sr.No"] = i + 1;
                            dt.Rows[i]["Total Marks"] = total_marks;
                        }
                        dt.Columns["Sr.No"].SetOrdinal(0);     // Move Sr.No to first column
                        dt.Columns.Add("Obtained Marks");
                        datagrid_students.DataSource = dt;
                        datagrid_students.Columns["Obtained Marks"].ReadOnly = false;
                        datagrid_students.Columns["Sr.No"].ReadOnly = true;
                        datagrid_students.Columns["Student-ID"].ReadOnly = true;
                        datagrid_students.Columns["Name"].ReadOnly = true;
                        datagrid_students.Columns["Total Marks"].ReadOnly = true;
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

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            InsertMarksData();
        }

        private void InsertMarksData()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();

                    // Get subject_id
                    string subjectName = cmb_subject.SelectedItem.ToString();
                    int subject_id = 0;
                    string query = "SELECT subject_id FROM subjects WHERE subject_name = :subject_name";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("subject_name", OracleType.VarChar).Value = subjectName;
                        subject_id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Get exam_id using subject_id and exam_type
                    string examType = cmb_exam_type.SelectedItem.ToString();
                    int exam_id = 0;
                    query = "SELECT exam_id FROM exam_template WHERE subject_id = :subject_id AND exam_type = :exam_type";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("subject_id", OracleType.Int32).Value = subject_id;
                        cmd.Parameters.Add("exam_type", OracleType.VarChar).Value = examType;
                        exam_id = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Check All students marks entered
                    int allMarks_Marked = 0;
                    for (int i = 0; i < datagrid_students.Rows.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(datagrid_students.Rows[i].Cells["Obtained Marks"].Value.ToString()))
                        {
                            allMarks_Marked++;
                        }
                    }

                    // Inserting each Student Marks
                    if (allMarks_Marked == datagrid_students.Rows.Count)
                    {
                        double obtained_marks = 0;
                        string student_id = datagrid_students.Rows[0].Cells["Student-ID"].Value.ToString();

                        // Check if Marks Already Entered
                        if (!IsMarksAlreadyEntered(student_id, exam_id))
                        {
                            for (int i = 0; i < datagrid_students.Rows.Count; i++)
                            {
                                student_id = datagrid_students.Rows[i].Cells["Student-ID"].Value.ToString();
                                obtained_marks = Convert.ToDouble(datagrid_students.Rows[i].Cells["Obtained Marks"].Value);

                                // Finding Marks ID
                                int marks_id = 0;
                                query = "select count(*) from Student_Marks";
                                using (OracleCommand cmd = new OracleCommand(query, con))
                                {
                                    marks_id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                                }

                                //Marks Insert
                                query = "INSERT INTO student_marks (Marks_id,Student_id, Exam_id, Obtained_Marks) VALUES (:marks_id, :std_id, :exam_id, :obtained_marks)";
                                using (OracleCommand cmd = new OracleCommand(query, con))
                                {
                                    cmd.Parameters.Add("marks_id", OracleType.Int32).Value = marks_id;
                                    cmd.Parameters.Add("std_id", OracleType.VarChar).Value = student_id;
                                    cmd.Parameters.Add("exam_id", OracleType.Int32).Value = exam_id;
                                    cmd.Parameters.Add("obtained_marks", OracleType.Number).Value = obtained_marks;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Marks Data Saved Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearValues();
                        }
                        else
                        {
                            MessageBox.Show($"{examType} Marks already entered!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the Obtained Marks for all Students!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsMarksAlreadyEntered(string studentId, int examId)
        {
            using (OracleConnection con = new OracleConnection(ConnectionString))
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM student_marks WHERE student_id = :student_id AND exam_id = :exam_id";
                using (OracleCommand cmd = new OracleCommand(query, con))
                {
                    cmd.Parameters.Add("student_id", OracleType.VarChar).Value = studentId;
                    cmd.Parameters.Add("exam_id", OracleType.Int32).Value = examId;
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearValues();
        }
        public void ClearValues()
        {
            cmb_exam_type.SelectedIndex = -1;
            cmb_subject.SelectedIndex = -1;
            cmb_subject.Items.Clear();
            cmb_section.SelectedIndex = -1;
            cmb_class.SelectedIndex = -1;
            datagrid_students.Columns.Clear();
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
                cmb_subject.SelectedIndex = -1;
                cmb_subject.Items.Clear();
                cmb_section.Items.Clear();
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

        private void cmb_section_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
