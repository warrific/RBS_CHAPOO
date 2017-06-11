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

            data_dranken.DataSource = bestellingen.dranken_lijst;

            //bestellingen.make_listbestelling_dranken();

            /*
            foreach (Model.Bestelling list_item in bestellingen.bestellingen_lijst)
            {
                list_drankorders.GridLines = true;
                list_drankorders.AllowColumnReorder = true;
                list_drankorders.LabelEdit = true;
                list_drankorders.FullRowSelect = true;
                //list_drankorders.View = View.Details;


                for (int m = 0; m < list_item.bestel_items.Count; m++)
                {
                    ListViewItem itemnaam = new ListViewItem(list_item.bestel_items[m].item.naam.ToString());
                    ListViewItem aantal = new ListViewItem(list_item.bestel_items[m].aantal.ToString());
                    ListViewItem opmerking = new ListViewItem(list_item.bestel_items[m].opmerking.ToString());

                    list_drankorders.Items.Add(itemnaam);
                    list_drankorders.Items.Add(aantal);
                    list_drankorders.Items.Add(opmerking);
                }
                ListViewItem status = new ListViewItem(list_item.status.ToString());
                ListViewItem prijs = new ListViewItem(("€" + (list_item.totaalprijs)).ToString());
                ListViewItem betaalmethode = new ListViewItem(list_item.betaalmethode.ToString());
                ListViewItem fooi = new ListViewItem(list_item.fooi.ToString());
                ListViewItem werknemer = new ListViewItem(list_item.werknemer.naam.ToString());
                
                list_drankorders.Items.Add(prijs);
                list_drankorders.Items.Add(betaalmethode);
                list_drankorders.Items.Add(fooi);
                list_drankorders.Items.Add(werknemer);
            }
            */
        }
    }
}
