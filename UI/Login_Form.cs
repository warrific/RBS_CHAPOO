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
        private string username;
        private string userfunctie;
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
                 
                 Model.Werknemer m_werknemer = l_werknemer.GetWerknemer(int.Parse(invoer_password));
                 username = m_werknemer.naam;
                 userfunctie = m_werknemer.functie.ToString();
                 Main_Form obj_main = new Main_Form(username , userfunctie);
                 
              
                     switch (m_werknemer.functie)
	                {
                        case Functie.Eigenaar:
                            this.Hide();
                            new Eigenaar_Form().Show();
                        break;
                         case Functie.Bediening:
                            this.Hide();
                            new Bediening_Form().Show();
                        break;
                        case Functie.Bar:
                            this.Hide();
                            new Bar_Form().Show();
                        break;
                        case Functie.Kok:
                            this.Hide();
                            new Keuken_Form().Show();
                        break;
                        case Functie.Sommelier:
                            this.Hide();
                            new Bar_Form().Show();
                        break;
                               
                         default:
                        break;
	                }   
                     
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txt_wachtwoord.Text += button.Text;
        }
        //private void btn_1_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_1 = "1";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_1;
        //}

        //private void btn_2_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_2 = "2";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_2;
        //}

        //private void btn_3_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_3 = "3";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_3;
        //}

        //private void btn_4_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_4 = "4";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_4;
        //}

        //private void btn_5_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_5 = "5";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_5;
        //}

        //private void btn_6_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_6 = "6";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_6;
        //}

        //private void btn_7_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_7 = "7";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_7;
        //}

        //private void btn_8_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_8 = "8";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_8;
        //}

        //private void btn_9_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_9 = "9";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_9;
        //}

        //private void btn_0_Click(object sender, EventArgs e)
        //{
        //    string key_numpad_0 = "0";
        //    txt_wachtwoord.Text = txt_wachtwoord.Text + key_numpad_0;
        //}

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (this.txt_wachtwoord.Text.Length > 0)
            {
                txt_wachtwoord.Text = txt_wachtwoord.Text.Remove(this.txt_wachtwoord.Text.Length - 1);
            }
        }

    }
}
