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
    public partial class View_Marks : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        DataTable dt;
        string Email;
        public View_Marks()
        {
            InitializeComponent();
        }

        public View_Marks(string e)
        {
            InitializeComponent();
            Email = e;
            datagrid_subject_marks.CellClick += Datagrid_student_CellClick;
            this.Load += View_Marks_Load;
        }

        private void View_Marks_Load(object sender, EventArgs e)
        {
            LoadStudentMarks();
        }

        private void Datagrid_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                datagrid_subject_marks.Rows[e.RowIndex].Selected = true;
            }
        }

        private void datagrid_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadStudentMarks()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    con.Open();
                    string student_id = "";
                    // Finding Student ID
                    string query = "Select student_id from students where Email = :email";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("email", OracleType.VarChar).Value = Email;
                        student_id = cmd.ExecuteScalar().ToString();
                    }
                    query = "Select s.Subject_Name as \"Subject Name\", et.Exam_Type as \"Exam type\", et.Total_Marks as \"Total Marks\", sm.Obtained_Marks as \"Obtained Marks\" from Student_Marks sm  join exam_template et on sm.exam_id = et.exam_id join subjects s on et.subject_id = s.subject_id where student_id = :std_id";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("std_id", OracleType.VarChar).Value = student_id;
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            dt = new DataTable();
                            adapter.Fill(dt);
                            datagrid_subject_marks.DataSource = dt;
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
