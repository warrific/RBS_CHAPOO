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
        public OverzichtRestaurant_Form()
        {
            InitializeComponent();
            list_tafeloverzicht.View = View.Details;
            list_tafeloverzicht.HideSelection = false;

            Logica.Tafel items = new Logica.Tafel();

            List<Model.Tafel> lijst = new List<Model.Tafel>();
            lijst = items.GetAll();

            
            // neemt de radiobuttons invullingen uit StatusChange_Form en beeld ze uit in deze (OverzichtRestaurant_Form)
            //using (var statuschange_form = new StatusChange_Form())
            {
               
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
             }

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
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {

         //   StatusChange_Form statuschange_form = new StatusChange_Form();
            
         //   string status_tafel =statuschange_form.TafelStatus;
         //   string status_bestelling = statuschange_form.BestellingsStatus;
         //   string categorie = statuschange_form.Categorie;
         //   List<string> ro_lijst = new List<string>();
         //   ro_lijst.Add(status_tafel);
         //   ro_lijst.Add(status_bestelling);
         //   ro_lijst.Add(categorie);

            /*string[] rij = { status_tafel, status_bestelling, categorie };
            var listViewItem = new ListViewItem(rij);
            list_tafeloverzicht.Items.Add(listViewItem);*/
           
            
           // list_tafeloverzicht.Items.Add(listViewItem);
           // this.btn_Tafel1.Text  ="tafel_id 1";
            
           //// aangeven welke records bij de tafel behoren
           // foreach (ListViewItem item in list_tafeloverzicht.Items)
           // {
           //     if (item.Text == btn_Tafel1.Text)
           //     {
           //         item.BackColor = Color.LightGray;
           //         return;
           //     }
           // }

           // statussen updaten



        }
    }
}
