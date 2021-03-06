﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logica;
using Model;

namespace UI
{
    public partial class Eigenaar_Form : Main_Form
    {
        // Standards
        const int TITELX = 75;
        const int TITELY = 10;
        const int LBLX = 20;
        const int TBX = 200;
        const int SPACING = 45;
        const int FNTSIZE = 15;
        const int WIDTH = 150;
        const int MAXCODELENGTH = 4;
        bool naamKort = false;

        public Eigenaar_Form(Werknemer modelWerknemer) : base(modelWerknemer)
        {
            InitializeComponent();

            // Labels voor tafels weg
            lbl_tafel.Hide();
            btn_Tafel.Hide();

            // Tab1 Voorraad
            RefreshVoorraad();

            // Tab2 Medewerkers
            RefreshMedewerkers();

            // Tab3 Menukaarten
            RefreshMenu();
        }

        private void RefreshVoorraad()
        {
            listViewVoorraad.Clear();
            List<Model.MenuItem> MI_lijst = new List<Model.MenuItem>(); // maak list aan
            MenuItems_Service menuItemLogica = new MenuItems_Service(); // maak object aan
            MI_lijst = menuItemLogica.make_list(); // vul lijst

            // ListView kolommen en items
            listViewVoorraad.View = View.Details;
            listViewVoorraad.Columns.Add("Id", 50);
            if (naamKort)
                listViewVoorraad.Columns.Add("Verkorte naam", 320);
            else
            listViewVoorraad.Columns.Add("Naam", 350);
            listViewVoorraad.Columns.Add("Voorraad", 100);

            // Vult listview met items
            for (int i = 0; i < MI_lijst.Count; i++) 
            {
                ListViewItem li = new ListViewItem(MI_lijst[i].Id.ToString());
                if (naamKort)
                    li.SubItems.Add(MI_lijst[i].Shortname.ToString());
                else
                    li.SubItems.Add(MI_lijst[i].Naam.ToString());
                li.SubItems.Add(MI_lijst[i].Voorraad.ToString());

                listViewVoorraad.Items.Add(li);
            }
        }

        private void RefreshMedewerkers()
        {
            listViewMedewerkers.Clear();
            List<Model.Werknemer> w_lijst = new List<Model.Werknemer>();
            Werknemer_Service werknemerLogica = new Werknemer_Service(); //maak object aan
            w_lijst = werknemerLogica.make_list();

            // ListView kolommen en items
            listViewMedewerkers.View = View.Details;
            listViewMedewerkers.Columns.Add("Id", 50);
            listViewMedewerkers.Columns.Add("Naam", 300);
            listViewMedewerkers.Columns.Add("Functie", 100);
            listViewMedewerkers.Columns.Add("Code", 100);

            for (int i = 0; i < w_lijst.Count; i++) //Vult listview met items
            {
                ListViewItem li = new ListViewItem(w_lijst[i].Id.ToString());
                li.SubItems.Add(w_lijst[i].Naam.ToString());
                li.SubItems.Add(w_lijst[i].Functie.ToString());
                li.SubItems.Add(w_lijst[i].Wachtwoord.ToString());

                listViewMedewerkers.Items.Add(li);
            }
        }

        private void RefreshMenu()
        {
            listViewMenu.Clear();

            List<Model.MenuItem> MI_lijst = new List<Model.MenuItem>(); //maak list aan
            MenuItems_Service menuItemLogica = new MenuItems_Service(); //maak object aan
            MI_lijst = menuItemLogica.make_list(); //vul lijst

            // ListView kolommen en items
            listViewMenu.View = View.Details;
            listViewMenu.Columns.Add("Id", 50);
            if (naamKort)
            {
                listViewMenu.Columns.Add("Verkorte naam", 170);
                listViewMenu.Columns.Add("Naam", 0);
            }
            else
            {
                listViewMenu.Columns.Add("Naam", 190);
                listViewMenu.Columns.Add("Verkorte naam", 0);
            }
            listViewMenu.Columns.Add("Categorie", 100);
            listViewMenu.Columns.Add("Menukaart", 120);
            listViewMenu.Columns.Add("Prijs", 70);

            for (int i = 0; i < MI_lijst.Count; i++) //Vult listview met items
            {
                ListViewItem li = new ListViewItem(MI_lijst[i].Id.ToString());
                if (naamKort)
                {
                    li.SubItems.Add(MI_lijst[i].Shortname.ToString());
                    li.SubItems.Add(MI_lijst[i].Naam.ToString());
                }
                else
                {
                    li.SubItems.Add(MI_lijst[i].Naam.ToString());
                    li.SubItems.Add(MI_lijst[i].Shortname.ToString());
                }
                li.SubItems.Add(MI_lijst[i].categorie.ToString());
                li.SubItems.Add(MI_lijst[i].menuKaart.ToString());
                li.SubItems.Add(MI_lijst[i].Prijs.ToString("€0.00"));

                listViewMenu.Items.Add(li);
            }
        }

