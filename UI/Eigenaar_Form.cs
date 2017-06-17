using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logica;
using Model;

//Known issues: voorraad negatief maken, wat gebeurt er dan?
//Extra toekomstige functionaliteiten: functie controleren, refresh, undo, waarschuwing niets geselecteerd, feedback op: iets is gelukt

namespace UI
{
    public partial class Eigenaar_Form : UI.Main_Form
    {
        Form popupForm = new Form();

        //Standards
        const int TITELX = 75;
        const int TITELY = 10;
        const int LBLX = 20;
        const int TBX = 200;
        const int SPACING = 45;
        const int FNTSIZE = 15;
        const int WIDTH = 150;
        const int MAXCODELENGTH = 4;


        private void RefreshVoorraad()
        {
            listViewVoorraad.Clear();
            List<Model.MenuItem> MI_lijst = new List<Model.MenuItem>(); //maak list aan
            MenuItems menuItems = new MenuItems(); //maak object aan
            MI_lijst = menuItems.make_list(); //vul lijst

            listViewVoorraad.View = View.Details;
            listViewVoorraad.Columns.Add("Id", 50);
            listViewVoorraad.Columns.Add("Naam", 350);
            listViewVoorraad.Columns.Add("Voorraad", 100);

            int aantal = MI_lijst.Count;

            for (int i = 0; i < aantal; i++)
            {
                ListViewItem li = new ListViewItem(MI_lijst[i].Id.ToString());
                li.SubItems.Add(MI_lijst[i].Naam.ToString());
                li.SubItems.Add(MI_lijst[i].Voorraad.ToString());

                listViewVoorraad.Items.Add(li);
            }
        }

        private void RefreshMedewerkers()
        {
            listViewMedewerkers.Clear();
            List<Model.Werknemer> w_lijst = new List<Model.Werknemer>();
            Werknemers werknemers = new Werknemers(); //maak object aan
            w_lijst = werknemers.make_list();

            listViewMedewerkers.View = View.Details;
            listViewMedewerkers.Columns.Add("Id", 50);
            listViewMedewerkers.Columns.Add("Naam", 350);
            listViewMedewerkers.Columns.Add("Functie", 100);

            int aantal2 = w_lijst.Count;

            for (int i = 0; i < aantal2; i++)
            {
                ListViewItem li = new ListViewItem(w_lijst[i].Id.ToString());
                li.SubItems.Add(w_lijst[i].Naam.ToString());
                li.SubItems.Add(w_lijst[i].Functie.ToString());

                listViewMedewerkers.Items.Add(li);
            }
        }

        private void RefreshMenukaarten()
        {
            treeViewMenu.Nodes.Clear();

            treeViewMenu.Nodes.Add("Lunch");

            treeViewMenu.Nodes.Add("Diner");

            treeViewMenu.Nodes.Add("Dranken");

            for (int i = 0; i < 2; i++)
            {
                treeViewMenu.Nodes[i].Nodes.Add("Voorgerecht");
                treeViewMenu.Nodes[i].Nodes.Add("Hoofdgerecht");
                treeViewMenu.Nodes[i].Nodes.Add("Nagerecht");
            }

            //foreach (Model.MenuItem item in MI_lijst)
            //{
            //    TreeNode node = new TreeNode();
            //    treeViewMenu.Nodes.Add(item.id.ToString());
            //}
        }

        public Eigenaar_Form()
        {
            InitializeComponent();

            ///Tab1 Voorraad
            RefreshVoorraad();

            ///Tab2 Medewerkers
            RefreshMedewerkers();

            ///Tab3 Menukaarten
            RefreshMenukaarten();
        }
        //Hulpmethodes
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

        ///---UI STUFF---///

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            MenuItems menuitems = new MenuItems();
            foreach (ListViewItem checkedItem in listViewVoorraad.CheckedItems)
            {
                int id = int.Parse(checkedItem.SubItems[0].Text);

                menuitems.WijzigVoorraad(id, (int)numericUpDown1.Value, true);
            }
            RefreshVoorraad();
        }

