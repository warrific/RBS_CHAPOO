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
            

        }

        private void Betaalwijze_pin_btn_Click(object sender, EventArgs e)
        {  
            Betaalwijze_out_lbl.Text = "Pin";
        }

        private void Betaalwijze_contant_btn_Click(object sender, EventArgs e)
        {
            Betaalwijze_out_lbl.Text = "Contant";
        }

        private void Betaalwijze_credit_btn_Click(object sender, EventArgs e)
        {
            Betaalwijze_out_lbl.Text = "Credit Card";
        }

        private void Fooi_btn_1_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "1";
        }

        private void Fooi_btn_2_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "2";
        }

        private void Fooi_btn_3_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "3";
        }

        private void Fooi_btn_4_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "4";
        }

        private void Fooi_btn_5_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "5";
        }

        private void Fooi_btn_6_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "6";
        }

        private void Fooi_btn_7_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "7";
        }

        private void Fooi_btn_8_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "8";
        }

        private void Fooi_btn_9_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "9";
        }

        private void Fooi_btn_backspace_Click(object sender, EventArgs e)
        {
            if (Fooi_textbox.TextLength > 0)
            {
                Fooi_textbox.Text = Fooi_textbox.Text.Substring(0, (Fooi_textbox.TextLength - 1));
            }
        }

        private void Fooi_btn_0_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += "0";
        }

        private void Fooi_btn_komma_Click(object sender, EventArgs e)
        {
            Fooi_textbox.Text += ",";
        }

        private void Opmerking_add_btn_Click(object sender, EventArgs e)
        {
            string opmerking = Opmerking_txtbox.Text;
        }
    }
}