        ///---UI STUFF---///
        Form popupForm = new Form();

        /// PopupForm controls
        // Medewerker controls
        Label lblNaam = new Label(); //Zit ook in menukaart
        Label lblFunctie = new Label();
        Label lblCode = new Label();
        Label lblId = new Label();

        TextBox txtNaam = new TextBox(); //Zit ook in menukaart
        ComboBox cmbFunctie = new ComboBox();
        TextBox txtCode = new TextBox();
        // Menukaart controls
        Label lblMenukaart = new Label();
        Label lblCategorie = new Label();
        Label lblKorteNaam = new Label();
        Label lblPrijs = new Label();

        ComboBox cmbMenukaart = new ComboBox();
        ComboBox cmbCategorie = new ComboBox();
        TextBox txtKorteNaam = new TextBox();
        TextBox txtPrijs = new TextBox();
        // Algemeen
        Label lblTitel = new Label();
        Label lblError = new Label();
        Button btnBevestig = new Button();
        string btnFunctie = "";

        private void ToevMedwUI()
        {
            // Control instellingen die in popupform staan dmv van een methode.
            InitControl(lblTitel, TITELX, TITELY, "Medewerker Toevoegen", FNTSIZE, 250);

            InitControl(lblNaam, LBLX, SPACING * 1, "Naam", FNTSIZE, WIDTH);
            InitControl(lblFunctie, LBLX, SPACING * 2, "Functie", FNTSIZE, WIDTH);
            InitControl(lblCode, LBLX, SPACING * 3, "4-Cijferige Code", FNTSIZE, WIDTH + 20);
            InitControl(lblError, 100, SPACING * 6, "", FNTSIZE, WIDTH + 40, 25);

            InitControl(txtNaam, TBX, SPACING * 1, "", FNTSIZE, WIDTH);
            InitControl(cmbFunctie, TBX, SPACING * 2, "Functie", FNTSIZE, WIDTH);
            cmbFunctie.DropDownStyle = ComboBoxStyle.DropDownList;
            InitControl(txtCode, TBX, SPACING * 3, "", FNTSIZE, 52);
            txtCode.MaxLength = MAXCODELENGTH;

            VulCmbFunctie();

            InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150, 60);
            btnBevestig.Click += btnBevestig_Click;
            btnFunctie = "ToevMedw"; //Geeft aan wat de functie van de button is

            // Voeg controls to aan form
            PopupFormStandardControls();
            PopupFormExtraControls(lblCode, txtCode);
            PopupFormExtraControls(lblFunctie, cmbFunctie);

            popupForm.ShowDialog();
        }

