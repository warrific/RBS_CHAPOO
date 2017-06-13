using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(179, 179, 179);
            Size = new Size(768, 1024);
        }

        private void btn_LogUit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form obj_loginform = new Login_Form();
            obj_loginform.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
