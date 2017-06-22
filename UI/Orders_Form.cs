﻿using System;
using System.Windows.Forms;
using Logica;
using Model;
using System.Collections.Generic;

namespace UI
{
    public partial class Orders_Form : Main_Form
    {

        private string status_actueel = "";
        private string is_drinken = "";

        public Orders_Form(Model.Werknemer huidigeGebruiker_in, Model.Functie functie) : base(huidigeGebruiker_in)
        {
            InitializeComponent();

            // Labels van tafels weg
            lbl_tafel.Hide();
            btn_Tafel.Hide();

            // Functie check, dit wordt later gebruikt voor lijsten filteren
            if (functie == Model.Functie.Bar)
            {
                is_drinken = "";
            }
            if (functie == Model.Functie.Kok)
            {
                is_drinken = "";
            }

            // Datasource aanroepen
            data_source();

            // Kolomen aanmaken en de waarde uit de lijst binden (vanuit Bestelling_bar / keuken  lijst in Bestellingen)
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Width = 30;
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            data_items.Columns.Add(id);
            
            DataGridViewTextBoxColumn tafel_nr = new DataGridViewTextBoxColumn();
            tafel_nr.Width = 40;
            tafel_nr.DataPropertyName = "tafel_nummer";
            tafel_nr.HeaderText = "Tafel";
            data_items.Columns.Add(tafel_nr);

            DataGridViewTextBoxColumn aantal = new DataGridViewTextBoxColumn();
            aantal.Width = 40;
            aantal.DataPropertyName = "aantal";
            aantal.HeaderText = "Aantal";
            data_items.Columns.Add(aantal);

            DataGridViewTextBoxColumn order = new DataGridViewTextBoxColumn();
            order.Width = 300;
            order.DataPropertyName = "order";
            order.HeaderText = "Order";
            data_items.Columns.Add(order);
            
            DataGridViewTextBoxColumn opmerking = new DataGridViewTextBoxColumn();
            opmerking.Width = 160;
            opmerking.DataPropertyName = "opmerking";
            opmerking.HeaderText = "Opmerking";
            data_items.Columns.Add(opmerking);

            DataGridViewTextBoxColumn bediening = new DataGridViewTextBoxColumn();
            bediening.Width = 87;
            bediening.DataPropertyName = "bediening";
            bediening.HeaderText = "Bediening";
            data_items.Columns.Add(bediening);

            DataGridViewTextBoxColumn datum = new DataGridViewTextBoxColumn();
            datum.Width = 40;
            datum.DataPropertyName = "order_date";
            datum.HeaderText = "datum";
            data_items.Columns.Add(datum);

        }

        private void btn_gereed_Click(object sender, EventArgs e)
        {
                // Vind de geselecteerde rij, krijg het nummer van de rij, vind hiervan de waarde in de kolom "id" en het item id
                int order_id = int.Parse(Convert.ToString(data_items.Rows[(data_items.CurrentCell.RowIndex)].Cells[0].Value));
                string item_naam = (Convert.ToString(data_items.Rows[(data_items.CurrentCell.RowIndex)].Cells[3].Value));

                // Roep meld gereed aan en geef waardes door
                Bestellingen_Service bestellingen = new Bestellingen_Service();
                bestellingen.meld_gereed(order_id, item_naam);

                reload();
        }

        private void btn_herlaad_Click(object sender, EventArgs e)
        {
            // Reload het scherm met items
            reload();
        }

        private void btn_historie_Click(object sender, EventArgs e)
        {
            // Order geschiedenis inzien, text van knop wijzigen, filter wijzigen en btn gereed verbergen.
            if (btn_historie.Text == "Historie orders")
            {
                btn_historie.Text = "Actuele orders";
                status_actueel = "";
                lbl_historie.Text = "Order historie";
                btn_gereed.Hide();
            }
            // Terug naar orginele status
            else if (btn_historie.Text == "Actuele orders")
            {
                btn_historie.Text = "Historie orders";
                lbl_historie.Text = "Orders";
                status_actueel = "";
                btn_gereed.Show();
            }

            // Reload het scherm met items
            reload();
        }

        private void reload()
        {
            data_source();

            // Datagridview verversen met nieuwe waardes
            data_items.Update();
            data_items.Refresh();
        }

        private void data_source()
        {
            // Bestellingen ophalen en in lijst zetten (in methode)
            data_items.DataSource = make_listbestelling_weergave();

            // Niet automatisch kolomen genereren
            data_items.AutoGenerateColumns = false;
        }

        // TODO: Een lijst van maken
        public List<Bestelling_weergave> make_listbestelling_weergave()
        {
            Bestellingen_Service bestellingen = new Bestellingen_Service();
            List<Bestelling> bestellingenLijst = new List<Bestelling>();
            List<Bestelling_weergave> bestellingenLijstWeergave = new List<Bestelling_weergave>();

            // Volledige lijst opvragen
            bestellingenLijst = bestellingen.make_listbestelling(status_actueel);

            // Initialiseren
            int id = 0;
            int tafel_nummer = 0;
            int aantal = 0;
            string order = "";
            string opmerking = "";
            string bediening = "";
            Status status;
            string order_date = "";
            int i = 0;

            foreach (Bestelling list_item in bestellingenLijst)
            {
                // Loop voor de bestel items die in de bestelling staan
                for (int m = 0; m < list_item.Bestel_items.Count; m++)
                {
                    // Voor overzicht even los en niet in new Bestelling_weergave()
                    id = bestellingenLijst[i].Id;
                    tafel_nummer = list_item.Tafel.Id;
                    bediening = list_item.Werknemer.Naam;
                    aantal = list_item.Bestel_items[m].Aantal;
                    order = list_item.Bestel_items[m].MenuItem.Naam;
                    opmerking = list_item.Bestel_items[m].Opmerking;
                    status = list_item.Bestel_items[m].Status_item;
                    if (list_item.Opname != "")
                    {
                        order_date = list_item.Opname.Substring(9, 6);
                    }

                    bestellingenLijstWeergave.Add(new Bestelling_weergave(id, tafel_nummer, aantal, order, opmerking, bediening, status, order_date));
                }

                i++;
            }

            return bestellingenLijstWeergave;
        }
    }
}