        private void WijzMedwUI()
        {
            if (listViewMedewerkers.CheckedItems.Count == 1)
            {
                // Lees data uit listview
                ListViewItem checkedItem = listViewMedewerkers.CheckedItems[0];

                int id = int.Parse(checkedItem.SubItems[0].Text);
                string naam = checkedItem.SubItems[1].Text.Trim();
                string functie = checkedItem.SubItems[2].Text;
                
                InitControl(lblTitel, TITELX, TITELY, "Medewerker Wijzigen", FNTSIZE, 250);

                InitControl(lblNaam, LBLX, SPACING * 1, "Naam", FNTSIZE, WIDTH);
                InitControl(lblFunctie, LBLX, SPACING * 3, "Functie", FNTSIZE, WIDTH);
                InitControl(lblId, LBLX, SPACING * 4, id.ToString(), FNTSIZE, WIDTH);
                InitControl(lblError, 100, SPACING * 6, "", FNTSIZE, WIDTH + 40, 25);

                InitControl(txtNaam, TBX, SPACING * 1, naam, FNTSIZE, WIDTH);
                InitControl(cmbFunctie, TBX, SPACING * 3, functie, FNTSIZE, WIDTH);
                cmbFunctie.DropDownStyle = ComboBoxStyle.DropDown;

                VulCmbFunctie();

                InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150, 60);
                btnBevestig.Click += btnBevestig_Click;
                btnFunctie = "WijzMedw";
                
                PopupFormStandardControls();
                PopupFormExtraControls(lblFunctie, cmbFunctie);

                popupForm.ShowDialog();
            }
            else if (listViewMedewerkers.CheckedItems.Count > 1)
                MessageBox.Show("Te veel items aangevinkt!");
            else
                MessageBox.Show("Geen item aangevinkt!");
            
        }

        private void ToevMenukaartUI()
        {
            InitControl(lblTitel, TITELX + 10, TITELY, "Aan menu toevoegen", FNTSIZE, 250);

            InitControl(lblMenukaart, LBLX, SPACING * 1, "Menukaart", FNTSIZE, WIDTH);
            InitControl(lblCategorie, LBLX, SPACING * 2, "Categorie", FNTSIZE, WIDTH);
            InitControl(lblNaam, LBLX, SPACING * 3, "Naam", FNTSIZE, WIDTH);
            InitControl(lblKorteNaam, LBLX, SPACING * 4, "Verkorte Naam", FNTSIZE, WIDTH);
            InitControl(lblPrijs, LBLX, SPACING * 5, "Prijs (in euro's)", FNTSIZE, WIDTH);
            InitControl(lblError, 100, SPACING * 6, "", FNTSIZE, WIDTH + 100, 25);

            InitControl(cmbMenukaart, TBX, SPACING * 1, "Menukaart", FNTSIZE, WIDTH);
            cmbMenukaart.DropDownStyle = ComboBoxStyle.DropDownList;
            InitControl(cmbCategorie, TBX, SPACING * 2, "Categorie", FNTSIZE, WIDTH);
            cmbCategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            InitControl(txtNaam, TBX, SPACING * 3, "", FNTSIZE, WIDTH);
            InitControl(txtKorteNaam, TBX, SPACING * 4, "", FNTSIZE, WIDTH);
            InitControl(txtPrijs, TBX, SPACING * 5, "", FNTSIZE, WIDTH);

            VulCmbMenukaart();
            VulCmbCategorie();

            InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150, 40);
            btnBevestig.Click += btnBevestig_Click;
            btnFunctie = "ToevMenu";

            PopupFormStandardControls();
            PopupFormExtraControls(lblMenukaart, cmbMenukaart);
            PopupFormExtraControls(lblCategorie, cmbCategorie);
            PopupFormExtraControls(lblKorteNaam, txtKorteNaam);
            PopupFormExtraControls(lblPrijs, txtPrijs);

            popupForm.ShowDialog();
        }

        private void WijzMenukaartUI()
        {
            if (listViewMenu.CheckedItems.Count == 1)
            {
                ListViewItem checkedItem = listViewMenu.CheckedItems[0];
                string naam, korteNaam;

                int id = int.Parse(checkedItem.SubItems[0].Text);
                if (naamKort)
                {
                    korteNaam = checkedItem.SubItems[2].Text.Trim();
                    naam = checkedItem.SubItems[1].Text.Trim();
                }
                else
                {
                    naam = checkedItem.SubItems[1].Text.Trim();
                    korteNaam = checkedItem.SubItems[2].Text.Trim();
                }
                string categorie = checkedItem.SubItems[3].Text;
                string menukaart = checkedItem.SubItems[4].Text;
                string prijs = checkedItem.SubItems[5].Text.Replace("€", string.Empty).Replace(",", ".");

                InitControl(lblTitel, TITELX + 10, TITELY, "Aan menu wijzigen", FNTSIZE, 250);

                InitControl(lblId, LBLX, SPACING * 4, id.ToString(), FNTSIZE, WIDTH);
                InitControl(lblMenukaart, LBLX, SPACING * 1, "Menukaart", FNTSIZE, WIDTH);
                InitControl(lblCategorie, LBLX, SPACING * 2, "Categorie", FNTSIZE, WIDTH);
                InitControl(lblNaam, LBLX, SPACING * 3, "Naam", FNTSIZE, WIDTH);
                InitControl(lblKorteNaam, LBLX, SPACING * 4, "Verkorte Naam", FNTSIZE, WIDTH);
                InitControl(lblPrijs, LBLX, SPACING * 5, "Prijs (in euro's)", FNTSIZE, WIDTH);
                InitControl(lblError, 100, SPACING * 6, "", FNTSIZE, WIDTH + 100, 25);

                InitControl(cmbMenukaart, TBX, SPACING * 1, menukaart, FNTSIZE, WIDTH);
                cmbMenukaart.DropDownStyle = ComboBoxStyle.DropDown;
                InitControl(cmbCategorie, TBX, SPACING * 2, categorie, FNTSIZE, WIDTH);
                cmbCategorie.DropDownStyle = ComboBoxStyle.DropDown;
                InitControl(txtNaam, TBX, SPACING * 3, naam, FNTSIZE, WIDTH);
                InitControl(txtKorteNaam, TBX, SPACING * 4, korteNaam, FNTSIZE, WIDTH);
                InitControl(txtPrijs, TBX, SPACING * 5, prijs, FNTSIZE, WIDTH);

                VulCmbMenukaart();
                VulCmbCategorie();

                InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150, 40);
                btnBevestig.Click += btnBevestig_Click;
                btnFunctie = "WijzMenu";

                PopupFormStandardControls();
                PopupFormExtraControls(lblMenukaart, cmbMenukaart);
                PopupFormExtraControls(lblCategorie, cmbCategorie);
                PopupFormExtraControls(lblKorteNaam, txtKorteNaam);
                PopupFormExtraControls(lblPrijs, txtPrijs);

                popupForm.ShowDialog();
            }
            else if (listViewMenu.CheckedItems.Count > 1)
                MessageBox.Show("Te veel items aangevinkt!");
            else
                MessageBox.Show("Geen item aangevinkt!");
        }

        private void VulCmbFunctie()
        {
            cmbFunctie.Items.Clear();

            foreach (Functie functie in Enum.GetValues(typeof(Functie)))
                cmbFunctie.Items.Add(functie);
        }

        private void VulCmbMenukaart()
        {
            cmbMenukaart.Items.Clear();

            foreach (MenuKaart menukaart in Enum.GetValues(typeof(MenuKaart)))
                cmbMenukaart.Items.Add(menukaart);
        }

        private void VulCmbCategorie()
        {
            cmbCategorie.Items.Clear();

            foreach (Categorie sub in Enum.GetValues(typeof(Categorie)))
                cmbCategorie.Items.Add(sub);
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            if (btnFunctie == "ToevMedw")
            {
                Werknemer_Service werknemerLogica = new Werknemer_Service();

                lblError.ForeColor = Color.Red;
                // Uitlezen
                string naam = txtNaam.Text;
                string functie = cmbFunctie.Text;
                string ww = txtCode.Text;

                ControleerMedewerkerData(naam, functie, ww);

                if (lblError.Text == "")
                {
                    int code = int.Parse(ww);
                    werknemerLogica.ToevoegenWerknemer(naam, functie, code);
                    RefreshMedewerkers();
                    popupForm.Close();
                }

            }
            else if (btnFunctie == "WijzMedw")
            {
                Werknemer_Service werknemerLogica = new Werknemer_Service();

                int id = int.Parse(lblId.Text);
                string naam = txtNaam.Text;
                string functie = cmbFunctie.Text;

                lblError.ForeColor = Color.Red;
                ControleerMedewerkerData(naam, functie);

                if (lblError.Text == "")
                {
                    werknemerLogica.WijzigenWerknemer(id, naam, functie);
                    RefreshMedewerkers();
                    popupForm.Close();
                }
            }
            else if (btnFunctie == "ToevMenu")
            {
                MenuItems_Service menuLogica = new MenuItems_Service();

                string menukaart = cmbMenukaart.Text;
                string categorie = cmbCategorie.Text;
                string naam = txtNaam.Text;
                string korteNaam = txtKorteNaam.Text;
                string prijs = txtPrijs.Text.Replace(",", ".");

                lblError.ForeColor = Color.Red;
                ControleerMenuData(naam, menukaart, categorie, korteNaam, prijs);

                if (lblError.Text == "")
                {
                    menuLogica.ToevoegenMenu(menukaart, categorie, naam, korteNaam, prijs);
                    RefreshMenu();
                    popupForm.Close();
                }
            }
            else if (btnFunctie == "WijzMenu")
            {
                MenuItems_Service menuLogica = new MenuItems_Service();

                int id = int.Parse(lblId.Text);
                string menukaart = cmbMenukaart.Text;
                string categorie = cmbCategorie.Text;
                string naam = txtNaam.Text;
                string korteNaam = txtKorteNaam.Text;
                string prijs = txtPrijs.Text;

                lblError.ForeColor = Color.Red;
                ControleerMenuData(naam, menukaart, categorie, korteNaam, prijs);

                if (lblError.Text == "")
                {
                    menuLogica.WijzigenMenu(id, menukaart, categorie, naam, korteNaam, prijs);
                    RefreshMenu();
                    popupForm.Close();
                }
            }
        }

        private void ControleerMedewerkerData(string naam, string functie, string ww = "")
        {
            if (btnFunctie == "ToevMedw")
            {
                Werknemer_Service werknemerLogica = new Werknemer_Service();
                int code;

                if (naam == "")
                    lblError.Text = "Naam niet ingevuld";
                else if (!Enum.IsDefined(typeof(Functie), functie))
                    lblError.Text = "Functie niet ingevuld";
                else if (!int.TryParse(txtCode.Text, out code))
                    lblError.Text = "Code ongeldig";
                else if (code.ToString().Length != MAXCODELENGTH)
                    lblError.Text = "Code foute lengte";
                else if (!werknemerLogica.IsUniekeCode(code))
                    lblError.Text = "Code niet uniek";
                else
                    lblError.Text = "";
            }
            else if (btnFunctie == "WijzMedw")
            {
                if (naam == "")
                    lblError.Text = "Naam niet ingevuld";
                else if (!Enum.IsDefined(typeof(Functie), functie))
                    lblError.Text = "Functie ongeldig";
                else
                    lblError.Text = "";
            }
        }

        private void ControleerMenuData(string naam, string menukaart, string categorie, string korteNaam, string prijs)
        {
            float floatPrijs;

            if (!Enum.IsDefined(typeof(MenuKaart), menukaart))
                lblError.Text = "Menukaart niet ingevuld";
            else if (!Enum.IsDefined(typeof(Categorie), categorie))
                lblError.Text = "Categorie niet ingevuld";
            else if (naam == "")
                lblError.Text = "Naam niet ingevuld";
            else if (korteNaam == "")
                lblError.Text = "Korte naam niett ingevuld";
            else if (prijs == "")
                lblError.Text = "Prijs niet ingevuld";
            else if (!float.TryParse(prijs, out floatPrijs))
                lblError.Text = "Prijs ongeldig";
            else
                lblError.Text = "";
        }

        ///---FORM BUTTON EVENTS---///
        
        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            MenuItems_Service menuitems = new MenuItems_Service();
            foreach (ListViewItem checkedItem in listViewVoorraad.CheckedItems)
            {
                int id = int.Parse(checkedItem.SubItems[0].Text);

                menuitems.WijzigVoorraad(id, (int)numericUpDown1.Value, true);
            }
            RefreshVoorraad();
        }

        private void btnVerlaag_Click(object sender, EventArgs e)
        {
            MenuItems_Service menuitems = new MenuItems_Service();
            foreach (ListViewItem checkedItem in listViewVoorraad.CheckedItems)
            {
                int id = int.Parse(checkedItem.SubItems[0].Text);

                menuitems.WijzigVoorraad(id, (int)numericUpDown1.Value, false);
            }
            RefreshVoorraad();
        }

        private void btnToevMedw_Click(object sender, EventArgs e)
        {
            InitPopupForm();

            popupForm.Controls.Clear();

            ToevMedwUI();
        }

        private void btnWijzMedw_Click(object sender, EventArgs e)
        {
            InitPopupForm();

            popupForm.Controls.Clear();

            WijzMedwUI();
        }

        private void btnVerwMedw_Click(object sender, EventArgs e)
        {
            if (listViewMedewerkers.CheckedItems.Count >= 1)
            {
                string message;
                if (listViewMedewerkers.CheckedItems.Count == 1)
                    message = "Weet u zeker dat u deze medewerker wilt verwijderen?";
                else
                    message = "Weet u zeker dat u deze medewerkers wilt verwijderen?";
                string caption = "Waarschuwing";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem checkedItem in listViewMedewerkers.CheckedItems)
                    {
                        Werknemer_Service werknemerLogica = new Werknemer_Service();

                        int id = int.Parse(checkedItem.SubItems[0].Text);

                        werknemerLogica.VerwijderenWerknemer(id);

                        RefreshMedewerkers();
                    }
                }
            }
        }

        private void btnToevMenukaart_Click(object sender, EventArgs e)
        {
            InitPopupForm();

            popupForm.Controls.Clear();

            ToevMenukaartUI();
        }

        private void btnWijzMenukaart_Click(object sender, EventArgs e)
        {
            InitPopupForm();

            popupForm.Controls.Clear();

            WijzMenukaartUI();
        }

        private void btnVerwMenukaart_Click(object sender, EventArgs e)
        {
            if (listViewMenu.CheckedItems.Count >= 1)
            {
                string message;
                if (listViewMenu.CheckedItems.Count == 1)
                    message = "Weet u zeker dat u dit menu-item wilt verwijderen?";
                else
                    message = "Weet u zeker dat u deze menu-items wilt verwijderen?";
                string caption = "Waarschuwing";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem checkedItem in listViewMenu.CheckedItems)
                    {
                        MenuItems_Service menuLogica = new MenuItems_Service();

                        int id = int.Parse(checkedItem.SubItems[0].Text);

                        menuLogica.VerwijderenMenu(id);

                        RefreshMenu();
                    }
                }
            }
        }

        /// Overige buttons ///
        
        private void btnRefrVoorraad_Click(object sender, EventArgs e)
        {
            RefreshVoorraad();
        }

        private void btnRefrMedw_Click(object sender, EventArgs e)
        {
            RefreshMedewerkers();
        }

        private void btnRefrMenu_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }
        
        private void btnVeranderNaam_Click(object sender, EventArgs e)
        {
            naamKort = !naamKort;

            if (naamKort)
            {
                btnVeranderNaamMenu.Text = "Hele naam";
                btnVeranderNaamVoorraad.Text = "Hele naam";
            }
            else
            {
                btnVeranderNaamMenu.Text = "Verkort naam";
                btnVeranderNaamVoorraad.Text = "Verkort naam";
            }
            RefreshVoorraad();
            RefreshMenu();
            
        }

        // Hulpmethodes
        private void InitPopupForm()
        {
            popupForm.Width = 400;
            popupForm.Height = 400;
        }

        private void InitControl(Control lbl, int x, int y, string text, int fntSize, int width, int height = 30)
        {
            lbl.Location = new Point(x, y);
            lbl.Text = text;
            lbl.Font = new Font(lbl.Font.FontFamily, fntSize);
            lbl.Width = width;
            lbl.Height = height;
        }

        private void PopupFormStandardControls()
        {
            popupForm.Controls.Add(lblTitel);
            popupForm.Controls.Add(lblNaam);
            popupForm.Controls.Add(txtNaam);
            popupForm.Controls.Add(lblError);
            popupForm.Controls.Add(btnBevestig);
        }
        private void PopupFormExtraControls(Control extraCtrl1, Control extraCtrl2)
        {
            popupForm.Controls.Add(extraCtrl1);
            popupForm.Controls.Add(extraCtrl2);
        }
    }
}
