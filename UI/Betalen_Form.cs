﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logica;
using Model;


namespace UI
{
    public partial class Betalen_Form : Main_Form
    {
        List<Button> Betaalwijze = new List<Button>();

        public Betalen_Form(int tafelNr)
        {
            
            double totaalPrijs = 0;
            Bestellingen bestelling = new Bestellingen();
            int order_id = bestelling.GetOrderId(tafelNr);
            Rekeningen logica = new Rekeningen();
            List<RekeningItem> rekening = logica.getRekening(order_id);
            
            foreach (RekeningItem item in rekening)
            {
                ListViewItem Lvi = new ListViewItem();
                Lvi.SubItems.Add(item.Aantal.ToString());
                Lvi.SubItems.Add(item.Naam);
                Lvi.SubItems.Add(item.Prijs.ToString());
                Rekening_lview.Items.Add(Lvi);
                totaalPrijs += item.Prijs;
            }

            InitializeComponent();
            Totaal_out_lbl.Text = totaalPrijs.ToString();
            Betaalwijze.Add(Betaalwijze_contant_btn);
            Betaalwijze.Add(Betaalwijze_pin_btn);
            Betaalwijze.Add(Betaalwijze_credit_btn);
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
            Betaalwijze_out_lbl.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(button.Text);
        }

        private void Fooi_Btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;  

            Fooi_textbox.Text += button.Text;
            Fooi_out_lbl.Text += button.Text;
        }

        private void Fooi_btn_backspace_Click(object sender, EventArgs e)
        {
            if (Fooi_textbox.TextLength > 0)
            {
                Fooi_textbox.Text = Fooi_textbox.Text.Substring(0, (Fooi_textbox.TextLength - 1));
                Fooi_out_lbl.Text = Fooi_textbox.Text;
            }
        }

        private void Opmerking_add_btn_Click(object sender, EventArgs e)
        {
            string opmerking = Opmerking_txtbox.Text;
        }
    }
}
