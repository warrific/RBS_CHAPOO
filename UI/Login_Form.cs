using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Logica;


namespace UI
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent(); 
        }


        private void btn_enter_Click(object sender, EventArgs e)
        {
            string invoer_password = txt_wachtwoord.Text;
            Login login = new Login();
            login.check_wachtwoord(invoer_password);
            
        }

        private void btn_1_Click(object sender, EventArgs e)
        {

        }
    }
}
