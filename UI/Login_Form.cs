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
using Model;


namespace UI
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        //Voeg een a property toe in form1 om  een retrieve value from textbox:

        public string password
        {
            get { return txt_wachtwoord.Text; }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
                 string invoer_password = txt_wachtwoord.Text;

                 Logica.Werknemer l_werknemer = new Logica.Werknemer();

                 Model.Werknemer modelWerknemer;

                 if (l_werknemer.WachtwoordOngeldig(invoer_password, out modelWerknemer))
                 {
                     txt_wachtwoord.Text = "";
                     lbl_invalidmessage.Text = "password invalid";
                 }

                 else 
                 {
                     switch (modelWerknemer.Functie)
                     {
                         case Functie.Eigenaar:
                             this.Hide();
                             new Eigenaar_Form(modelWerknemer).Show();
                             break;
                         case Functie.Bediening:
                             this.Hide();
                             new OverzichtRestaurant_Form(modelWerknemer).Show();
                             break;
                         case Functie.Bar:
                             this.Hide();
                             new Orders_Form(modelWerknemer, Functie.Bar).Show();
                             break;
                         case Functie.Kok:
                             this.Hide();
                             new Orders_Form(modelWerknemer, Functie.Kok).Show();
                             break;
                         case Functie.Sommelier:
                             this.Hide();
                             new Orders_Form(modelWerknemer, Functie.Sommelier).Show();
                             break;

                         default:
                             break;
                     }   
                 
                 }
                     
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lbl_invalidmessage.Text = string.Empty;
            Button button = (Button)sender;
            txt_wachtwoord.Text += button.Text;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (this.txt_wachtwoord.Text.Length > 0)
            {
                txt_wachtwoord.Text = txt_wachtwoord.Text.Remove(this.txt_wachtwoord.Text.Length - 1);
            }
        }

    }
}
