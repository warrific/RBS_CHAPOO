using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;

namespace UI
{
    public partial class Main_Form : Form
    {
      Main_Form frm = new Main_Form();
        
        public Main_Form()
        {
            InitializeComponent();
            
            
           
            Size = new Size(768, 1024);
        }

        private void btn_LogUit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form obj_loginform = new Login_Form();
            obj_loginform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
         
        frm.Close();

    }
}
