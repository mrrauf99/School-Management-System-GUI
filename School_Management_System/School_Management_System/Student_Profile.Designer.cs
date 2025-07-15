namespace School_Management_System
{
    partial class Student_Profile
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
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_section = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_father_name = new System.Windows.Forms.Label();
            this.lbl_section = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_father_name = new System.Windows.Forms.TextBox();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.lbl_phonNo = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_phoneNo = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_std_id = new System.Windows.Forms.Label();
            this.txt_std_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_std_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_gender
            // 
            this.txt_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_gender.Location = new System.Drawing.Point(246, 325);
            this.txt_gender.Multiline = true;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(258, 34);
            this.txt_gender.TabIndex = 26;
            // 
            // txt_section
            // 
            this.txt_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_section.Location = new System.Drawing.Point(245, 607);
            this.txt_section.Multiline = true;
            this.txt_section.Name = "txt_section";
            this.txt_section.Size = new System.Drawing.Size(259, 34);
            this.txt_section.TabIndex = 30;
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_class.Location = new System.Drawing.Point(245, 517);
            this.txt_class.Multiline = true;
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(259, 34);
            this.txt_class.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(81, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Profile";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_class.Location = new System.Drawing.Point(87, 520);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(60, 22);
            this.lbl_class.TabIndex = 25;
            this.lbl_class.Text = "Class:";
            // 
            // lbl_father_name
            // 
            this.lbl_father_name.AutoSize = true;
            this.lbl_father_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_father_name.Location = new System.Drawing.Point(87, 244);
            this.lbl_father_name.Name = "lbl_father_name";
            this.lbl_father_name.Size = new System.Drawing.Size(119, 22);
            this.lbl_father_name.TabIndex = 24;
            this.lbl_father_name.Text = "Father Name:";
            // 
            // lbl_section
            // 
            this.lbl_section.AutoSize = true;
            this.lbl_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_section.Location = new System.Drawing.Point(87, 610);
            this.lbl_section.Name = "lbl_section";
            this.lbl_section.Size = new System.Drawing.Size(75, 22);
            this.lbl_section.TabIndex = 21;
            this.lbl_section.Text = "Section:";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_gender.Location = new System.Drawing.Point(87, 328);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(75, 22);
            this.lbl_gender.TabIndex = 22;
            this.lbl_gender.Text = "Gender:";
            // 
            // txt_father_name
            // 
            this.txt_father_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_father_name.Location = new System.Drawing.Point(245, 241);
            this.txt_father_name.Multiline = true;
            this.txt_father_name.Name = "txt_father_name";
            this.txt_father_name.Size = new System.Drawing.Size(260, 34);
            this.txt_father_name.TabIndex = 26;
            this.txt_father_name.TextChanged += new System.EventHandler(this.txt_father_name_TextChanged);
            // 
            // picbox
            // 
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Location = new System.Drawing.Point(1138, 147);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(300, 300);
            this.picbox.TabIndex = 29;
            this.picbox.TabStop = false;
            this.picbox.Click += new System.EventHandler(this.picbox_std_Click);
            // 
            // lbl_phonNo
            // 
            this.lbl_phonNo.AutoSize = true;
            this.lbl_phonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_phonNo.Location = new System.Drawing.Point(88, 876);
            this.lbl_phonNo.Name = "lbl_phonNo";
            this.lbl_phonNo.Size = new System.Drawing.Size(95, 22);
            this.lbl_phonNo.TabIndex = 38;
            this.lbl_phonNo.Text = "Phone No:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_address.Location = new System.Drawing.Point(87, 714);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(81, 22);
            this.lbl_address.TabIndex = 37;
            this.lbl_address.Text = "Address:";
            // 
            // txt_phoneNo
            // 
            this.txt_phoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_phoneNo.Location = new System.Drawing.Point(246, 873);
            this.txt_phoneNo.Multiline = true;
            this.txt_phoneNo.Name = "txt_phoneNo";
            this.txt_phoneNo.Size = new System.Drawing.Size(259, 34);
            this.txt_phoneNo.TabIndex = 35;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_address.Location = new System.Drawing.Point(245, 701);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(259, 124);
            this.txt_address.TabIndex = 33;
            // 
            // lbl_std_id
            // 
            this.lbl_std_id.AutoSize = true;
            this.lbl_std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_std_id.Location = new System.Drawing.Point(87, 425);
            this.lbl_std_id.Name = "lbl_std_id";
            this.lbl_std_id.Size = new System.Drawing.Size(99, 22);
            this.lbl_std_id.TabIndex = 39;
            this.lbl_std_id.Text = "Student ID:";
            // 
            // txt_std_id
            // 
            this.txt_std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_std_id.Location = new System.Drawing.Point(245, 422);
            this.txt_std_id.Multiline = true;
            this.txt_std_id.Name = "txt_std_id";
            this.txt_std_id.Size = new System.Drawing.Size(259, 34);
            this.txt_std_id.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(87, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name:";
            // 
            // txt_std_name
            // 
            this.txt_std_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_std_name.Location = new System.Drawing.Point(245, 147);
            this.txt_std_name.Multiline = true;
            this.txt_std_name.Name = "txt_std_name";
            this.txt_std_name.Size = new System.Drawing.Size(259, 34);
            this.txt_std_name.TabIndex = 20;
            // 
            // Student_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_std_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_section);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.txt_std_id);
            this.Controls.Add(this.lbl_std_id);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phoneNo);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_phonNo);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_father_name);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_section);
            this.Controls.Add(this.lbl_father_name);
            this.Controls.Add(this.lbl_class);
            this.Name = "Student_Profile";
            this.Size = new System.Drawing.Size(1558, 950);
            this.Load += new System.EventHandler(this.Student_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txt_section;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label lbl_father_name;
        private System.Windows.Forms.Label lbl_section;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox txt_father_name;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label lbl_phonNo;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_phoneNo;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_std_id;
        private System.Windows.Forms.TextBox txt_std_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_std_name;
    }
}
