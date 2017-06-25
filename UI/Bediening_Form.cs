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
        Model.Werknemer werknemer;
        List<BestelItem> lijstBestelItem;
        Model.Tafel tafel;

        public Bediening_Form(Model.Werknemer werknemer, int tafelNummer): base(werknemer)
        {
            InitializeComponent();

            // bewerk tafel nummer in tafel button boven in applicatie
            SetTafelNummer(tafelNummer);

            // vul de gedeclareerde velden
            this.werknemer = werknemer;
            tafel = new Model.Tafel(tafelNummer, Status_tafel.Bezet);
            lijstBestelItem = new List<BestelItem>();
        }

        // Update de listview met de bestel items in de lijstBestelItems
        private void UpdateListView()
        {
            listView_Bestelling.Items.Clear();

            MenuItems_Service logMenuItems = new MenuItems_Service();

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

        // genereerd categorie buttons voor drankjes
        private void Btn_dranken_Click(object sender, EventArgs e)
        {
            // clear de panel en flow layout panel van buttons
            pnl_optiesbestelling.Controls.Clear();
            flowLP_MenuItems.Controls.Clear();

            // button van van de totaal bestelling button ontzichbaar maken
            Btn_VerwijderItemUitDB.Enabled = false;
            Btn_VerwijderItemUitDB.Visible = false;

            ButtonSelectie btn_nonalcoholisch = new ButtonSelectie(MenuKaart.Drank, Categorie.Nonalcoholisch);
            pnl_optiesbestelling.Controls.Add(btn_nonalcoholisch);
            btn_nonalcoholisch.Text = "Non-Alcoholisch";
            btn_nonalcoholisch.Location = new Point(220, 0);
            btn_nonalcoholisch.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_alcoholisch = new ButtonSelectie(MenuKaart.Alcohol, Categorie.Alcoholisch);
            pnl_optiesbestelling.Controls.Add(btn_alcoholisch);
            btn_alcoholisch.Text = "Alcoholisch";
            btn_alcoholisch.Location = new Point(345, 0);
            btn_alcoholisch.Click += new EventHandler(GenereerMenuItemButtons);

            UpdateListView();

        }

        // genereerd categorie buttons voor diner
        private void Btn_diner_Click(object sender, EventArgs e)
        {
            // clear de panel en flow layout panel van buttons
            pnl_optiesbestelling.Controls.Clear();
            flowLP_MenuItems.Controls.Clear();

            // button van van de totaal bestelling button ontzichbaar maken
            Btn_VerwijderItemUitDB.Enabled = false;
            Btn_VerwijderItemUitDB.Visible = false;

            ButtonSelectie btn_DinerVoor = new ButtonSelectie(MenuKaart.Diner, Categorie.Voorgerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerVoor);
            btn_DinerVoor.Text = "Voorgerecht";
            btn_DinerVoor.Location = new Point(10, 0);
            btn_DinerVoor.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerTussen = new ButtonSelectie(MenuKaart.Diner, Categorie.Tussengerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerTussen);
            btn_DinerTussen.Text = "Tussengerecht";
            btn_DinerTussen.Location = new Point(135, 0);
            btn_DinerTussen.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerHoofd = new ButtonSelectie(MenuKaart.Diner, Categorie.HoofdGerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerHoofd);
            btn_DinerHoofd.Text = "Hoofdgerecht";
            btn_DinerHoofd.Location = new Point(260, 0);
            btn_DinerHoofd.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_DinerNa = new ButtonSelectie(MenuKaart.Diner, Categorie.Nagerecht);
            pnl_optiesbestelling.Controls.Add(btn_DinerNa);
            btn_DinerNa.Text = "Nagerecht";
            btn_DinerNa.Location = new Point(385, 0);
            btn_DinerNa.Click += new EventHandler(GenereerMenuItemButtons);

            UpdateListView();

        }

        // genereerd categorie buttons voor lunch
        private void Btn_lunch_Click(object sender, EventArgs e)
        {
            // clear de panel en flow layout panel van buttons
            pnl_optiesbestelling.Controls.Clear();
            flowLP_MenuItems.Controls.Clear();

            // button van van de totaal bestelling button ontzichbaar maken
            Btn_VerwijderItemUitDB.Enabled = false;
            Btn_VerwijderItemUitDB.Visible = false;

            ButtonSelectie btn_LunchVoor = new ButtonSelectie(MenuKaart.Lunch, Categorie.Voorgerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchVoor);
            btn_LunchVoor.Text = "Voorgerecht";
            btn_LunchVoor.Location = new Point(10, 0);
            btn_LunchVoor.Click += new EventHandler(GenereerMenuItemButtons);
            
            ButtonSelectie btn_LunchHoofd = new ButtonSelectie(MenuKaart.Lunch, Categorie.HoofdGerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchHoofd);
            btn_LunchHoofd.Text = "Hoofdgerecht";
            btn_LunchHoofd.Location = new Point(135, 0);
            btn_LunchHoofd.Click += new EventHandler(GenereerMenuItemButtons);

            ButtonSelectie btn_LunchNa = new ButtonSelectie(MenuKaart.Lunch, Categorie.Nagerecht);
            pnl_optiesbestelling.Controls.Add(btn_LunchNa);
            btn_LunchNa.Text = "Nagerecht";
            btn_LunchNa.Location = new Point(260, 0); 
            btn_LunchNa.Click += new EventHandler(GenereerMenuItemButtons);

            UpdateListView();
        }

        // genereerd menu buttons voor het selecteren en verhogen van menu item + button voor verlagen
        private void GenereerMenuItemButtons(object sender, EventArgs e)
        {
            // haal de informatie van de sender er uit
            MenuKaart menuKaart = ((ButtonSelectie)sender).hoofdOptie;
            Categorie categorie = ((ButtonSelectie)sender).subOptie;

            Logica.MenuItems_Service LogMenuItem = new MenuItems_Service();

            // haal de informatie uit DB met de filters die uit de button is gehaald
            List<Model.MenuItem> lijstMenuItems = LogMenuItem.HaalFilterdeLijstOp(menuKaart, categorie);

            flowLP_MenuItems.Controls.Clear();

            // maak buttons van de informatie uit DB en stop het in een flow layout panel
            foreach(Model.MenuItem item in lijstMenuItems)
            {
                ButtonMenuItem buttonVerhoog = new ButtonMenuItem(item);
                flowLP_MenuItems.Controls.Add(buttonVerhoog);
                buttonVerhoog.Location = new Point(50, 0);
                buttonVerhoog.Click += new EventHandler(VoegMenuItemToe);

                ButtonMenuItem buttonVerlaag = new ButtonMenuItem(item);
                flowLP_MenuItems.Controls.Add(buttonVerlaag);
                buttonVerlaag.Size = new Size(40, 40);
                buttonVerlaag.Text = "-1";
                buttonVerlaag.BackColor = Color.DarkRed;
                buttonVerlaag.ForeColor = Color.White;
                buttonVerlaag.Click += new EventHandler(VerlaagMenuItem);

            }
        }

        // Voegt menu items toe in een ViewList of verhoogd aantal van een menu item in de viewlist
        private void VoegMenuItemToe(object sender, EventArgs e)
        {
            lbl_VoorraadOp.Text = "";

            Model.MenuItem menuItem = ((ButtonMenuItem)sender).menuItem;

            bool bestaat = false;

            // controleerd of er al van een specifieke menu item bestelt is
            // true = verhoog aantal
            // false = nieuwe bestelitem toevoegen 
            for (int i = 0; i < lijstBestelItem.Count; i++)
            {
                if (lijstBestelItem[i].MenuItem.Shortname == menuItem.Shortname)
                {
                    bestaat = true;

                    // genereer waarschuwing + break als er geen voorraad meer is
                    if (menuItem.Voorraad <= lijstBestelItem[i].Aantal)
                    {
                        lbl_VoorraadOp.Text = "Kan geen extra '" + menuItem.Shortname.Trim(' ') + "' toevoegen\n(menu item is op)";
                        break;
                    }
                    
                    lijstBestelItem[i].Aantal++;
                }
            }

            if (bestaat == false)
            {
                BestelItem bestelItem = new BestelItem(0, menuItem, 1, "", Status.Open);
                lijstBestelItem.Add(bestelItem);
            }

            UpdateListView();
        }

        

    // verlaagd het aantal van een menu item in de lijst
    // 0 = verwijder uit lijst
    private void VerlaagMenuItem(object sender, EventArgs e)
        {
            lbl_VoorraadOp.Text = "";

            Model.MenuItem menuItem = ((ButtonMenuItemVerlaag)sender).menuItem;

            BestelItems_Service serviceBestelItems = new BestelItems_Service();
            serviceBestelItems.VerlaagAantal(ref lijstBestelItem, menuItem);

            UpdateListView();
        }

        // verzend bestelling naar DB
        private void Btn_Verstuur_Click(object sender, EventArgs e)
        {
            if (lijstBestelItem.Count == 0)
                return;

            Logica.MenuItems_Service logMenuItems = new MenuItems_Service();
            logMenuItems.BewerkVoorraad(lijstBestelItem);

            Logica.Bestellingen_Service logBestellingen = new Bestellingen_Service();

            if (logBestellingen.ControleerOfTafelAlBestellingHeeft(tafel))
            {
                logBestellingen.StuurBestelItemNaarDatabase(lijstBestelItem);

                lijstBestelItem.Clear();
                UpdateListView();
                return;
            }
            else
            {

                Model.Bestelling bestelling = new Bestelling(logBestellingen.GetCountOrderId() + 1, lijstBestelItem, tafel, Status.Open, werknemer, logMenuItems.BerekenTotaalBestelling(lijstBestelItem), "", 0, DateTime.Now.ToString());

                logMenuItems.StuurBestellingNaarDatabase(bestelling);

                logBestellingen.StuurBestelItemNaarDatabase(lijstBestelItem);
            }

            lijstBestelItem.Clear();
            UpdateListView();
        }

        // opent betalen form
        private void Btn_afrekenen_Click(object sender, EventArgs e)
        {
            Betalen_Form betalen_form = new Betalen_Form(werknemer, tafel.Id);
            betalen_form.Show();
        }

        // wist huidige bestelling
        private void Btn_verwijderHuidigeBestelling_Click(object sender, EventArgs e)
        {
            lijstBestelItem.Clear();
            UpdateListView();
        }

        // toont de totale bestelling van een tafel
        private void ToonTotaleBestelling(object sender, EventArgs e)
        {
            listView_Bestelling.Items.Clear();

            pnl_optiesbestelling.Controls.Clear();
            flowLP_MenuItems.Controls.Clear();

            pnl_optiesbestelling.Controls.Add(Btn_VerwijderItemUitDB);
            Btn_VerwijderItemUitDB.Enabled = true;
            Btn_VerwijderItemUitDB.Visible = true;

            Logica.Bestellingen_Service logBestelingen = new Bestellingen_Service();
            Logica.BestelItems_Service logBestelItems = new BestelItems_Service();
            MenuItems_Service logMenuItems = new MenuItems_Service();

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

        // toont opmerking textbox en button
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

        // verwijderd een bestelitem van de database
        private void Btn_VerwijderItemUitDB_Click(object sender, EventArgs e)
        {
            listView_Bestelling.Items.Clear();

            BestelItems_Service logBestelItems = new BestelItems_Service();
            Bestellingen_Service logBestellingen = new Bestellingen_Service();
            MenuItems_Service logMenuItems = new MenuItems_Service();

            foreach (ListViewItem item in listView_Bestelling.SelectedItems)
            {
                BestelItem bestelItem = (BestelItem)item.Tag;
                logBestelItems.VerwijderBestelItemUitDB(bestelItem);
            }

            int bestellingId = logBestellingen.GetBestellingIdByTafelNummer(tafel);
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
