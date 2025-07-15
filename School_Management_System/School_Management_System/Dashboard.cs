using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Dashboard : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";

        public Dashboard()
        {
            InitializeComponent();
            datagrid_enrolled.DataBindingComplete += Datagrid_enrolled_DataBindingComplete;
        }

        private void Datagrid_enrolled_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (datagrid_enrolled.Columns.Count == 0)
            {
                return;
            }
            //Formatting Grid View
            datagrid_enrolled.Columns["Sr.No"].Width = 70;
            datagrid_enrolled.Columns["Sr.No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_enrolled.Columns["Phone-No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_enrolled.Columns["Student-ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_enrolled.Columns["Class"].Width = 60;
            datagrid_enrolled.Columns["Class"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_enrolled.Columns["Section"].Width = 60;
            datagrid_enrolled.Columns["Section"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_enrolled.Columns["Status"].Width = 90;
            datagrid_enrolled.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid_enrolled.Columns["Gender"].Width = 80;
            datagrid_enrolled.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountEnrollStudents();
            CountPassedStudents();
            CountTeachers();
            LoadEnrolledStudents();
        }

        private void CountEnrollStudents()
        {
            using (OracleConnection con = new OracleConnection(ConnectionString))
            {
                con.Open();
                string Query = "Select count(*) from students where status = 'Enrolled'";
                using (OracleCommand cmd = new OracleCommand(Query, con))
                {
                    int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                    lbl_enroll.Text = UserCount.ToString();
                }
            }
        }

        private void CountPassedStudents()
        {
            using (OracleConnection con = new OracleConnection(ConnectionString))
            {
                con.Open();
                string Query = "Select count(*) from students where status = 'Passed'";
                using (OracleCommand cmd = new OracleCommand(Query, con))
                {
                    int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                    lbl_passed.Text = UserCount.ToString();
                }
            }
        }

        private void CountTeachers()
        {
            using (OracleConnection con = new OracleConnection(ConnectionString))
            {
                con.Open();
                string Query = "Select count(*) from Teachers";
                using (OracleCommand cmd = new OracleCommand(Query, con))
                {
                    int UserCount = Convert.ToInt32(cmd.ExecuteScalar());
                    lbl_teachers.Text = UserCount.ToString();
                }
            }
        }

        private void LoadEnrolledStudents()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(ConnectionString))
                {
                    string query = "Select s.Student_ID as \"Student-ID\", s.Name as \"Name\", s.Father_Name as \"Father Name\", s.Gender as \"Gender\", s.Address as \"Address\", s.Phone_No as \"Phone-No\", cs.Class as \"Class\", cs.Section as \"Section\", s.Status as \"Status\" from students s join class_sections cs using (class_section_id) where Admission_Date = Trunc(SysDate) AND Status = 'Enrolled' order by student_id";
                    // Trunc(SysDate) remove time from date
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        DataTable dt = new DataTable();
                        OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                        // Fetch data from Oracle
                        adapter.Fill(dt);
                        // Stored data in table obj
                        dt.Columns.Add("Sr.No");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["Sr.No"] = i + 1;
                        }
                        dt.Columns["Sr.No"].SetOrdinal(0);  // Move Sr.No to first column
                        datagrid_enrolled.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagrid_enrolled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ReloadForm()
        {
            CountEnrollStudents();
            CountPassedStudents();
            CountTeachers();
            LoadEnrolledStudents();
        }

        private void lbl_enroll_Click(object sender, EventArgs e)
        {

        }
    }
}
