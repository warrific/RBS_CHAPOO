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

            MenuItems menuitems = new MenuItems();

            List<Model.MenuItem> lijst = new List<Model.MenuItem>();
            lijst = menuitems.make_list();

            foreach (Model.MenuItem list_item in lijst)
            {
                ListViewItem item = new ListViewItem(list_item.id.ToString());
                item.SubItems.Add(list_item.naam);
                item.SubItems.Add(list_item.prijs.ToString());
                item.SubItems.Add(list_item.voorraad.ToString());
                item.SubItems.Add(list_item.shortname);

                list_drankorders.Items.Add(item);
            }
        }
    }
}
