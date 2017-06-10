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
    public partial class Eigenaar_Form : UI.Main_Form
    {
        public Eigenaar_Form()
        {
            InitializeComponent();
        }

        private void InitListView()
        {
            ListView listViewOverzicht = new ListView();
            listViewOverzicht.Height = 563;
            listViewOverzicht.Width = 688;
        }

        private void btnVoorraad_Click(object sender, EventArgs e)
        {
            listViewOverzicht.Clear();
            lblTitel.Text = "Voorraad";

            InitListView();

            List<Model.MenuItem> MI_lijst = new List<Model.MenuItem>(); //maak list aan
            MenuItems menuItems = new MenuItems(); //maak object aan
            MI_lijst = menuItems.make_list(); //vul lijst

            listViewOverzicht.View = View.Details;
            listViewOverzicht.Columns.Add("Id", 50);
            listViewOverzicht.Columns.Add("Naam", 300);
            listViewOverzicht.Columns.Add("Voorraad", 100);

            int aantal = MI_lijst.Count;

            for (int i = 0; i < aantal; i++)
            {
                ListViewItem li = new ListViewItem(MI_lijst[i].id.ToString());
                li.SubItems.Add(MI_lijst[i].naam.ToString());
                li.SubItems.Add(MI_lijst[i].voorraad.ToString());

                listViewOverzicht.Items.Add(li);
            }
            //panel2.Controls.Add(listViewOverzicht);
        }

        private void btnMedewerkers_Click(object sender, EventArgs e)
        {
            listViewOverzicht.Clear();
            lblTitel.Text = "Medewerkers";

            InitListView();

            List<Werknemer> w_lijst = new List<Werknemer>();

            listViewOverzicht.View = View.Details;
            listViewOverzicht.Columns.Add("Id", 50);
            listViewOverzicht.Columns.Add("Voornaam", 150);
            listViewOverzicht.Columns.Add("Achternaam", 150);
            listViewOverzicht.Columns.Add("Functie", 100);

        }

        private void btnMenuKaarten_Click(object sender, EventArgs e)
        {
            listViewOverzicht.Clear();
            lblTitel.Text = "Menukaarten";

            InitListView();

            List<Model.MenuItem> MI_lijst = new List<Model.MenuItem>(); //maak list aan
            MenuItems menuItems = new MenuItems(); //maak object aan
            MI_lijst = menuItems.make_list(); //vul lijst

        }
    }
}
