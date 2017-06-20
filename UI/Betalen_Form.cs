using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logica;
using Model;
using System.Globalization;

namespace UI
{
    public partial class Betalen_Form : Main_Form
    {
        // Fields beschikbaar binnen betalenform. 
        private List<Button> Betaalwijze = new List<Button>(); //Nieuwe lijst van buttons aanmaken.
        private Rekeningen_Service logica; //Hier zit alle logica funtionaliteiten in
        private double totaalPrijs;
        private double fooi;
        private double subtotaal;
        private double btwBedrag;


        public Betalen_Form(Model.Werknemer huidigeGebruiker_in, int tafelNr) : base(huidigeGebruiker_in) // Betalen Form krijgt een werknemer mee en een tafelnummer de medewerker word vefvolgens naar de Base constructor gestuurd
        {
            logica = new Rekeningen_Service(tafelNr); // Hier maak je een nieuwe instantie van de class Rekeningen. Met in de constructor een tafelnummer.
            
            InitializeComponent(); //Laadt alle grafische user elementen
            Betaalwijze.Add(Betaalwijze_contant_btn); //We voegen een button toe aan de button list betaalwijze
            Betaalwijze.Add(Betaalwijze_pin_btn); 
            Betaalwijze.Add(Betaalwijze_credit_btn);
            
            foreach (RekeningItem item in logica.getRekening())// We loopen door de lijst met rekeningItems en tonen de items in de listview.
            {
                ListViewItem Lvi = new ListViewItem(item.Aantal.ToString());
                Lvi.SubItems.Add(item.Naam);
                Lvi.SubItems.Add(String.Format(CultureInfo.GetCultureInfo("fr-FR"), "{0:C}", item.Prijs * item.Aantal)); 
                Rekening_lview.Items.Add(Lvi); // we voegen de aangemaakte listviewItem in de listview control.
            }

            btn_Tafel.Text = tafelNr.ToString(); //Vullen van de Labels en button in de main Form
            lbl_naam.Text = huidigeGebruiker_in.Naam;
            lbl_functie.Text = Enum.GetName(typeof (Functie), huidigeGebruiker_in.Functie);

            btwBedrag = logica.GetBtw(); //We roepen de GetBtw methode en deze stoppen we in de variabele btwBedrag.
            subtotaal = logica.GetSubtotaalPrijs();
            totaalPrijs = subtotaal + btwBedrag; 
            Btw_out_lbl.Text = string.Format(CultureInfo.GetCultureInfo("fr-FR"), "{0:C}", btwBedrag);
            Totaal_out_lbl.Text = string.Format(CultureInfo.GetCultureInfo("fr-FR"), "{0:C}",totaalPrijs);
            Tafel_out_lbl.Text = tafelNr.ToString();
            Datum_out_lbl.Text = DateTime.Now.ToString();
            medewerker_out_lbl.Text = huidigeGebruiker_in.Naam;
        }

        private void Betaalwijze_click(object sender, EventArgs e)
        {
            foreach (Button btn in Betaalwijze)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = SystemColors.Control;
            }
            
            Button button = (Button)sender;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.LimeGreen;
            button.BackColor = SystemColors.Control;
            Betaalwijze_out_lbl.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(button.Text);
        }

        private void Fooi_Btn_Click(object sender, EventArgs e)
        {
            string opmaakString;
            Button button = (Button)sender;
            opmaakString = Fooi_textbox.Text + button.Text;
            Fooi_textbox.Text = Fooi_out_lbl.Text = opmaakString;
        }

        private void Fooi_btn_backspace_Click(object sender, EventArgs e)
        {
            if (Fooi_textbox.TextLength > 0)
            {
                Fooi_textbox.Text = Fooi_textbox.Text.Substring(0, (Fooi_textbox.TextLength - 1));
                Fooi_out_lbl.Text = Fooi_textbox.Text;
            }
        }

        private void Fooi_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Fooi_textbox.Text == "")
            {
                fooi = 0;
            }
            else
            {
                fooi = double.Parse(Fooi_textbox.Text);
            }
            totaalPrijs = logica.GetTotaalprijs(fooi, subtotaal, btwBedrag);
            Totaal_out_lbl.Text = string.Format(CultureInfo.GetCultureInfo("fr-FR"), "{0:C}", totaalPrijs);
        }

        public void btn_afrekenen_Click(object sender, EventArgs e)
        {
            Bestellingen_Service bestelling = new Bestellingen_Service();
            bestelling.RekenBestellingAf(new Bestelling(logica.OrderId, totaalPrijs, Betaalwijze_out_lbl.Text, Opmerking_txtbox.Text, fooi));
            this.Close();
        }
    }
}
