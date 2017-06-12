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

            bestellingen.make_listbestelling_dranken();
            
            data_dranken.AutoGenerateColumns = false;
            data_dranken.DataSource = bestellingen.dranken_lijst;
            
            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Width = 30;
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            data_dranken.Columns.Add(id);
            
            DataGridViewTextBoxColumn tafel_nr = new DataGridViewTextBoxColumn();
            tafel_nr.Width = 50;
            tafel_nr.DataPropertyName = "tafel_nummer";
            tafel_nr.HeaderText = "tafel nummer";
            data_dranken.Columns.Add(tafel_nr);

            DataGridViewTextBoxColumn aantal = new DataGridViewTextBoxColumn();
            aantal.Width = 50;
            aantal.DataPropertyName = "aantal";
            aantal.HeaderText = "aantal";
            data_dranken.Columns.Add(aantal);

            DataGridViewTextBoxColumn order = new DataGridViewTextBoxColumn();
            order.Width = 200;
            order.DataPropertyName = "order";
            order.HeaderText = "order";
            data_dranken.Columns.Add(order);
            
            DataGridViewTextBoxColumn opmerking = new DataGridViewTextBoxColumn();
            opmerking.Width = 200;
            opmerking.DataPropertyName = "opmerking";
            opmerking.HeaderText = "opmerking";
            data_dranken.Columns.Add(opmerking);

            DataGridViewTextBoxColumn bediening = new DataGridViewTextBoxColumn();
            bediening.Width = 130;
            bediening.DataPropertyName = "bediening";
            bediening.HeaderText = "bediening";
            data_dranken.Columns.Add(bediening);
        }
    }
}
