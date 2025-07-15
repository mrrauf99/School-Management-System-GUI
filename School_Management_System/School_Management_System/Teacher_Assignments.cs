using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Teacher_Assignments : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        DataTable dt;
        public Teacher_Assignments()
        {
            InitializeComponent();
            datagrid_assign_teachers.CellClick += Datagrid_teacher_CellClick;
        }

        private void Datagrid_teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Header Row index is -1
            if (e.RowIndex >= 0)
            {
                datagrid_assign_teachers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void Teacher_Assignments_Load(object sender, EventArgs e)
        {
            LoadTeachers_Id();
            LoadClasses();
            LoadSubjects();
            LoadTeachersData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearCombo_Box();
        }

        private void ClearCombo_Box()
        {
            cmb_teacher_id.SelectedIndex = -1;
            cmb_section.SelectedIndex = -1;
            cmb_class.SelectedIndex = -1;
            cmb_subject.SelectedIndex = -1;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_teacher_id.SelectedIndex == -1 || cmb_class.SelectedIndex == -1 || cmb_section.SelectedIndex == -1 || cmb_subject.SelectedIndex == -1)
            {
                return;
            }
            try
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
                    int subject_id = 0;

                    // Finding Subject ID
                    query = "Select subject_id from subjects where Subject_Name = :subject_name";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("subject_name", OracleType.VarChar).Value = cmb_subject.SelectedItem.ToString();
                        subject_id = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    if (!IsAssignmentExist(class_section_id, subject_id))
                    {
                        int assignment_id = 0;

                        // Finding Teacher Assignment ID
                        query = "Select count(*) from Teacher_Assignments";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            assignment_id = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                        }

                        // Insert data into Teachers_Assignments Table
                        query = "Insert into Teacher_Assignments (Assignment_id, Teacher_id, Class_section_id, Subject_id) Values (:assignment_id, :teacher_id, :class_section_id, :subject_id)";
                        using (OracleCommand cmd = new OracleCommand(query, con))
                        {
                            cmd.Parameters.Add("assignment_id", OracleType.Int32).Value = assignment_id;
                            cmd.Parameters.Add("teacher_id", OracleType.VarChar).Value = cmb_teacher_id.SelectedItem.ToString();
                            cmd.Parameters.Add("class_section_id", OracleType.Int32).Value = class_section_id;
                            cmd.Parameters.Add("subject_id", OracleType.Int32).Value = subject_id;
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Subject Assigned to Teacher Successfully.!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTeachersData();
                    }
                    else
                    {
                        MessageBox.Show("Subject already assigned to this class and section.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void LoadTeachers_Id()
        {
            cmb_teacher_id.Items.Clear();
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string query = "Select Teacher_id From Teachers";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmb_teacher_id.Items.Add(reader[0].ToString());
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

        private void LoadSubjects()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string query = "Select Subject_Name From Subjects";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmb_subject.Items.Add(reader[0].ToString());
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

        private void LoadTeachersData()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT t.Teacher_id as \"Teacher-ID\", t.Name as \"Name\", t.Father_name as \"Father Name\", cs.Class as \"Class\", cs.Section as \"Section\", s.Subject_Name as \"Subject Name\" from Teachers t JOIN  teacher_assignments ta on t.Teacher_id = ta.Teacher_id  JOIN  Class_sections cs on ta.Class_section_id = cs.Class_section_id  JOIN   Subjects s on ta.subject_id = s.subject_id";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            dt = new DataTable();
                            adapter.Fill(dt);
                            dt.Columns.Add("Sr.No");
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                dt.Rows[i]["Sr.No"] = i + 1;
                            }
                            dt.Columns["Sr.No"].SetOrdinal(0);
                            datagrid_assign_teachers.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagrid_assign_teachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool IsAssignmentExist(int class_section_id, int subject_id)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string query = "select count(*) from teacher_assignments where Class_section_id = :class_section_id AND Subject_id = :subject_id";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("subject_id", OracleType.Int32).Value = subject_id;
                        cmd.Parameters.Add("class_section_id", OracleType.Int32).Value = class_section_id;
                        int Count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (Count > 0)
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

        public void FormReload()
        {
            LoadTeachersData();
            LoadTeachers_Id();
        }
    }
}
