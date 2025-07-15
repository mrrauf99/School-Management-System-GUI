namespace School_Management_System
{
    partial class Teachers_Data
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagrid_teacher = new System.Windows.Forms.DataGridView();
            this.lbl_teacher = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_salary = new System.Windows.Forms.NumericUpDown();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_teacher_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_degree = new System.Windows.Forms.TextBox();
            this.txt_teacher_id = new System.Windows.Forms.TextBox();
            this.lbl_teacher_id = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phonNo = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_teacher_pic = new System.Windows.Forms.Button();
            this.picbox_teacher = new System.Windows.Forms.PictureBox();
            this.rdbtn_std_female = new System.Windows.Forms.RadioButton();
            this.rdbtn_std_male = new System.Windows.Forms.RadioButton();
            this.txt_father_name = new System.Windows.Forms.TextBox();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.lbl_father_name = new System.Windows.Forms.Label();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_teacher)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.datagrid_teacher);
            this.panel1.Controls.Add(this.lbl_teacher);
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 459);
            this.panel1.TabIndex = 4;
            // 
            // datagrid_teacher
            // 
            this.datagrid_teacher.AllowUserToAddRows = false;
            this.datagrid_teacher.AllowUserToDeleteRows = false;
            this.datagrid_teacher.AllowUserToResizeColumns = false;
            this.datagrid_teacher.AllowUserToResizeRows = false;
            this.datagrid_teacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_teacher.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_teacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_teacher.EnableHeadersVisualStyles = false;
            this.datagrid_teacher.Location = new System.Drawing.Point(27, 64);
            this.datagrid_teacher.Name = "datagrid_teacher";
            this.datagrid_teacher.ReadOnly = true;
            this.datagrid_teacher.RowHeadersVisible = false;
            this.datagrid_teacher.RowHeadersWidth = 62;
            this.datagrid_teacher.RowTemplate.Height = 28;
            this.datagrid_teacher.Size = new System.Drawing.Size(1435, 364);
            this.datagrid_teacher.TabIndex = 2;
            this.datagrid_teacher.TabStop = false;
            this.datagrid_teacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_teacher_CellContentClick);
            // 
            // lbl_teacher
            // 
            this.lbl_teacher.AutoSize = true;
            this.lbl_teacher.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teacher.Location = new System.Drawing.Point(22, 22);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(173, 29);
            this.lbl_teacher.TabIndex = 0;
            this.lbl_teacher.Text = "Teacher\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.num_salary);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.txt_teacher_name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_degree);
            this.panel2.Controls.Add(this.txt_teacher_id);
            this.panel2.Controls.Add(this.lbl_teacher_id);
            this.panel2.Controls.Add(this.txt_address);
            this.panel2.Controls.Add(this.txt_phoneNo);
            this.panel2.Controls.Add(this.lbl_address);
            this.panel2.Controls.Add(this.lbl_phonNo);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_teacher_pic);
            this.panel2.Controls.Add(this.picbox_teacher);
            this.panel2.Controls.Add(this.rdbtn_std_female);
            this.panel2.Controls.Add(this.rdbtn_std_male);
            this.panel2.Controls.Add(this.txt_father_name);
            this.panel2.Controls.Add(this.lbl_gender);
            this.panel2.Controls.Add(this.lbl_salary);
            this.panel2.Controls.Add(this.lbl_father_name);
            this.panel2.Controls.Add(this.lbl_degree);
            this.panel2.Location = new System.Drawing.Point(26, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1495, 435);
            this.panel2.TabIndex = 1;
            // 
            // num_salary
            // 
            this.num_salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_salary.Location = new System.Drawing.Point(954, 120);
            this.num_salary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_salary.Name = "num_salary";
            this.num_salary.Size = new System.Drawing.Size(221, 28);
            this.num_salary.TabIndex = 8;
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
            this.btn_clear.Location = new System.Drawing.Point(1080, 329);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 50);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_teacher_name
            // 
            this.txt_teacher_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_teacher_name.Location = new System.Drawing.Point(162, 35);
            this.txt_teacher_name.Multiline = true;
            this.txt_teacher_name.Name = "txt_teacher_name";
            this.txt_teacher_name.Size = new System.Drawing.Size(196, 34);
            this.txt_teacher_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // txt_degree
            // 
            this.txt_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_degree.Location = new System.Drawing.Point(573, 113);
            this.txt_degree.Multiline = true;
            this.txt_degree.Name = "txt_degree";
            this.txt_degree.Size = new System.Drawing.Size(196, 34);
            this.txt_degree.TabIndex = 5;
            this.txt_degree.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_teacher_id
            // 
            this.txt_teacher_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_teacher_id.Location = new System.Drawing.Point(573, 35);
            this.txt_teacher_id.Multiline = true;
            this.txt_teacher_id.Name = "txt_teacher_id";
            this.txt_teacher_id.Size = new System.Drawing.Size(196, 34);
            this.txt_teacher_id.TabIndex = 4;
            // 
            // lbl_teacher_id
            // 
            this.lbl_teacher_id.AutoSize = true;
            this.lbl_teacher_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_teacher_id.Location = new System.Drawing.Point(445, 38);
            this.lbl_teacher_id.Name = "lbl_teacher_id";
            this.lbl_teacher_id.Size = new System.Drawing.Size(104, 22);
            this.lbl_teacher_id.TabIndex = 18;
            this.lbl_teacher_id.Text = "Teacher ID:";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_address.Location = new System.Drawing.Point(951, 27);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(224, 66);
            this.txt_address.TabIndex = 7;
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_phoneNo.Location = new System.Drawing.Point(573, 190);
            this.txt_phoneNo.Multiline = true;
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(196, 34);
            this.txt_phoneNo.TabIndex = 6;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_address.Location = new System.Drawing.Point(829, 38);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(81, 22);
            this.lbl_address.TabIndex = 13;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_phonNo
            // 
            this.lbl_phonNo.AutoSize = true;
            this.lbl_phonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_phonNo.Location = new System.Drawing.Point(445, 193);
            this.lbl_phonNo.Name = "lbl_phonNo";
            this.lbl_phonNo.Size = new System.Drawing.Size(95, 22);
            this.lbl_phonNo.TabIndex = 14;
            this.lbl_phonNo.Text = "Phone No:";
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
            this.btn_search.Location = new System.Drawing.Point(877, 329);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(150, 50);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(670, 329);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 50);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(468, 329);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 50);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(261, 329);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 50);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_teacher_pic
            // 
            this.btn_teacher_pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_teacher_pic.FlatAppearance.BorderSize = 0;
            this.btn_teacher_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_teacher_pic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_teacher_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher_pic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_pic.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_pic.Location = new System.Drawing.Point(1268, 235);
            this.btn_teacher_pic.Name = "btn_teacher_pic";
            this.btn_teacher_pic.Size = new System.Drawing.Size(194, 45);
            this.btn_teacher_pic.TabIndex = 9;
            this.btn_teacher_pic.Text = "Upload Picture";
            this.btn_teacher_pic.UseVisualStyleBackColor = false;
            this.btn_teacher_pic.Click += new System.EventHandler(this.btn_std_pic_Click);
            // 
            // picbox_teacher
            // 
            this.picbox_teacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_teacher.Location = new System.Drawing.Point(1268, 27);
            this.picbox_teacher.Name = "picbox_teacher";
            this.picbox_teacher.Size = new System.Drawing.Size(194, 182);
            this.picbox_teacher.TabIndex = 4;
            this.picbox_teacher.TabStop = false;
            this.picbox_teacher.Click += new System.EventHandler(this.picbox_teacher_Click);
            // 
            // rdbtn_std_female
            // 
            this.rdbtn_std_female.AutoSize = true;
            this.rdbtn_std_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdbtn_std_female.Location = new System.Drawing.Point(264, 191);
            this.rdbtn_std_female.Name = "rdbtn_std_female";
            this.rdbtn_std_female.Size = new System.Drawing.Size(94, 26);
            this.rdbtn_std_female.TabIndex = 3;
            this.rdbtn_std_female.TabStop = true;
            this.rdbtn_std_female.Text = "Female";
            this.rdbtn_std_female.UseVisualStyleBackColor = true;
            // 
            // rdbtn_std_male
            // 
            this.rdbtn_std_male.AutoSize = true;
            this.rdbtn_std_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdbtn_std_male.Location = new System.Drawing.Point(162, 191);
            this.rdbtn_std_male.Name = "rdbtn_std_male";
            this.rdbtn_std_male.Size = new System.Drawing.Size(73, 26);
            this.rdbtn_std_male.TabIndex = 2;
            this.rdbtn_std_male.TabStop = true;
            this.rdbtn_std_male.Text = "Male";
            this.rdbtn_std_male.UseVisualStyleBackColor = true;
            // 
            // txt_father_name
            // 
            this.txt_father_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_father_name.Location = new System.Drawing.Point(163, 107);
            this.txt_father_name.Multiline = true;
            this.txt_father_name.Name = "txt_father_name";
            this.txt_father_name.Size = new System.Drawing.Size(196, 34);
            this.txt_father_name.TabIndex = 1;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_gender.Location = new System.Drawing.Point(23, 193);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(75, 22);
            this.lbl_gender.TabIndex = 0;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_salary.Location = new System.Drawing.Point(829, 122);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(66, 22);
            this.lbl_salary.TabIndex = 0;
            this.lbl_salary.Text = "Salary:";
            // 
            // lbl_father_name
            // 
            this.lbl_father_name.AutoSize = true;
            this.lbl_father_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_father_name.Location = new System.Drawing.Point(23, 116);
            this.lbl_father_name.Name = "lbl_father_name";
            this.lbl_father_name.Size = new System.Drawing.Size(119, 22);
            this.lbl_father_name.TabIndex = 0;
            this.lbl_father_name.Text = "Father Name:";
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_degree.Location = new System.Drawing.Point(445, 122);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(74, 22);
            this.lbl_degree.TabIndex = 0;
            this.lbl_degree.Text = "Degree:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Teachers_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Teachers_Data";
            this.Size = new System.Drawing.Size(1547, 1000);
            this.Load += new System.EventHandler(this.Teachers_Data_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_teacher)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_teacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_teacher;
        private System.Windows.Forms.DataGridView datagrid_teacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_teacher_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_teacher_id;
        private System.Windows.Forms.Label lbl_teacher_id;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phonNo;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_teacher_pic;
        private System.Windows.Forms.PictureBox picbox_teacher;
        private System.Windows.Forms.RadioButton rdbtn_std_female;
        private System.Windows.Forms.RadioButton rdbtn_std_male;
        private System.Windows.Forms.TextBox txt_father_name;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_father_name;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.TextBox txt_degree;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.NumericUpDown num_salary;
        private System.Windows.Forms.TextBox txt_phoneNo;
    }
}
