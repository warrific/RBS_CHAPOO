﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logica;
using Model;

namespace UI
{
    public partial class Keuken_Form : UI.Main_Form
    {
        private bool status_actueel = true;
        private bool is_drinken = false;

        public Keuken_Form()
        {
            InitializeComponent();

            lbl_tafel.Hide();
            btn_Tafel.Hide();

            // Datasource vermelden en aanroepen
            data_source();

            // Kolomen aanmaken en de waarde uit de lijst binden (vanuit Bestelling_dranken lijst in Bestellingen)
            // TODO: in een loop zetten?
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Width = 30;
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            data_dranken.Columns.Add(id);
            
            DataGridViewTextBoxColumn tafel_nr = new DataGridViewTextBoxColumn();
            tafel_nr.Width = 50;
            tafel_nr.DataPropertyName = "tafel_nummer";
            tafel_nr.HeaderText = "Tafel nummer";
            data_dranken.Columns.Add(tafel_nr);

            DataGridViewTextBoxColumn aantal = new DataGridViewTextBoxColumn();
            aantal.Width = 50;
            aantal.DataPropertyName = "aantal";
            aantal.HeaderText = "Aantal";
            data_dranken.Columns.Add(aantal);

            DataGridViewTextBoxColumn order = new DataGridViewTextBoxColumn();
            order.Width = 200;
            order.DataPropertyName = "order";
            order.HeaderText = "Order";
            data_dranken.Columns.Add(order);
            
            DataGridViewTextBoxColumn opmerking = new DataGridViewTextBoxColumn();
            opmerking.Width = 200;
            opmerking.DataPropertyName = "opmerking";
            opmerking.HeaderText = "Opmerking";
            data_dranken.Columns.Add(opmerking);

            DataGridViewTextBoxColumn bediening = new DataGridViewTextBoxColumn();
            bediening.Width = 130;
            bediening.DataPropertyName = "bediening";
            bediening.HeaderText = "Bediening";
            data_dranken.Columns.Add(bediening);
            
        }

        private void btn_gereed_Click(object sender, EventArgs e)
        {
            // Als er een cell geselecteerd is
            if (data_dranken.SelectedCells.Count == 1)
            {
                // Vind de geselecteerde rij, krijg het nummer van de rij, vind hiervan de waarde in de kolom "id" en het item id
                int order_id = int.Parse(Convert.ToString((data_dranken.Rows[(data_dranken.CurrentCell.RowIndex)]).Cells[0].Value));
                int item_id = int.Parse(Convert.ToString((data_dranken.Rows[(data_dranken.CurrentCell.RowIndex)]).Cells[1].Value));

                // Roep meld gereed aan en geef waardes door
                Bestellingen bestellingen = new Bestellingen();
                bestellingen.meld_gereed(order_id, item_id);
            }
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
                status_actueel = false;
                lbl_historie.Text = "Order historie";
                btn_gereed.Hide();
            }
            // Terug naar orginele status
            else if (btn_historie.Text == "Actuele orders")
            {
                btn_historie.Text = "Historie orders";
                lbl_historie.Text = "Orders";
                status_actueel = true;
                btn_gereed.Show();
            }

            // Reload het scherm met items
            reload();
        }

        private void reload()
        {
            data_source();

            // Datagridview verversen met nieuwe waardes
            data_dranken.Update();
            data_dranken.Refresh();
        }

        private void data_source()
        {
            Bestellingen bestellingen = new Bestellingen();

            // Bestellingen ophalen en in lijst zetten (in methode)
            bestellingen.make_listbestelling_weergave(status_actueel, is_drinken);

            // Niet automatisch kolomen genereren en de data bron vermelden
            data_dranken.AutoGenerateColumns = false;
            data_dranken.DataSource = bestellingen.keuken_lijst;
        }
    }
}