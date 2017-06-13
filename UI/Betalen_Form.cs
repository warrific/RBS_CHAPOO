using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace UI
{
    public partial class Betalen_Form : Main_Form
    {
        public Betalen_Form()
        {
            InitializeComponent();
            Datagrid_items_bestelling.Columns["aantal"].DefaultCellStyle.BackColor = Color.SlateGray;
            Datagrid_items_bestelling.Columns["naam"].DefaultCellStyle.BackColor = Color.SlateGray;
            Datagrid_items_bestelling.Columns["prijs"].DefaultCellStyle.BackColor = Color.SlateGray;
        }

        private void Betaalwijze_pin_btn_Click(object sender, EventArgs e)
        {
            Betaalwijze_out_lbl.Text = "Pin";
        }

        private void Betaalwijze_contant_btn_Click(object sender, EventArgs e)
        {
            Betaalwijze_contant_btn.FlatAppearance.BorderColor = Color.Green;
            Betaalwijze_contant_btn.FlatAppearance.BorderSize = 1;
            Betaalwijze_credit_btn.FlatAppearance.BorderColor = Color.Transparent;
            Betaalwijze_pin_btn.FlatAppearance.BorderColor = Color.Transparent;
            Betaalwijze_out_lbl.Text = "Contant";
        }

        private void Betaalwijze_credit_btn_Click(object sender, EventArgs e)
        {
            Betaalwijze_out_lbl.Text = "Credit Card";
        }
    }
}
