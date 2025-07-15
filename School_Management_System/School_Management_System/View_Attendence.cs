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

namespace School_Management_System
{
    public partial class View_Attendence : UserControl
    {
        public string ConnectionString = "Data Source=(DESCRIPTION=" +
        "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" +
        "(CONNECT_DATA=(SERVICE_NAME=XE)));" + "User id=SMS;Password=123;";
        DataTable dt;
        string Email;
        public View_Attendence()
        {
            InitializeComponent();
            datagrid_student.CellClick += Datagrid_student_CellClick;
        }

        private void Datagrid_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                datagrid_student.Rows[e.RowIndex].Selected = true;
            }
        }

        public View_Attendence(string e)
        {
            InitializeComponent();
            Email = e;
        }

        private void View_Attendence_Load(object sender, EventArgs e)
        {
            LoadAttendence();
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                List<string> SubjectList = new List<string>();
                string subject;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    subject = dt.Rows[i][0].ToString();

                    if (!SubjectList.Contains(subject))
                    {
                        SubjectList.Add(subject);
                        cmb_subject.Items.Add(subject);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAttendence()
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
                    query = "Select s.Subject_Name as \"Subject\", a.Attendence_Date as \"Attendence Date\", a.Status as \"Status\"" +
                                 "from Attendence a join Subjects s ON a.subject_id = s.subject_id  where Student_ID = :std_id order by a.attendence_date desc";
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("std_id", OracleType.VarChar).Value = student_id;
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            dt = new DataTable();
                            adapter.Fill(dt);
                            datagrid_student.DataSource = dt;
                            CalculateAttendence();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagrid_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmb_subject.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Subject!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string filter = $"[Subject] = '{cmb_subject.SelectedItem.ToString()}'";
            // [Subject] mean column Subject have value = cmb_subject.SelectedItem;
            DataView dv = new DataView(dt);
            dv.RowFilter = filter;
            datagrid_student.DataSource = dv;
            if (cmb_subject.SelectedItem.ToString() == "Computer Science")
            {
                lbl_attendence.Text = cmb_subject.SelectedItem.ToString() + " Attendence:";
                lbl_attendence.Location = new Point(550, 33);
            }
            else
            {
                lbl_attendence.Text = cmb_subject.SelectedItem.ToString() + " Attendence:";
                lbl_attendence.Location = new Point(640, 33);
            }
            CalculateAttendence();
        }

        private void lbl_attendence_score_Click(object sender, EventArgs e)
        {

        }

        private void CalculateAttendence()
        {
            int present = 0;
            for (int i = 0; i < datagrid_student.RowCount; i++)
            {
                if (datagrid_student.Rows[i].Cells["Status"].Value.ToString() == "Present")
                {
                    present++;
                }
            }
            double score = (Double)present / datagrid_student.RowCount * 100;
            lbl_attendence_score.Text = score.ToString("F1") + "%";
            // 2 mean show 2 digits after the decimal point
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        public void ReloadForm()
        {
            cmb_subject.SelectedIndex = -1;
            LoadAttendence();
            lbl_attendence.Text = "Overall Attendance:";
        }
    }
}
