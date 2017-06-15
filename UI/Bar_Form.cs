using System;
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
    public partial class Bar_Form : UI.Main_Form
    {
        private bool status_actueel = true;
        private bool is_drinken = true;

        public Bar_Form()
        {
            InitializeComponent();

            // Datasource vermelden en aanroepen
            data_source();

            // Kolomen aanmaken en de waarde uit de lijst binden (vanuit Bestelling_dranken lijst in Bestellingen)
            // TODO: in een loop zetten?
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
            order.Width = 210;
            order.DataPropertyName = "order";
            order.HeaderText = "Order";
            data_items.Columns.Add(order);
            
            DataGridViewTextBoxColumn opmerking = new DataGridViewTextBoxColumn();
            opmerking.Width = 210;
            opmerking.DataPropertyName = "opmerking";
            opmerking.HeaderText = "Opmerking";
            data_items.Columns.Add(opmerking);

            DataGridViewTextBoxColumn bediening = new DataGridViewTextBoxColumn();
            bediening.Width = 127;
            bediening.DataPropertyName = "bediening";
            bediening.HeaderText = "Bediening";
            data_items.Columns.Add(bediening);
            
        }

        private void btn_gereed_Click(object sender, EventArgs e)
        {
                // Vind de geselecteerde rij, krijg het nummer van de rij, vind hiervan de waarde in de kolom "id" en het item id
                int order_id = int.Parse(Convert.ToString(data_items.Rows[(data_items.CurrentCell.RowIndex)].Cells[0].Value));
                string item_naam = (Convert.ToString(data_items.Rows[(data_items.CurrentCell.RowIndex)].Cells[3].Value));

                // Roep meld gereed aan en geef waardes door
                Bestellingen bestellingen = new Bestellingen();
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
            data_items.Update();
            data_items.Refresh();
        }

        private void data_source()
        {
            Bestellingen bestellingen = new Bestellingen();

            // Bestellingen ophalen en in lijst zetten (in methode)
            bestellingen.make_listbestelling_weergave(status_actueel, is_drinken);

            // Niet automatisch kolomen genereren en de data bron vermelden
            data_items.AutoGenerateColumns = false;
            data_items.DataSource = bestellingen.bar_lijst;
        }
    }
}