        private void btnVerlaag_Click(object sender, EventArgs e)
        {
            MenuItems menuitems = new MenuItems();
            foreach (ListViewItem checkedItem in listViewVoorraad.CheckedItems)
            {
                int id = int.Parse(checkedItem.SubItems[0].Text);

                menuitems.WijzigVoorraad(id, (int)numericUpDown1.Value, false);
            }
            RefreshVoorraad();
        }
        ///PopupForm    controls
            //Medewerker controls
        Label lblNaam = new Label(); //Zit ook in menukaart
        Label lblFunctie = new Label();
        Label lblCode = new Label();
        Label lblId = new Label();

        TextBox txtNaam = new TextBox(); //Zit ook in menukaart
        ComboBox cmbFunctie = new ComboBox();
        TextBox txtCode = new TextBox();
            //Menukaart controls
        Label lblMenukaart = new Label();
        Label lblSubcategorie = new Label();
        Label lblKorteNaam = new Label();
        Label lblPrijs = new Label();

        ComboBox cmbMenukaart = new ComboBox();
        ComboBox cmbSubcategorie = new ComboBox();
        TextBox txtKorteNaam = new TextBox();
        TextBox txtPrijs = new TextBox();
        //Algemeen
        Label lblTitel = new Label();
        Label lblError = new Label();
        Button btnBevestig = new Button();
        string btnFunctie = "";

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            if (btnFunctie == "ToevMedw")
            {
                Werknemers werknemers = new Werknemers(); 

                string naam = txtNaam.Text;
                string functie = cmbFunctie.Text;
                int code;
                bool ingevuld = int.TryParse(txtCode.Text, out code);
                if (!ingevuld)
                    lblError.Text = "Code niet ingevuld";

                lblError.ForeColor = Color.Red;
                lblError.Text = werknemers.ToevoegenWerknemer(naam, functie, code);

                if (lblError.Text == "")
                {
                    RefreshMedewerkers();
                    popupForm.Close();
                }
            }
            else if (btnFunctie == "WijzMedw")
            {
                Werknemers werknemers = new Werknemers();

                int id = int.Parse(lblId.Text);
                string naam = txtNaam.Text;
                string functie = cmbFunctie.Text;

                lblError.ForeColor = Color.Red;
                lblError.Text = werknemers.WijzigenWerknemer(id, naam, functie);

                if (lblError.Text == "")
                {
                    RefreshMedewerkers();
                    popupForm.Close();
                }
            }
        }
        
        private void VulCmbFunctie()
        {
            cmbFunctie.Items.Clear();

            foreach (Functie functie in Enum.GetValues(typeof(Functie)))
                cmbFunctie.Items.Add(functie);
        }

        private void ToevMedwUI()
        {
            InitControl(lblTitel, TITELX, TITELY, "Medewerker Toevoegen", FNTSIZE, 250);

            InitControl(lblNaam, LBLX, SPACING * 1, "Naam", FNTSIZE, WIDTH);
            InitControl(lblFunctie, LBLX, SPACING * 2, "Functie", FNTSIZE, WIDTH);
            InitControl(lblCode, LBLX, SPACING * 3, "4-Cijferige Code", FNTSIZE, WIDTH+20);
            InitControl(lblError, 100, SPACING * 6, "", FNTSIZE, WIDTH + 30, 25);

            InitControl(txtNaam, TBX, SPACING * 1, "", FNTSIZE, WIDTH);
            InitControl(cmbFunctie, TBX, SPACING * 2, "Functie", FNTSIZE, WIDTH);
            cmbFunctie.DropDownStyle = ComboBoxStyle.DropDownList;
            InitControl(txtCode, TBX, SPACING * 3, "", FNTSIZE, 52);
            txtCode.MaxLength = MAXCODELENGTH;

            VulCmbFunctie();

            InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150, 60);
            btnBevestig.Click += btnBevestig_Click;
            btnFunctie = "ToevMedw";

            PopupFormStandardControls();
            PopupFormExtraControls(lblCode, txtCode);
            PopupFormExtraControls(lblFunctie, cmbFunctie);

            popupForm.ShowDialog();
        }

        private void WijzMedwUI()
        {
            if (listViewMedewerkers.CheckedItems.Count == 1)
            {
                ListViewItem checkedItem = listViewMedewerkers.CheckedItems[0];

                int id = int.Parse(checkedItem.SubItems[0].Text);
                string naam = checkedItem.SubItems[1].Text.Trim();
                string functie = checkedItem.SubItems[2].Text;

                InitControl(lblTitel, TITELX, TITELY, "Medewerker Wijzigen", FNTSIZE, 250);

                InitControl(lblNaam, LBLX, SPACING * 1, "Naam", FNTSIZE, WIDTH);
                InitControl(lblFunctie, LBLX, SPACING * 3, "Functie", FNTSIZE, WIDTH);
                InitControl(lblId, LBLX, SPACING * 4, id.ToString(), FNTSIZE, WIDTH);
                InitControl(lblError, 100, SPACING * 6, "", FNTSIZE, WIDTH + 30, 25);

                InitControl(txtNaam, TBX, SPACING * 1, naam, FNTSIZE, WIDTH);
                InitControl(cmbFunctie, TBX, SPACING * 3, functie, FNTSIZE, WIDTH);

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
            InitControl(lblTitel, TITELX, TITELY, "Aan menu toevoegen", FNTSIZE, 250);

            InitControl(lblMenukaart, LBLX, SPACING * 1, "Menukaart", FNTSIZE, WIDTH);
            InitControl(lblSubcategorie, LBLX, SPACING * 2, "Subcategorie", FNTSIZE, WIDTH);
            InitControl(lblNaam, LBLX, SPACING * 3, "Naam", FNTSIZE, WIDTH);
            InitControl(lblKorteNaam, LBLX, SPACING * 4, "Verkorte Naam", FNTSIZE, WIDTH);
            InitControl(lblPrijs, LBLX, SPACING * 5, "Prijs (in euro's)", FNTSIZE, WIDTH);
            InitControl(lblError, 100, SPACING * 6, "", FNTSIZE, WIDTH + 30, 25);

            InitControl(cmbMenukaart, TBX, SPACING * 1, "Menukaart", FNTSIZE, WIDTH);
            cmbMenukaart.DropDownStyle = ComboBoxStyle.DropDownList;
            InitControl(cmbSubcategorie, TBX, SPACING * 2, "Subcategorie", FNTSIZE, WIDTH);
            cmbSubcategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            InitControl(txtNaam, TBX, SPACING * 3, "", FNTSIZE, WIDTH);
            InitControl(txtKorteNaam, TBX, SPACING * 4, "", FNTSIZE, WIDTH);
            InitControl(txtPrijs, TBX, SPACING * 5, "", FNTSIZE, WIDTH);

            foreach (Categorie categorie in Enum.GetValues(typeof(Categorie)))
                cmbMenukaart.Items.Add(categorie);

            foreach (SubCategorie subcategorie in Enum.GetValues(typeof(SubCategorie)))
                cmbSubcategorie.Items.Add(subcategorie);

            InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150, 40);

            PopupFormStandardControls();
            PopupFormExtraControls(lblMenukaart, cmbMenukaart);
            PopupFormExtraControls(lblSubcategorie, cmbSubcategorie);
            PopupFormExtraControls(lblKorteNaam, txtKorteNaam);
            PopupFormExtraControls(lblPrijs, txtPrijs);
        }

        private void WijzMenukaartUI()
        {

        }

        private void btnToevMedw_Click(object sender, EventArgs e)
        {
            //BaseButton? 
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
                string message = "Weet u zeker dat u deze medewerker(s) wilt verwijderen?";
                string caption = "Waarschuwing";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {

                    foreach (ListViewItem checkedItem in listViewMedewerkers.CheckedItems)
                    {
                        Werknemers werknemers = new Werknemers();

                        int id = int.Parse(checkedItem.SubItems[0].Text);

                        werknemers.VerwijderenWerknemer(id);

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

            popupForm.ShowDialog();
        }

        private void btnWijzMenukaart_Click(object sender, EventArgs e)
        {
            InitPopupForm();

            popupForm.Controls.Clear();

            WijzMenukaartUI();

            popupForm.ShowDialog();
        }

        private void btnVerwMenukaart_Click(object sender, EventArgs e)
        {
            //if (treeViewMenu.CheckedItems.Count >= 1)
            //{
            string message = "Weet u zeker dat u dit menu-item wilt verwijderen?";
            string caption = "Waarschuwing";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {

            }
            //}
        }

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
            RefreshMenukaarten();
        }
    }
}
