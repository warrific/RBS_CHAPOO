using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Logica;
using Model;


namespace UI
{
    public partial class Login_Form : Form
    {

        private string userName;
        private string userFunctie;
        public Login_Form()
        {
            InitializeComponent();

            Werknemers werknemer = new Werknemers();
            List<Model.Werknemer> lijst = new List<Model.Werknemer>();
            lijst = werknemer.make_list();

            Login login = new Login();

            foreach (Model.Werknemer list_item in lijst)
            {
                list_item.Id.ToString();
                list_item.Functie.ToString();
                list_item.Wachtwoord.ToString();

                for (int i = 0; i < lijst.Count(); i++)
                {
                    if (list_item.Id == i)
                    {
                        userName = list_item.Naam;
                        userFunctie = list_item.Functie.ToString();
                    }
                }
            }
        }
        
        public string password
        {
            get { return txt_wachtwoord.Text; }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string invoer_password = txt_wachtwoord.Text;
            Login login = new Login();
            Werknemers l_werknmr = new Werknemers();
            Model.Werknemer m_werknmr = new Model.Werknemer();
            List<Model.Werknemer> lijst = new List<Model.Werknemer>();
            lijst = l_werknmr.make_list();

            Main_Form obj_main = new Main_Form();
            
            //StatusChange_Form obj_statuschange = new StatusChange_Form();
            login.check_wachtwoord(invoer_password);

            foreach (Model.Werknemer list_item in lijst)
            {
                list_item.Id.ToString();
                list_item.Functie.ToString();

                

                if (invoer_password == list_item.Wachtwoord && list_item.Functie == Functie.Eigenaar)
                {
                    this.Hide();
                    new Eigenaar_Form().Show();
                }

                if (invoer_password == list_item.Wachtwoord && list_item.Functie == Functie.Bediening)
                {
                    this.Hide();
                    new OverzichtRestaurant_Form().Show();
                }

                if (invoer_password == list_item.Wachtwoord && list_item.Functie == Functie.Bar)
                {
                    this.Hide();
                    new Orders_Form(Functie.Bar).Show();
                }

                if (invoer_password == list_item.Wachtwoord && list_item.Functie == Functie.Kok)
                {
                    this.Hide();
                    new Orders_Form(Functie.Kok).Show();
                }

                if (invoer_password == list_item.Wachtwoord && list_item.Functie == Functie.Sommelier)
                {
                    this.Hide();
                    obj_main.Show();
                }
            }

            if (login.check_wachtwoord(invoer_password) == false)
            {
                MessageBox.Show("wachtwoord onjuist");
            }

        }

        //private void btn_Click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    txt_wachtwoord.Text += button.Text;
        //}

        private void btn_1_Click(object sender, EventArgs e)
        {
            string key_numpad_1 = "1";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            string key_numpad_2 = "2";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            string key_numpad_3 = "3";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            string key_numpad_4 = "4";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            string key_numpad_5 = "5";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            string key_numpad_6 = "6";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            string key_numpad_7 = "7";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            string key_numpad_8 = "8";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            string key_numpad_9 = "9";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_9;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            string key_numpad_0 = "0";
            this.txt_wachtwoord.Text = this.txt_wachtwoord.Text + key_numpad_0;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (this.txt_wachtwoord.Text.Length > 0)
            {
                this.txt_wachtwoord.Text = this.txt_wachtwoord.Text.Remove(this.txt_wachtwoord.Text.Length - 1);
            }
        }

    }
}
