namespace School_Management_System
{
    partial class Login_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_minimise = new System.Windows.Forms.Label();
            this.lbl_sms = new System.Windows.Forms.Label();
            this.lbl_cancel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_pass = new System.Windows.Forms.PictureBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_sign_in = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_minimise);
            this.panel1.Controls.Add(this.lbl_sms);
            this.panel1.Controls.Add(this.lbl_cancel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 45);
            this.panel1.TabIndex = 0;
            // 
            // lbl_minimise
            // 
            this.lbl_minimise.AutoSize = true;
            this.lbl_minimise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minimise.Location = new System.Drawing.Point(917, -3);
            this.lbl_minimise.Name = "lbl_minimise";
            this.lbl_minimise.Size = new System.Drawing.Size(28, 29);
            this.lbl_minimise.TabIndex = 3;
            this.lbl_minimise.Text = "_";
            this.lbl_minimise.Click += new System.EventHandler(this.lbl_minimise_Click);
            // 
            // lbl_sms
            // 
            this.lbl_sms.AutoSize = true;
            this.lbl_sms.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sms.Location = new System.Drawing.Point(12, 9);
            this.lbl_sms.Name = "lbl_sms";
            this.lbl_sms.Size = new System.Drawing.Size(329, 24);
            this.lbl_sms.TabIndex = 0;
            this.lbl_sms.Text = "School Management System | Login";
            // 
            // lbl_cancel
            // 
            this.lbl_cancel.AutoSize = true;
            this.lbl_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancel.Location = new System.Drawing.Point(986, 9);
            this.lbl_cancel.Name = "lbl_cancel";
            this.lbl_cancel.Size = new System.Drawing.Size(24, 24);
            this.lbl_cancel.TabIndex = 1;
            this.lbl_cancel.Text = "X";
            this.lbl_cancel.Click += new System.EventHandler(this.lbl_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pic_pass);
            this.panel2.Controls.Add(this.btn_signup);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.txt_pass);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.lbl_pass);
            this.panel2.Controls.Add(this.lbl_email);
            this.panel2.Controls.Add(this.lbl_sign_in);
            this.panel2.Location = new System.Drawing.Point(259, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 619);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(287, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Forget password?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pic_pass
            // 
            this.pic_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_pass.Image = global::School_Management_System.Properties.Resources.hide;
            this.pic_pass.Location = new System.Drawing.Point(412, 296);
            this.pic_pass.Name = "pic_pass";
            this.pic_pass.Size = new System.Drawing.Size(34, 26);
            this.pic_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pass.TabIndex = 7;
            this.pic_pass.TabStop = false;
            this.pic_pass.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.Location = new System.Drawing.Point(304, 533);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(107, 38);
            this.btn_signup.TabIndex = 6;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label1.Location = new System.Drawing.Point(94, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(60, 438);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(391, 50);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(60, 289);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(391, 40);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(63, 174);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(388, 40);
            this.txt_email.TabIndex = 0;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(55, 248);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(114, 29);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(55, 133);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(69, 29);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // lbl_sign_in
            // 
            this.lbl_sign_in.AutoSize = true;
            this.lbl_sign_in.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lbl_sign_in.Location = new System.Drawing.Point(172, 42);
            this.lbl_sign_in.Name = "lbl_sign_in";
            this.lbl_sign_in.Size = new System.Drawing.Size(131, 43);
            this.lbl_sign_in.TabIndex = 2;
            this.lbl_sign_in.Text = "Sign In";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1022, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_sms;
        private System.Windows.Forms.Label lbl_cancel;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_sign_in;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_minimise;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_pass;
        private System.Windows.Forms.Label label2;
    }
}