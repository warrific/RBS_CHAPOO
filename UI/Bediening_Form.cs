
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
        Model.Werknemer modelWerknemerOut = new Model.Werknemer();
        List<BestelItem> lijstBestelItem;
        Model.Tafel tafel;

        public Bediening_Form(Model.Werknemer modelWerknemer, int tafelnr_in): base(modelWerknemer)
        {
            InitializeComponent();
            modelWerknemerOut = modelWerknemer;
            setTafelNR(tafelnr_in);

            Logica.Werknemer logWerknemer = new Logica.Werknemer();

            tafel = new Model.Tafel(tafelnr_in, Status_tafel.Bezet);
            lijstBestelItem = new List<BestelItem>();
        }

        private void UpdateListView()
        {
            listView_Bestelling.Items.Clear();

            MenuItems logMenuItems = new MenuItems();

            foreach (BestelItem item in lijstBestelItem)
            {
                ListViewItem lvi = new ListViewItem(item.MenuItem.Shortname);
                lvi.Tag = item;
                lvi.SubItems.Add(item.Aantal.ToString());
                lvi.SubItems.Add(logMenuItems.BerekenTotaalBestelItem(item).ToString());
                lvi.SubItems.Add(item.Opmerking);
                listView_Bestelling.Items.Add(lvi);
            }
        }
         
        protected void Btn_dranken_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();
            flowLP_MenuItems.Controls.Clear();

            Btn_VerwijderItemUitDB.Enabled = false;
            Btn_VerwijderItemUitDB.Visible = false;

            ButtonSelectie btn_nonalcoholisch = new ButtonSelectie(Categorie.Drank, SubCategorie.Nonalcoholisch);
            pnl_optiesbestelling.Controls.Add(btn_nonalcoholisch);
            btn_nonalcoholisch.Text = "Non-Alcoholisch";
            btn_nonalcoholisch.Location = new Point(220, 0);
            btn_nonalcoholisch.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_alcoholisch = new ButtonSelectie(Categorie.Alcohol, SubCategorie.Alcoholisch);
            pnl_optiesbestelling.Controls.Add(btn_alcoholisch);
            btn_alcoholisch.Text = "Alcoholisch";
            btn_alcoholisch.Location = new Point(345, 0);
            btn_alcoholisch.Click += new EventHandler(GenereerMenuItemButtons);

            UpdateListView();

        }

        protected void Btn_diner_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();
            flowLP_MenuItems.Controls.Clear();

            Btn_VerwijderItemUitDB.Enabled = false;
            Btn_VerwijderItemUitDB.Visible = false;

            ButtonSelectie btn_DinerVoor = new ButtonSelectie(Categorie.Diner, SubCategorie.Voorgerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerVoor);
            btn_DinerVoor.Text = "Voorgerecht";
            btn_DinerVoor.Location = new Point(10, 0);
            btn_DinerVoor.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerTussen = new ButtonSelectie(Categorie.Diner, SubCategorie.Tussengerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerTussen);
            btn_DinerTussen.Text = "Tussengerecht";
            btn_DinerTussen.Location = new Point(135, 0);
            btn_DinerTussen.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerHoofd = new ButtonSelectie(Categorie.Diner, SubCategorie.HoofdGerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerHoofd);
            btn_DinerHoofd.Text = "Hoofdgerecht";
            btn_DinerHoofd.Location = new Point(260, 0);
            btn_DinerHoofd.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerNa = new ButtonSelectie(Categorie.Diner, SubCategorie.Nagerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerNa);
            btn_DinerNa.Text = "Nagerecht";
            btn_DinerNa.Location = new Point(385, 0);
            btn_DinerNa.Click += new EventHandler(GenereerMenuItemButtons);

            UpdateListView();

        }

        protected void Btn_lunch_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();
            flowLP_MenuItems.Controls.Clear();

            Btn_VerwijderItemUitDB.Enabled = false;
            Btn_VerwijderItemUitDB.Visible = false;

            ButtonSelectie btn_LunchVoor = new ButtonSelectie(Categorie.Lunch, SubCategorie.Voorgerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchVoor);
            btn_LunchVoor.Text = "Voorgerecht";
            btn_LunchVoor.Location = new Point(10, 0);
            btn_LunchVoor.Click += new EventHandler(GenereerMenuItemButtons);
            
            ButtonSelectie btn_LunchHoofd = new ButtonSelectie(Categorie.Lunch, SubCategorie.HoofdGerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchHoofd);
            btn_LunchHoofd.Text = "Hoofdgerecht";
            btn_LunchHoofd.Location = new Point(135, 0);
            btn_LunchHoofd.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_LunchNa = new ButtonSelectie(Categorie.Lunch, SubCategorie.Nagerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchNa);
            btn_LunchNa.Text = "Nagerecht";
            btn_lunch.Tag = 90;
            btn_LunchNa.Location = new Point(260, 0); 
            btn_LunchNa.Click += new EventHandler(GenereerMenuItemButtons);

            UpdateListView();
        }

        // genereerd menu buttons voor het selecteren en verhogen van menu item + button voor verlagen
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
                button.Click += new EventHandler(VoegMenuItemToe);

                ButtonMenuItemVerlaag buttonVerlaag = new ButtonMenuItemVerlaag(item);
                flowLP_MenuItems.Controls.Add(buttonVerlaag);
                buttonVerlaag.Click += new EventHandler(VerlaagMenuItem);

            }
        }

        // Voegt menu items toe in een ViewList of verhoogd aantal van een menu item in de viewlist
        private void VoegMenuItemToe(object sender, EventArgs e)
        {
            Model.MenuItem menuItem = ((ButtonMenuItem)sender).menuItem;

            bool bestaat = false;

            lbl_VoorraadOp.Text = "";

            for (int i = 0; i < lijstBestelItem.Count; i++)
            {
                if (lijstBestelItem[i].MenuItem.Shortname == menuItem.Shortname)
                {
                    bestaat = true;

                    // genereer waarschuwing + break
                    if (menuItem.Voorraad == lijstBestelItem[i].Aantal)
                    {
                        lbl_VoorraadOp.Text = "Kan geen extra '" + menuItem.Shortname.Trim(' ') + "' toevoegen\n(menu item is op)";
                        break;
                    }
                    
                    lijstBestelItem[i].Aantal++;
                    
                }
            }

            if (bestaat == false)
            {
                Logica.Bestellingen logBestellingen = new Bestellingen();
                BestelItem bestelItem = new BestelItem(logBestellingen.GetCountOrderId() + 1, menuItem, 1, "", Status.Open);
                lijstBestelItem.Add(bestelItem);
            }

            UpdateListView();
        }

        // verlaagd het aantal van een menu item
        private void VerlaagMenuItem(object sender, EventArgs e)
        {
            Model.MenuItem menuItem = ((ButtonMenuItemVerlaag)sender).menuItem;

            lbl_VoorraadOp.Text = "";

            for (int i = 0; i < lijstBestelItem.Count; i++)
            {
                if (lijstBestelItem[i].MenuItem.Shortname == menuItem.Shortname)
                {
                    lijstBestelItem[i].Aantal--;

                    if (lijstBestelItem[i].Aantal == 0)
                    {
                        lijstBestelItem.RemoveAt(i);
                    }
                }
            }

            UpdateListView();
        }

        // verzend bestelling naar db
        private void Btn_Verstuur_Click(object sender, EventArgs e)
        {
            if (lijstBestelItem.Count == 0)
                return;

            Logica.MenuItems logMenuItems = new MenuItems();
            Logica.Bestellingen logBestelingen = new Bestellingen();

            foreach(BestelItem item in lijstBestelItem)
            {
                logMenuItems.BewerkVoorraad(item.MenuItem, item.Aantal);
            }

            if (logBestelingen.ControleerOfTafelAlBestellingHeeft(tafel))
            {
                foreach (BestelItem item in lijstBestelItem)
                {
                    logBestelingen.StuurBestelItemNaarDatabase(item);
                }

                lijstBestelItem.Clear();
                UpdateListView();
                return;
            }

            Model.Bestelling bestelling = new Bestelling(logBestelingen.GetCountOrderId() + 1, lijstBestelItem, tafel, Status.Open , modelWerknemerOut, logMenuItems.BerekenTotaalBestelling(lijstBestelItem), "", 0, DateTime.Now);

            logMenuItems.StuurBestellingNaarDatabase(bestelling);

            foreach (BestelItem item in lijstBestelItem)
            {
                logBestelingen.StuurBestelItemNaarDatabase(item);
            }

            lijstBestelItem.Clear();
            UpdateListView();
        }

        // opent betalen form
        private void Btn_afrekenen_Click(object sender, EventArgs e)
        {
            Betalen_Form betalen_form = new Betalen_Form(modelWerknemerOut, tafel.Id);
            betalen_form.Show();
        }

        // wist huidige bestelling
        private void Btn_verwijderHuidigeBestelling_Click(object sender, EventArgs e)
        {
            lijstBestelItem.Clear();
            UpdateListView();
        }

        private void ToonTotaleBestelling(object sender, EventArgs e)
        {
            listView_Bestelling.Items.Clear();

            pnl_optiesbestelling.Controls.Clear();
            flowLP_MenuItems.Controls.Clear();

            pnl_optiesbestelling.Controls.Add(Btn_VerwijderItemUitDB);
            Btn_VerwijderItemUitDB.Enabled = true;
            Btn_VerwijderItemUitDB.Visible = true;

            Logica.Bestellingen logBestelingen = new Bestellingen();
            Logica.Bestelitems logBestelItems = new Bestelitems();
            MenuItems logMenuItems = new MenuItems();

            if (logBestelingen.ControleerOfTafelAlBestellingHeeft(tafel) == false)
                return;

            int bestellingId = logBestelingen.GetBestellingIdByTafelNummer(tafel);
            List<BestelItem> lijstBestelItems = logBestelItems.GetBestellingItems(bestellingId);

            foreach(BestelItem item in lijstBestelItems)
            {
                ListViewItem lvi = new ListViewItem(item.MenuItem.Shortname);
                lvi.SubItems.Add(item.Aantal.ToString());
                lvi.SubItems.Add(logMenuItems.BerekenTotaalBestelItem(item).ToString());
                lvi.SubItems.Add(item.Opmerking);
                lvi.Tag = item;
                listView_Bestelling.Items.Add(lvi);
            }
        }

        // toont opmerking textbox en butoon
        private void Btn_commentaar_Click(object sender, EventArgs e)
        {
            if(textBox_Commentaar.Enabled)
            {
                textBox_Commentaar.Enabled = false;
                textBox_Commentaar.Visible = false;
                btn_CommentaarSent.Enabled = false;
                btn_CommentaarSent.Visible = false;
            }
            else
            {
                textBox_Commentaar.Enabled = true;
                textBox_Commentaar.Visible = true;
                btn_CommentaarSent.Enabled = true;
                btn_CommentaarSent.Visible = true;
            }
        }

        // voegt opmerking aan bestelitem
        private void Btn_CommentaarSent_Click(object sender, EventArgs e)
        {
            if(listView_Bestelling.SelectedItems.Count == 0)
            {
                return;
            }

            foreach(ListViewItem item in listView_Bestelling.SelectedItems)
            {
                BestelItem BestelItemId = (BestelItem)item.Tag;

                foreach (BestelItem bestelItem in lijstBestelItem)
                {
                    if(bestelItem.MenuItem.Id.ToString() == BestelItemId.MenuItem.Id.ToString())
                    {
                        bestelItem.Opmerking = textBox_Commentaar.Text;
                    }
                }
            }

            UpdateListView();
        }

        private void Btn_VerwijderItemUitDB_Click(object sender, EventArgs e)
        {
            Bestelitems logBestelItems = new Bestelitems();
            Bestellingen logBestelingen = new Bestellingen();
            MenuItems logMenuItems = new MenuItems();
            foreach (ListViewItem item in listView_Bestelling.SelectedItems)
            {
                BestelItem bestelItem = (BestelItem)item.Tag;
                logBestelItems.VerwijderBestelItemUitDB(bestelItem);
            }

            int bestellingId = logBestelingen.GetBestellingIdByTafelNummer(tafel);
            List<BestelItem> lijstBestelItems = logBestelItems.GetBestellingItems(bestellingId);

            foreach (BestelItem item in lijstBestelItems)
            {
                ListViewItem lvi = new ListViewItem(item.MenuItem.Shortname);
                lvi.SubItems.Add(item.Aantal.ToString());
                lvi.SubItems.Add(logMenuItems.BerekenTotaalBestelItem(item).ToString());
                lvi.SubItems.Add(item.Opmerking);
                lvi.Tag = item;
                listView_Bestelling.Items.Add(lvi);
            }
        }
    }
}
