using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.IO;
using Logica;
using Model;


namespace UI
{
    public partial class Betalen_Form : Main_Form
    {
        List<Button> Betaalwijze = new List<Button>();

        public Betalen_Form()
        {
            //int tafel_nummer = 6;
            //Bestellingen bestelling = new Bestellingen();
            //int order_id = bestelling.GetId(tafel_nummer);
            //Bestelitems logica = new Bestelitems();
            //List<BestelItem> itemsList = logica.GetBestellingItems(order_id);

            //foreach (BestelItem item in itemsList)
            //{
            //    ListViewItem LVI = new ListViewItem();
            //    LVI.SubItems.Add(item.aantal.ToString());
            //    LVI.SubItems.Add(item.menuItem.ToString());
            //    LVI.SubItems.Add(item.status.ToString());
            //    Rekening_lview.Items.Add(LVI);
            //}

            InitializeComponent();
            Betaalwijze.Add(Betaalwijze_contant_btn);
            Betaalwijze.Add(Betaalwijze_pin_btn);
            Betaalwijze.Add(Betaalwijze_credit_btn);
        }

        private void Betaalwijze_click(object sender, EventArgs e)
        {
            foreach (Button btn in Betaalwijze)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = System.Drawing.SystemColors.Control;
            }
            
            Button button = (Button)sender;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.LimeGreen;
            button.BackColor = System.Drawing.SystemColors.Control;
            Betaalwijze_out_lbl.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(button.Text.ToLower());
        }

        private void Fooi_Btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            //string FileName = string.Format(@"{0}Resources\WAV Sounds\dtmf-" + button.Text + ".wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            ////string soundPath = RunningPath + @"\Resources\WAV Sounds\dtmf-" +button.Text.ToLower()+".wav";

            //SoundPlayer SP = new SoundPlayer();
            //SP.Play();   

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
