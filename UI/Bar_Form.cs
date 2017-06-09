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

            /*
            MenuItems menuitems = new MenuItems();

            List<Model.MenuItem> lijst = new List<Model.MenuItem>();
            lijst = menuitems.make_list();

            foreach (Model.MenuItem list_item in lijst)
            {
                ListViewItem id = new ListViewItem(list_item.id.ToString());
                ListViewItem naam = new ListViewItem(list_item.naam.ToString());
                ListViewItem prijs = new ListViewItem(("€" + (list_item.prijs)).ToString());
                ListViewItem voorraad = new ListViewItem(list_item.voorraad.ToString());
                ListViewItem shortname = new ListViewItem(list_item.shortname.ToString());

                list_drankorders.Items.Add(id);
                list_drankorders.Items.Add(naam);
                list_drankorders.Items.Add(prijs);
                list_drankorders.Items.Add(voorraad);
                list_drankorders.Items.Add(shortname);
            }
            */

            MenuItems menuitems = new MenuItems();

            List<Model.Bestelling> lijst = new List<Model.Bestelling>();
            lijst = menuitems.make_listbestelling();

            foreach (Model.Bestelling list_item in lijst)
            {
                ListViewItem id = new ListViewItem(list_item.id.ToString());
                ListViewItem status = new ListViewItem(list_item.status.ToString());
                ListViewItem prijs = new ListViewItem(("€" + (list_item.totaalprijs)).ToString());
                ListViewItem betaalmethode = new ListViewItem(list_item.betaalmethode.ToString());
                ListViewItem fooi = new ListViewItem(list_item.fooi.ToString());

                list_drankorders.Items.Add(id);
                list_drankorders.Items.Add(prijs);
                list_drankorders.Items.Add(betaalmethode);
                list_drankorders.Items.Add(fooi);
            }
        }
    }
}
