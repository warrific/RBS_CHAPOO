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
        private string tafelnr;

        private Model.Werknemer huidigeGebruiker = new Model.Werknemer();
        
        public Main_Form(Model.Werknemer huidigGebruiker_in)
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
            this.Hide();
            OverzichtRestaurant_Form overzichtform = new OverzichtRestaurant_Form(huidigeGebruiker);
            overzichtform.Show();
        }

        private void btn_LogUit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form loginform = new Login_Form();
            loginform.Show();
        }

        public void setTafelNR(int tafelnummer)
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
