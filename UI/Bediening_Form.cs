
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
    public partial class Bediening_Form : Main_Form
    {

        List<BestelItem> lijstBestelItem;

        public Bediening_Form()
        {
            InitializeComponent();
            lijstBestelItem = new List<BestelItem>();
            
        }

        private void UpdateListView()
        {
            listView_Bestelling.Items.Clear();

            MenuItems logMenuItems = new MenuItems();

            foreach (BestelItem item in lijstBestelItem)
            {
                ListViewItem lvi = new ListViewItem(item.menuItem.shortname);
                lvi.SubItems.Add(item.aantal.ToString());
                lvi.SubItems.Add(logMenuItems.BerekenTotaalBestelItem(item).ToString());
                listView_Bestelling.Items.Add(lvi);
            }
        }
         
        protected void btn_dranken_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();

            
            ButtonSelectie btn_nonalcoholisch = new ButtonSelectie(Categorie.Drank, SubCategorie.Nonalcoholisch);
            pnl_optiesbestelling.Controls.Add(btn_nonalcoholisch);
            btn_nonalcoholisch.Text = "Non-Alcoholisch";
            btn_nonalcoholisch.Location = new Point(265, 0);
            btn_nonalcoholisch.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_alcoholisch = new ButtonSelectie(Categorie.Drank, SubCategorie.Alcoholisch);
            pnl_optiesbestelling.Controls.Add(btn_alcoholisch);
            btn_alcoholisch.Text = "Alcoholisch";
            btn_alcoholisch.Location = new Point(385, 0);
            btn_alcoholisch.Click += new EventHandler(GenereerMenuItemButtons);

        }

        protected void btn_diner_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();

            
            ButtonSelectie btn_DinerVoor = new ButtonSelectie(Categorie.Diner, SubCategorie.Voorgerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerVoor);
            btn_DinerVoor.Text = "Voorgerecht";
            btn_DinerVoor.Location = new Point(100, 0);
            btn_DinerVoor.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerTussen = new ButtonSelectie(Categorie.Diner, SubCategorie.Tussengerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerTussen);
            btn_DinerTussen.Text = "Tussengerecht";
            btn_DinerTussen.Location = new Point(200, 0);
            btn_DinerTussen.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerHoofd = new ButtonSelectie(Categorie.Diner, SubCategorie.HoofdGerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerHoofd);
            btn_DinerHoofd.Text = "Hoofdgerecht";
            btn_DinerHoofd.Location = new Point(300, 0);
            btn_DinerHoofd.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerNa = new ButtonSelectie(Categorie.Diner, SubCategorie.Nagerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerNa);
            btn_DinerNa.Text = "Nagerecht";
            btn_DinerNa.Location = new Point(400, 0);
            btn_DinerNa.Click += new EventHandler(GenereerMenuItemButtons);

        }

        protected void btn_lunch_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();

            
            ButtonSelectie btn_LunchVoor = new ButtonSelectie(Categorie.Lunch, SubCategorie.Voorgerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchVoor);
            btn_LunchVoor.Text = "Voorgerecht";
            btn_LunchVoor.Location = new Point(100, 0);
            btn_LunchVoor.Click += new EventHandler(GenereerMenuItemButtons);
            
            ButtonSelectie btn_LunchHoofd = new ButtonSelectie(Categorie.Lunch, SubCategorie.HoofdGerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchHoofd);
            btn_LunchHoofd.Text = "Hoofdgerecht";
            btn_LunchHoofd.Location = new Point(200, 0);
            btn_LunchHoofd.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_LunchNa = new ButtonSelectie(Categorie.Lunch, SubCategorie.Nagerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchNa);
            btn_LunchNa.Text = "Nagerecht";
            btn_lunch.Tag = 90;
            btn_LunchNa.Location = new Point(300, 0); 
            btn_LunchNa.Click += new EventHandler(GenereerMenuItemButtons);
        }

        private void GenereerMenuItemButtons(object sender, EventArgs e)
        {
            Categorie categorie = ((ButtonSelectie)sender).hoofdOptie;
            SubCategorie subcategorie = ((ButtonSelectie)sender).subOptie;

            Logica.MenuItems LogMenuItem = new MenuItems();

            List<Model.MenuItem> lijstMenuItems = LogMenuItem.HaalFilterdeLijstOp(categorie, subcategorie);

            flowLP_MenuItems.Controls.Clear();

            foreach(Model.MenuItem item in lijstMenuItems)
            {
                ButtonMenuItem button = new ButtonMenuItem(item);
                flowLP_MenuItems.Controls.Add(button);
                button.Location = new Point(50, 0);
                button.Click += new EventHandler(VoegMenuItemsToe);
            }
        }

        private void VoegMenuItemsToe(object sender, EventArgs e)
        {
            Model.MenuItem menuItem = ((ButtonMenuItem)sender).menuItem;

            bool bestaat = false;

            for (int i = 0; i < lijstBestelItem.Count; i++)
            {
                if(lijstBestelItem[i].menuItem == menuItem)
                {
                    lijstBestelItem[i].aantal++;
                    bestaat = true;
                }
            }

            if (bestaat == false)
            {
                //TO DO: id van database halen
                Model.BestelItem bestelItem = new BestelItem(1, menuItem, 1, null, "bestelt");
                lijstBestelItem.Add(bestelItem); 
            }

            UpdateListView();
        }
    }
}
