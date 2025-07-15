namespace School_Management_System
{
    partial class Student_Main_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Main_Form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_welcome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_marks = new System.Windows.Forms.Button();
            this.btn_attendence = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_minimise = new System.Windows.Forms.Label();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.lbl_cancel = new System.Windows.Forms.Label();
            this.panel_usercontrol = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.txt_welcome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_marks);
            this.panel2.Controls.Add(this.btn_attendence);
            this.panel2.Controls.Add(this.btn_profile);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 1035);
            this.panel2.TabIndex = 2;
            // 
            // txt_welcome
            // 
            this.txt_welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.txt_welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_welcome.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_welcome.ForeColor = System.Drawing.Color.White;
            this.txt_welcome.Location = new System.Drawing.Point(16, 223);
            this.txt_welcome.Multiline = true;
            this.txt_welcome.Name = "txt_welcome";
            this.txt_welcome.Size = new System.Drawing.Size(330, 46);
            this.txt_welcome.TabIndex = 6;
            this.txt_welcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_welcome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 966);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logout";
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(31, 946);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(80, 67);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_marks
            // 
            this.btn_marks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_marks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_marks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_marks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marks.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_marks.ForeColor = System.Drawing.Color.White;
            this.btn_marks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_marks.Location = new System.Drawing.Point(48, 567);
            this.btn_marks.Name = "btn_marks";
            this.btn_marks.Size = new System.Drawing.Size(264, 70);
            this.btn_marks.TabIndex = 2;
            this.btn_marks.Text = "Academic Records";
            this.btn_marks.UseVisualStyleBackColor = true;
            this.btn_marks.Click += new System.EventHandler(this.btn_marks_Click);
            // 
            // btn_attendence
            // 
            this.btn_attendence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_attendence.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_attendence.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_attendence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_attendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendence.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_attendence.ForeColor = System.Drawing.Color.White;
            this.btn_attendence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendence.Location = new System.Drawing.Point(48, 448);
            this.btn_attendence.Name = "btn_attendence";
            this.btn_attendence.Size = new System.Drawing.Size(264, 70);
            this.btn_attendence.TabIndex = 1;
            this.btn_attendence.Text = "View Attendance";
            this.btn_attendence.UseVisualStyleBackColor = true;
            this.btn_attendence.Click += new System.EventHandler(this.btn_attendence_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(48, 334);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(264, 70);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_minimise);
            this.panel1.Controls.Add(this.lbl_sms);
            this.panel1.Controls.Add(this.lbl_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 45);
            this.panel1.TabIndex = 3;
            // 
            // lbl_minimise
            // 
            this.lbl_minimise.AutoSize = true;
            this.lbl_minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimise.Location = new System.Drawing.Point(1811, -2);
            this.lbl_minimise.Name = "lbl_minimise";
            this.lbl_minimise.Size = new System.Drawing.Size(28, 29);
            this.lbl_minimise.TabIndex = 2;
            this.lbl_minimise.Text = "_";
            this.lbl_minimise.Click += new System.EventHandler(this.lbl_minimise_Click);
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sms.Location = new System.Drawing.Point(12, 9);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(374, 24);
            this.lbl_sms.TabIndex = 0;
            this.lbl_sms.Text = "School Management System | Main Form";
            // 
            // lbl_cancel
            // 
            this.lbl_cancel.AutoSize = true;
            this.lbl_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancel.Location = new System.Drawing.Point(1881, 9);
            this.lbl_cancel.Name = "lbl_cancel";
            this.lbl_cancel.Size = new System.Drawing.Size(24, 24);
            this.lbl_cancel.TabIndex = 1;
            this.lbl_cancel.Text = "X";
            this.lbl_cancel.Click += new System.EventHandler(this.lbl_cancel_Click);
            // 
            // panel_usercontrol
            // 
            this.panel_usercontrol.BackColor = System.Drawing.Color.White;
            this.panel_usercontrol.Location = new System.Drawing.Point(362, 45);
            this.panel_usercontrol.Name = "panel_usercontrol";
            this.panel_usercontrol.Size = new System.Drawing.Size(1558, 1060);
            this.panel_usercontrol.TabIndex = 1;
            this.panel_usercontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_usercontrol_Paint);
            // 
            // Student_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel_usercontrol);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Main_Form";
            this.Text = "Student_Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_marks;
        private System.Windows.Forms.Button btn_attendence;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_minimise;
        private System.Windows.Forms.Label lbl_sms;
        private System.Windows.Forms.Label lbl_cancel;
        private System.Windows.Forms.Panel panel_usercontrol;
        private System.Windows.Forms.TextBox txt_welcome;
    }
}