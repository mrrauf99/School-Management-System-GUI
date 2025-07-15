namespace School_Management_System
{
    partial class View_Attendence
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_student = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_subject = new System.Windows.Forms.ComboBox();
            this.lbl_attendence = new System.Windows.Forms.Label();
            this.lbl_attendence_score = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_student)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_student
            // 
            this.datagrid_student.AllowUserToAddRows = false;
            this.datagrid_student.AllowUserToDeleteRows = false;
            this.datagrid_student.AllowUserToResizeColumns = false;
            this.datagrid_student.AllowUserToResizeRows = false;
            this.datagrid_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_student.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_student.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_student.EnableHeadersVisualStyles = false;
            this.datagrid_student.Location = new System.Drawing.Point(64, 126);
            this.datagrid_student.Name = "datagrid_student";
            this.datagrid_student.ReadOnly = true;
            this.datagrid_student.RowHeadersVisible = false;
            this.datagrid_student.RowHeadersWidth = 62;
            this.datagrid_student.RowTemplate.Height = 28;
            this.datagrid_student.Size = new System.Drawing.Size(1435, 630);
            this.datagrid_student.TabIndex = 3;
            this.datagrid_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagrid_student_CellClick);
            this.datagrid_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_student_CellContentClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbl.Location = new System.Drawing.Point(73, 53);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(178, 39);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Attendance";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(836, 829);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 50);
            this.btn_search.TabIndex = 29;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 842);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Subject:";
            // 
            // cmb_subject
            // 
            this.cmb_subject.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_subject.FormattingEnabled = true;
            this.cmb_subject.Location = new System.Drawing.Point(379, 839);
            this.cmb_subject.Name = "cmb_subject";
            this.cmb_subject.Size = new System.Drawing.Size(222, 32);
            this.cmb_subject.TabIndex = 28;
            // 
            // lbl_attendence
            // 
            this.lbl_attendence.AutoSize = true;
            this.lbl_attendence.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attendence.Location = new System.Drawing.Point(1003, 53);
            this.lbl_attendence.Name = "lbl_attendence";
            this.lbl_attendence.Size = new System.Drawing.Size(298, 39);
            this.lbl_attendence.TabIndex = 31;
            this.lbl_attendence.Text = "Overall Attendance:";
            // 
            // lbl_attendence_score
            // 
            this.lbl_attendence_score.AutoSize = true;
            this.lbl_attendence_score.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attendence_score.Location = new System.Drawing.Point(1383, 53);
            this.lbl_attendence_score.Name = "lbl_attendence_score";
            this.lbl_attendence_score.Size = new System.Drawing.Size(34, 39);
            this.lbl_attendence_score.TabIndex = 33;
            this.lbl_attendence_score.Text = "0";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1163, 829);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 50);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // View_Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_attendence_score);
            this.Controls.Add(this.lbl_attendence);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_subject);
            this.Controls.Add(this.datagrid_student);
            this.Controls.Add(this.lbl);
            this.Name = "View_Attendence";
            this.Size = new System.Drawing.Size(1558, 950);
            this.Load += new System.EventHandler(this.View_Attendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_student;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_subject;
        private System.Windows.Forms.Label lbl_attendence;
        private System.Windows.Forms.Label lbl_attendence_score;
        private System.Windows.Forms.Button btn_clear;
    }
}
