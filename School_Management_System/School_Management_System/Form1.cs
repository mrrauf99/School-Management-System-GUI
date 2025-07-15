using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pan2.Width += 10;
            if (pan2.Width >= 780)
            {
                timer1.Stop();
                Login_Form login_Form = new Login_Form();
                login_Form.Show();
                this.Hide();
            }
        }

        private void pan1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
