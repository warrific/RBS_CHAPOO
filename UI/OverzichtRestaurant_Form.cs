using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;

namespace UI
{
    public partial class OverzichtRestaurant_Form : UI.Main_Form
    {
        private bool status_actueel = true;
        private bool is_drinken = true;

        public OverzichtRestaurant_Form()
        {
            InitializeComponent();
            // list_tafeloverzicht.View = View.Details;
            // list_tafeloverzicht.HideSelection = false;

            // Logica.Tafel items = new Logica.Tafel();

            // List<Model.Tafel> lijst = new List<Model.Tafel>();
            //  lijst = items.GetAll();

            //// Datasource vermelden en aanroepen
            //data_source();

            // Kolomen aanmaken en de waarde uit de lijst binden (vanuit Bestelling_dranken lijst in Bestellingen)
            // TODO: in een loop zetten?
            DataGridViewTextBoxColumn dranklijst_id = new DataGridViewTextBoxColumn();
            dranklijst_id.Width = 80;
            dranklijst_id.DataPropertyName = "order_id";
            dranklijst_id.HeaderText = "order id";
            data_dranken.Columns.Add(dranklijst_id);

            DataGridViewTextBoxColumn dranklijst_tafel_nr = new DataGridViewTextBoxColumn();
            dranklijst_tafel_nr.Width = 80;
            dranklijst_tafel_nr.DataPropertyName = "tafel_nummer";
            dranklijst_tafel_nr.HeaderText = "tafel nummer";
            data_dranken.Columns.Add(dranklijst_tafel_nr);

            DataGridViewTextBoxColumn dranklijst_aantal = new DataGridViewTextBoxColumn();
            dranklijst_aantal.Width = 80;
            dranklijst_aantal.DataPropertyName = "status";
            dranklijst_aantal.HeaderText = "status bestelling";
            data_dranken.Columns.Add(dranklijst_aantal);

            //////////////////////////////////////////////////////////////////////////////////

            ////Statussen Keukenlijst
            //DataGridViewTextBoxColumn keukenlijst_id = new DataGridViewTextBoxColumn();
            //keukenlijst_id.Width = 10;
            //keukenlijst_id.DataPropertyName = "id";
            //keukenlijst_id.HeaderText = "status tafel";
            //data_dranken.Columns.Add(keukenlijst_id);

            //DataGridViewTextBoxColumn keukenlijst_tafel_nr = new DataGridViewTextBoxColumn();
            //keukenlijst_tafel_nr.Width = 20;
            //keukenlijst_tafel_nr.DataPropertyName = "tafel_nummer";
            //keukenlijst_tafel_nr.HeaderText = "tafel nummer";
            //data_dranken.Columns.Add(keukenlijst_tafel_nr);

            //DataGridViewTextBoxColumn keukenlijst_aantal = new DataGridViewTextBoxColumn();
            //keukenlijst_aantal.Width = 20;
            //keukenlijst_aantal.DataPropertyName = "Status";
            //keukenlijst_aantal.HeaderText = "status bestelling";
            //data_dranken.Columns.Add(keukenlijst_aantal);
        }

        //
        public void Verander_TafelStatus()
        {
            int order_id = 0;
            int item_id = 0;
            Bestellingen bestellingen = new Bestellingen();
            bestellingen.meld_gereed(order_id, item_id);
            {
                //lbl_tafel1.Text = Status_tafel.Bezet;

            }
        }

        // neemt de radiobuttons invullingen uit StatusChange_Form en beeld ze uit in deze (OverzichtRestaurant_Form)
        //using (var statuschange_form = new StatusChange_Form())
        // {

        //  statuschange_form.ShowDialog();

        // int [] tafelid = new int[10];
        // for (int index = 0; tafelid[index] < 10; index++)
        // {

        //       string status_tafel = statuschange_form.TafelStatus;
        //      string status_bestelling = statuschange_form.BestellingsStatus;
        //      string categorie = statuschange_form.Categorie;
        //       List<string> ro_lijst = new List<string>();
        //       ro_lijst.Add(status_tafel);
        //       ro_lijst.Add(status_bestelling);
        //       ro_lijst.Add(categorie);

        //       string[] rij = { status_tafel, status_bestelling, categorie };
        //       var listViewItem = new ListViewItem(rij);
        //        list_tafeloverzicht.Items.Add(listViewItem);

        // foreach (string lijst_deel in ro_lijst)
        // {
        //     ListViewItem tafelstatus = new ListViewItem(lijst_deel.TafelStatus);
        //     ListViewItem bestellingsstatus= new ListViewItem(lijst_deel.BestellingsStatus);
        //     ListViewItem bestellingscategorie = new ListViewItem(lijst_deel.Categorie);
        //     list_tafeloverzicht.Items.Add(tafelstatus);
        //     list_tafeloverzicht.Items.Add(bestellingsstatus);
        //     list_tafeloverzicht.Items.Add(bestellingscategorie);

