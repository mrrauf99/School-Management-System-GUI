namespace School_Management_System
{
    partial class Students_Data
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_std_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_std_id = new System.Windows.Forms.TextBox();
            this.lbl_std_id = new System.Windows.Forms.Label();
            this.txt_std_address = new System.Windows.Forms.TextBox();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phonNo = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_std_pic = new System.Windows.Forms.Button();
            this.picbox_std = new System.Windows.Forms.PictureBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.cmb_section = new System.Windows.Forms.ComboBox();
            this.cmb_class = new System.Windows.Forms.ComboBox();
            this.txt_father_name = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_section = new System.Windows.Forms.Label();
            this.lbl_father_name = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagrid_student = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rdbtn_std_female = new System.Windows.Forms.RadioButton();
            this.rdbtn_std_male = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_std)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdbtn_std_female);
            this.panel2.Controls.Add(this.rdbtn_std_male);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.txt_std_name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_std_id);
            this.panel2.Controls.Add(this.lbl_std_id);
            this.panel2.Controls.Add(this.txt_std_address);
            this.panel2.Controls.Add(this.txt_phoneNo);
            this.panel2.Controls.Add(this.lbl_address);
            this.panel2.Controls.Add(this.lbl_phonNo);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_std_pic);
            this.panel2.Controls.Add(this.picbox_std);
            this.panel2.Controls.Add(this.cmb_status);
            this.panel2.Controls.Add(this.cmb_section);
            this.panel2.Controls.Add(this.cmb_class);
            this.panel2.Controls.Add(this.txt_father_name);
            this.panel2.Controls.Add(this.lbl_status);
            this.panel2.Controls.Add(this.lbl_gender);
            this.panel2.Controls.Add(this.lbl_section);
            this.panel2.Controls.Add(this.lbl_father_name);
            this.panel2.Controls.Add(this.lbl_class);
            this.panel2.Location = new System.Drawing.Point(26, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1495, 435);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_std_name
            // 
            this.txt_std_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_std_name.Location = new System.Drawing.Point(162, 35);
            this.txt_std_name.Multiline = true;
            this.txt_std_name.Name = "txt_std_name";
            this.txt_std_name.Size = new System.Drawing.Size(196, 34);
            this.txt_std_name.TabIndex = 0;
            this.txt_std_name.TextChanged += new System.EventHandler(this.txt_std_name_TextChanged);
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
            // txt_std_id
            // 
            this.txt_std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_std_id.Location = new System.Drawing.Point(578, 35);
            this.txt_std_id.Multiline = true;
            this.txt_std_id.Name = "txt_std_id";
            this.txt_std_id.Size = new System.Drawing.Size(196, 34);
            this.txt_std_id.TabIndex = 4;
            // 
            // lbl_std_id
            // 
            this.lbl_std_id.AutoSize = true;
            this.lbl_std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_std_id.Location = new System.Drawing.Point(450, 38);
            this.lbl_std_id.Name = "lbl_std_id";
            this.lbl_std_id.Size = new System.Drawing.Size(99, 22);
            this.lbl_std_id.TabIndex = 18;
            this.lbl_std_id.Text = "Student ID:";
            // 
            // txt_std_address
            // 
            this.txt_std_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_std_address.Location = new System.Drawing.Point(951, 27);
            this.txt_std_address.Multiline = true;
            this.txt_std_address.Name = "txt_std_address";
            this.txt_std_address.Size = new System.Drawing.Size(224, 66);
            this.txt_std_address.TabIndex = 7;
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_phoneNo.Location = new System.Drawing.Point(951, 180);
            this.txt_phoneNo.Multiline = true;
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(224, 34);
            this.txt_phoneNo.TabIndex = 9;
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
            this.lbl_phonNo.Location = new System.Drawing.Point(829, 188);
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
            this.btn_search.TabIndex = 14;
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
            this.btn_delete.TabIndex = 13;
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
            this.btn_update.TabIndex = 12;
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
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_std_pic
            // 
            this.btn_std_pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_std_pic.FlatAppearance.BorderSize = 0;
            this.btn_std_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_std_pic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_std_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_std_pic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_std_pic.ForeColor = System.Drawing.Color.White;
            this.btn_std_pic.Location = new System.Drawing.Point(1254, 235);
            this.btn_std_pic.Name = "btn_std_pic";
            this.btn_std_pic.Size = new System.Drawing.Size(194, 45);
            this.btn_std_pic.TabIndex = 10;
            this.btn_std_pic.Text = "Upload Picture";
            this.btn_std_pic.UseVisualStyleBackColor = false;
            this.btn_std_pic.Click += new System.EventHandler(this.btn_pic_Click);
            // 
            // picbox_std
            // 
            this.picbox_std.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_std.Location = new System.Drawing.Point(1254, 27);
            this.picbox_std.Name = "picbox_std";
            this.picbox_std.Size = new System.Drawing.Size(194, 182);
            this.picbox_std.TabIndex = 4;
            this.picbox_std.TabStop = false;
            this.picbox_std.Click += new System.EventHandler(this.picbox_std_Click);
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Enrolled",
            "Passed"});
            this.cmb_status.Location = new System.Drawing.Point(951, 118);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(224, 30);
            this.cmb_status.TabIndex = 8;
            // 
            // cmb_section
            // 
            this.cmb_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_section.FormattingEnabled = true;
            this.cmb_section.Location = new System.Drawing.Point(578, 184);
            this.cmb_section.Name = "cmb_section";
            this.cmb_section.Size = new System.Drawing.Size(196, 30);
            this.cmb_section.TabIndex = 6;
            this.cmb_section.SelectedIndexChanged += new System.EventHandler(this.cmb_section_SelectedIndexChanged);
            // 
            // cmb_class
            // 
            this.cmb_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_class.FormattingEnabled = true;
            this.cmb_class.Location = new System.Drawing.Point(578, 115);
            this.cmb_class.Name = "cmb_class";
            this.cmb_class.Size = new System.Drawing.Size(196, 30);
            this.cmb_class.TabIndex = 5;
            this.cmb_class.SelectedIndexChanged += new System.EventHandler(this.cmb_class_SelectedIndexChanged);
            // 
            // txt_father_name
            // 
            this.txt_father_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_father_name.Location = new System.Drawing.Point(163, 109);
            this.txt_father_name.Multiline = true;
            this.txt_father_name.Name = "txt_father_name";
            this.txt_father_name.Size = new System.Drawing.Size(196, 34);
            this.txt_father_name.TabIndex = 1;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_status.Location = new System.Drawing.Point(829, 121);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(66, 22);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Status:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_gender.Location = new System.Drawing.Point(23, 187);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(75, 22);
            this.lbl_gender.TabIndex = 0;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_section
            // 
            this.lbl_section.AutoSize = true;
            this.lbl_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_section.Location = new System.Drawing.Point(450, 187);
            this.lbl_section.Name = "lbl_section";
            this.lbl_section.Size = new System.Drawing.Size(75, 22);
            this.lbl_section.TabIndex = 0;
            this.lbl_section.Text = "Section:";
            // 
            // lbl_father_name
            // 
            this.lbl_father_name.AutoSize = true;
            this.lbl_father_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_father_name.Location = new System.Drawing.Point(23, 118);
            this.lbl_father_name.Name = "lbl_father_name";
            this.lbl_father_name.Size = new System.Drawing.Size(119, 22);
            this.lbl_father_name.TabIndex = 0;
            this.lbl_father_name.Text = "Father Name:";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_class.Location = new System.Drawing.Point(450, 118);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(60, 22);
            this.lbl_class.TabIndex = 0;
            this.lbl_class.Text = "Class:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.datagrid_student);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1495, 459);
            this.panel1.TabIndex = 0;
            // 
            // datagrid_student
            // 
            this.datagrid_student.AllowUserToAddRows = false;
            this.datagrid_student.AllowUserToDeleteRows = false;
            this.datagrid_student.AllowUserToResizeColumns = false;
            this.datagrid_student.AllowUserToResizeRows = false;
            this.datagrid_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_student.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagrid_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_student.EnableHeadersVisualStyles = false;
            this.datagrid_student.Location = new System.Drawing.Point(27, 64);
            this.datagrid_student.Name = "datagrid_student";
            this.datagrid_student.ReadOnly = true;
            this.datagrid_student.RowHeadersVisible = false;
            this.datagrid_student.RowHeadersWidth = 62;
            this.datagrid_student.RowTemplate.Height = 28;
            this.datagrid_student.Size = new System.Drawing.Size(1435, 364);
            this.datagrid_student.TabIndex = 16;
            this.datagrid_student.TabStop = false;
            this.datagrid_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Data";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rdbtn_std_female
            // 
            this.rdbtn_std_female.AutoSize = true;
            this.rdbtn_std_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdbtn_std_female.Location = new System.Drawing.Point(265, 185);
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
            this.rdbtn_std_male.Location = new System.Drawing.Point(163, 185);
            this.rdbtn_std_male.Name = "rdbtn_std_male";
            this.rdbtn_std_male.Size = new System.Drawing.Size(73, 26);
            this.rdbtn_std_male.TabIndex = 2;
            this.rdbtn_std_male.TabStop = true;
            this.rdbtn_std_male.Text = "Male";
            this.rdbtn_std_male.UseVisualStyleBackColor = true;
            // 
            // Students_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Students_Data";
            this.Size = new System.Drawing.Size(1547, 1000);
            this.Load += new System.EventHandler(this.Students_Data_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_std)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_std_pic;
        private System.Windows.Forms.PictureBox picbox_std;
        private System.Windows.Forms.ComboBox cmb_section;
        private System.Windows.Forms.ComboBox cmb_class;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_section;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagrid_student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_std_address;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phonNo;
        private System.Windows.Forms.TextBox txt_father_name;
        private System.Windows.Forms.Label lbl_father_name;
        private System.Windows.Forms.TextBox txt_std_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_std_id;
        private System.Windows.Forms.Label lbl_std_id;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.RadioButton rdbtn_std_female;
        private System.Windows.Forms.RadioButton rdbtn_std_male;
    }
}
