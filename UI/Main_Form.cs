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
        protected string username;
        protected string userfunctie;
        
        public Main_Form(string username, string userfunctie)
        {
            InitializeComponent();
            lbl_naam.Text = username;
            lbl_functie.Text = userfunctie;
            Size = new Size(768, 1024);
        }


        private void btn_Tafel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OverzichtRestaurant_Form(username , userfunctie);
        }

        private void btn_LogUit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Form();
        }
    }
}