        // }
        // }
        //  }

        //foreach (Model.Tafel list_item in lijst)
        // {
        //    ListViewItem tafel_id = new ListViewItem(list_item.Id.ToString());
        //    ListViewItem tafelstatus = new ListViewItem(list_item.Status.ToString());
        //ListViewItem bestelling_id = new ListViewItem(list_item.bestelling_id.ToString());
        //ListViewItem bestellingsstatus = new ListViewItem(list_item.bestellingsstatus.ToString());

        //    list_tafeloverzicht.Items.Add(tafel_id);
        //    list_tafeloverzicht.Items.Add(tafelstatus);
        //list_overzicht.Items.Add(bestelling_id);
        // list_overzicht.Items.Add(bestellingsstatus);
        // }
        //}


        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            int tafelnummer = 1;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
           
           if(lbl_tafel1.Text == "Vrij")
           {
               lbl_tafel1.Text = "Bezet";
           }
            
            //string status_tafel =statuschange_form.TafelStatus;
            //string status_bestelling = statuschange_form.BestellingsStatus;
            //string categorie = statuschange_form.Categorie;
            //List<string> ro_lijst = new List<string>();
            //ro_lijst.Add(status_tafel);
            //ro_lijst.Add(status_bestelling);
            //ro_lijst.Add(categorie);

            //string[] rij = { status_tafel, status_bestelling, categorie };
            //var listViewItem = new ListViewItem(rij);
            //list_tafeloverzicht.Items.Add(listViewItem);


            //list_tafeloverzicht.Items.Add(listViewItem);
            //this.btn_Tafel1.Text  ="tafel_id 1";

            //// aangeven welke records bij de tafel behoren
          //  foreach (ListViewItem item in list_tafeloverzicht.Items)
          //  {
          //      if (item.Text == btn_Tafel1.Text)
          //      {
         //           item.BackColor = Color.LightGray;
         //           return;
         //       }
        //    }

            // statussen updaten

            reload();

        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            int tafelnummer = 2;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel2.Text == "Vrij")
            {
                lbl_tafel2.Text = "Bezet";
            }
            reload();
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            int tafelnummer = 3;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel3.Text == "Vrij")
            {
                lbl_tafel3.Text = "Bezet";
            }
            reload();
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            int tafelnummer = 4;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel4.Text == "Vrij")
            {
                lbl_tafel4.Text = "Bezet";
            }
            reload();
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            int tafelnummer = 5;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel5.Text == "Vrij")
            {
                lbl_tafel5.Text = "Bezet";
            }
            reload();
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            int tafelnummer = 6;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel6.Text == "Vrij")
            {
                lbl_tafel6.Text = "Bezet";
            }
            reload();
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            int tafelnummer = 7;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel7.Text == "Vrij")
            {
                lbl_tafel7.Text = "Bezet";
            }
            reload();
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            int tafelnummer = 8;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel8.Text == "Vrij")
            {
                lbl_tafel8.Text = "Bezet";
            }
            reload();
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            int tafelnummer = 9;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel9.Text == "Vrij")
            {
                lbl_tafel9.Text = "Bezet";
            }
            reload();
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            int tafelnummer = 10;
            btn_BestellingOpnemen_Click(sender, e, tafelnummer);
            if (lbl_tafel10.Text == "Vrij")
            {
                lbl_tafel10.Text = "Bezet";
            }
            reload();
        }

        private void reload()
        {
            //data_source();

            // Datagridview verversen met nieuwe waardes
            data_dranken.Update();
            data_dranken.Refresh();
        }

        private void btn_BestellingOpnemen_Click(object sender, EventArgs e, int tafel_nummer)
        {
            Logica.Tafel logica_tafel = new Logica.Tafel();
            logica_tafel.CheckTafelNr(tafel_nummer);

            if (logica_tafel.CheckTafelNr(tafel_nummer))
            {
                if (lbl_tafel1.Text == "Bezet" || lbl_tafel2.Text == "Bezet" || lbl_tafel3.Text == " Bezet" ||lbl_tafel4.Text == "Bezet" || lbl_tafel5.Text == "Bezet" || lbl_tafel6.Text == " Bezet" ||lbl_tafel7.Text == "Bezet" || lbl_tafel8.Text == "Bezet" || lbl_tafel9.Text == " Bezet" || lbl_tafel10.Text == "Bezet" )
                {
                    this.Hide();
                    new Bediening_Form(tafel_nummer).Show();
                }
            }  
        }

        private void ShowVeranderStatus()
        {
           //string [] Tafel = new string [10];
           //Logica.Bestellingen l_bestellingen = new Logica.Bestellingen();
           //new Keuken_Form();
           //Keuken_Form
          
           //if (l_bestellingen.meld_gereed(int order_id, int item_id))
           //{ 
            
           //}


        }
    }
}

