using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace UI
{

    public partial class Main_Form : Form
    {
        private string tafelnr;

        private Werknemer huidigeGebruiker = new Werknemer();
        
        public Main_Form(Werknemer huidigGebruiker_in)
        {
            huidigeGebruiker = huidigGebruiker_in;

            InitializeComponent();
            lbl_naam.Text = huidigeGebruiker.Naam;
            lbl_functie.Text = Enum.GetName(typeof(Functie), huidigeGebruiker.Functie);
            Size = new Size(768, 1024);
        }

        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_Tafel_Click(object sender, EventArgs e)
        {
            this.Close();
            OverzichtRestaurant_Form overzichtform = new OverzichtRestaurant_Form(huidigeGebruiker);
            overzichtform.Show();
        }

        private void btn_LogUit_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Form login = new Login_Form();
            login.Show();
        }

        public void SetTafelNummer(int tafelnummer)
        {
            tafelnr = tafelnummer.ToString();
            btn_Tafel.Text = tafelnr;
        }

        public void updateTafelNR()
        {
            btn_Tafel.Text = tafelnr;
        }
    }
}
