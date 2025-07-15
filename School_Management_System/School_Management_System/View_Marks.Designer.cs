namespace School_Management_System
{
    partial class View_Marks
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
            this.datagrid_subject_marks = new System.Windows.Forms.DataGridView();
            this.lbl_marks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_subject_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_subject_marks
            // 
            this.datagrid_subject_marks.AllowUserToAddRows = false;
            this.datagrid_subject_marks.AllowUserToDeleteRows = false;
            this.datagrid_subject_marks.AllowUserToResizeColumns = false;
            this.datagrid_subject_marks.AllowUserToResizeRows = false;
            this.datagrid_subject_marks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_subject_marks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_subject_marks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_subject_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_subject_marks.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_subject_marks.EnableHeadersVisualStyles = false;
            this.datagrid_subject_marks.Location = new System.Drawing.Point(64, 126);
            this.datagrid_subject_marks.Name = "datagrid_subject_marks";
            this.datagrid_subject_marks.ReadOnly = true;
            this.datagrid_subject_marks.RowHeadersVisible = false;
            this.datagrid_subject_marks.RowHeadersWidth = 62;
            this.datagrid_subject_marks.RowTemplate.Height = 28;
            this.datagrid_subject_marks.Size = new System.Drawing.Size(1435, 779);
            this.datagrid_subject_marks.TabIndex = 5;
            this.datagrid_subject_marks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_student_CellContentClick);
            // 
            // lbl_marks
            // 
            this.lbl_marks.AutoSize = true;
            this.lbl_marks.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbl_marks.Location = new System.Drawing.Point(73, 53);
            this.lbl_marks.Name = "lbl_marks";
            this.lbl_marks.Size = new System.Drawing.Size(217, 39);
            this.lbl_marks.TabIndex = 4;
            this.lbl_marks.Text = "Subject Marks";
            // 
            // View_Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datagrid_subject_marks);
            this.Controls.Add(this.lbl_marks);
            this.Name = "View_Marks";
            this.Size = new System.Drawing.Size(1558, 950);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_subject_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_subject_marks;
        private System.Windows.Forms.Label lbl_marks;
    }
}
