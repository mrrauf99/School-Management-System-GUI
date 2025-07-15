namespace School_Management_System
{
    partial class Admin_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_minimise = new System.Windows.Forms.Label();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.lbl_cancel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_assignment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_add_teacher = new System.Windows.Forms.Button();
            this.btn_add_std = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.lbl_welcom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.btn_assignment);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_add_teacher);
            this.panel2.Controls.Add(this.btn_add_std);
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.Controls.Add(this.lbl_welcom);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 1035);
            this.panel2.TabIndex = 2;
            // 
            // btn_assignment
            // 
            this.btn_assignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_assignment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_assignment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_assignment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_assignment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_assignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assignment.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_assignment.ForeColor = System.Drawing.Color.White;
            this.btn_assignment.Location = new System.Drawing.Point(48, 684);
            this.btn_assignment.Name = "btn_assignment";
            this.btn_assignment.Size = new System.Drawing.Size(264, 70);
            this.btn_assignment.TabIndex = 3;
            this.btn_assignment.Text = "Teacher Assignments";
            this.btn_assignment.UseVisualStyleBackColor = false;
            this.btn_assignment.Click += new System.EventHandler(this.btn_assignments_Click);
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
            this.btn_logout.TabIndex = 4;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_add_teacher
            // 
            this.btn_add_teacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_teacher.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_add_teacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add_teacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_teacher.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_add_teacher.ForeColor = System.Drawing.Color.White;
            this.btn_add_teacher.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_teacher.Image")));
            this.btn_add_teacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_teacher.Location = new System.Drawing.Point(48, 567);
            this.btn_add_teacher.Name = "btn_add_teacher";
            this.btn_add_teacher.Size = new System.Drawing.Size(264, 70);
            this.btn_add_teacher.TabIndex = 2;
            this.btn_add_teacher.Text = "Add Teacher";
            this.btn_add_teacher.UseVisualStyleBackColor = true;
            this.btn_add_teacher.Click += new System.EventHandler(this.btn_add_teacher_Click);
            // 
            // btn_add_std
            // 
            this.btn_add_std.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_std.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_add_std.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add_std.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add_std.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_std.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_add_std.ForeColor = System.Drawing.Color.White;
            this.btn_add_std.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_std.Image")));
            this.btn_add_std.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_std.Location = new System.Drawing.Point(48, 448);
            this.btn_add_std.Name = "btn_add_std";
            this.btn_add_std.Size = new System.Drawing.Size(264, 70);
            this.btn_add_std.TabIndex = 1;
            this.btn_add_std.Text = "Add Student";
            this.btn_add_std.UseVisualStyleBackColor = true;
            this.btn_add_std.Click += new System.EventHandler(this.btn_add_std_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.Image")));
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(48, 334);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(264, 70);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // lbl_welcom
            // 
            this.lbl_welcom.AutoSize = true;
            this.lbl_welcom.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbl_welcom.ForeColor = System.Drawing.Color.White;
            this.lbl_welcom.Location = new System.Drawing.Point(73, 218);
            this.lbl_welcom.Name = "lbl_welcom";
            this.lbl_welcom.Size = new System.Drawing.Size(190, 29);
            this.lbl_welcom.TabIndex = 3;
            this.lbl_welcom.Text = "Welcome, Admin";
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
            // panel_form
            // 
            this.panel_form.Location = new System.Drawing.Point(361, 45);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(1559, 1035);
            this.panel_form.TabIndex = 3;
            this.panel_form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Admin_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_sms;
        private System.Windows.Forms.Label lbl_cancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_welcom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add_teacher;
        private System.Windows.Forms.Button btn_add_std;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Label lbl_minimise;
        private System.Windows.Forms.Button btn_assignment;
    }
}