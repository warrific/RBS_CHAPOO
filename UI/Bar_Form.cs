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
        public Bar_Form()
        {
            InitializeComponent();

            Bestellingen bestellingen = new Bestellingen();

            // Bestellingen ophalen en in lijst zetten (in methode)
            bestellingen.make_listbestelling_dranken();
            
            // Niet automatisch kolomen genereren en de data bron vermelden
            data_dranken.AutoGenerateColumns = false;
            data_dranken.DataSource = bestellingen.dranken_lijst;
            
            // Rijen aanmaken en de waarde uit de lijst binden
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
            if (data_dranken.SelectedCells.Count > 0)
            {
                // Vind de geselecteerde rij, krijg het nummer van de rij, vind hiervan de waarde in de kolom "id"
                int order_id = int.Parse(Convert.ToString((data_dranken.Rows[(data_dranken.CurrentCell.RowIndex)]).Cells[0].Value));
                lbl_test.Text = order_id.ToString();
            }
        }
    }
}
