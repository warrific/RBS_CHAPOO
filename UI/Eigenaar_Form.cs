using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logica;
using Model;

//Known issues: voorraad negatief maken, wat gebeurt er dan?
//Extra toekomstige functionaliteiten: refresh, undo, waarschuwing niets geselecteerd, feedback op: iets is gelukt

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
                ListViewItem li = new ListViewItem(MI_lijst[i].id.ToString());
                li.SubItems.Add(MI_lijst[i].naam.ToString());
                li.SubItems.Add(MI_lijst[i].voorraad.ToString());

                listViewVoorraad.Items.Add(li);
            }
        }

        private void RefreshMedewerkers()
        {
            listViewMedewerkers.Clear();
            List<Werknemer> w_lijst = new List<Werknemer>();
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
                li.SubItems.Add(w_lijst[i].naam.ToString());
                li.SubItems.Add(w_lijst[i].functie.ToString());

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

        private void InitPopupForm()
        {
            popupForm.Width = 400;
            popupForm.Height = 400;

        }

        private void InitControl(Control lbl, int x, int y, string text, int fntSize, int width)
        {
            lbl.Location = new Point(x, y);
            lbl.Text = text;
            lbl.Font = new Font(lbl.Font.FontFamily, fntSize);
            lbl.Width = width;
        }

        ///---UI STUFF---///

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem checkedItem in listViewVoorraad.CheckedItems)
            {
                MenuItems menuitems = new MenuItems();

                int id = int.Parse(checkedItem.SubItems[0].Text);

                menuitems.WijzigVoorraad(id, (int)numericUpDown1.Value, true);
            }
            RefreshVoorraad();
        }

        private void btnVerlaag_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem checkedItem in listViewVoorraad.CheckedItems)
            {
                MenuItems menuitems = new MenuItems();

                int id = int.Parse(checkedItem.SubItems[0].Text);

                menuitems.WijzigVoorraad(id, (int)numericUpDown1.Value, false);
            }
            RefreshVoorraad();
        }
        ///PopupForm controls
            //Medewerker controls
        Label lblNaam = new Label(); //Zit ook in menukaart
        Label lblAchternaam = new Label();
        Label lblFunctie = new Label();
        Label lblCode = new Label();
        Label lblId = new Label();

        TextBox txtNaam = new TextBox(); //Zit ook in menukaart
        ComboBox cmbFunctie = new ComboBox();
        TextBox txtCode = new TextBox();
            //Menukaart controls
        Label lblMenukaart = new Label();
        Label lblSubcategorie = new Label();

        ComboBox cmbMenukaart = new ComboBox();
        ComboBox cmbSubcategorie = new ComboBox();
            //Algemeen
        Button btnBevestig = new Button();
        string btnFunctie = "";

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            if (btnFunctie == "Toevoegen")
            {
                Werknemers werknemers = new Werknemers();

                string naam = txtNaam.Text;
                string functie = cmbFunctie.Text;
                int code = int.Parse(txtCode.Text);

                werknemers.ToevoegenWerknemer(naam, functie, code);

                RefreshMedewerkers();

                popupForm.Close();
            }
            else if (btnFunctie == "Wijzigen")
            {
                Werknemers werknemers = new Werknemers();

                int id = int.Parse(lblId.Text);
                string naam = txtNaam.Text;
                string functie = cmbFunctie.Text;

                werknemers.WijzigenWerknemer(id, naam, functie);

                RefreshMedewerkers();

                popupForm.Close();
            }
        }

        private void ToevMedwUI()
        {
            Label lblTitel = new Label();
            InitControl(lblTitel, TITELX, TITELY, "Medewerker Toevoegen", FNTSIZE, 250);
            lblTitel.Height = 30;

            InitControl(lblNaam, LBLX, SPACING * 1, "Naam", FNTSIZE, WIDTH);
            InitControl(lblFunctie, LBLX, SPACING * 3, "Functie", FNTSIZE, WIDTH);
            InitControl(lblCode, LBLX, SPACING * 4, "Code", FNTSIZE, WIDTH);

            InitControl(txtNaam, TBX, SPACING * 1, "", FNTSIZE, WIDTH);
            InitControl(cmbFunctie, TBX, SPACING * 3, "Functie", FNTSIZE, WIDTH);
            InitControl(txtCode, TBX, SPACING * 4, "", FNTSIZE, WIDTH);

            cmbFunctie.Items.Clear();
            cmbFunctie.Items.Add("Bediening");
            cmbFunctie.Items.Add("Kok");
            cmbFunctie.Items.Add("Bar");
            cmbFunctie.Items.Add("Sommelier");
            cmbFunctie.Items.Add("Eigenaar");

            InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150);
            btnBevestig.Height = 60;
            btnBevestig.Click += btnBevestig_Click;
            btnFunctie = "Toevoegen";

            popupForm.Controls.Add(lblTitel);
            popupForm.Controls.Add(lblNaam);
            popupForm.Controls.Add(lblFunctie);
            popupForm.Controls.Add(lblCode);
            popupForm.Controls.Add(txtNaam);
            popupForm.Controls.Add(cmbFunctie);
            popupForm.Controls.Add(txtCode);
            popupForm.Controls.Add(btnBevestig);

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

                Label lblTitel = new Label();
                InitControl(lblTitel, TITELX, TITELY, "Medewerker Wijzigen", FNTSIZE, 250);
                lblTitel.Height = 30;

                InitControl(lblNaam, LBLX, SPACING * 1, "Naam", FNTSIZE, WIDTH);
                InitControl(lblFunctie, LBLX, SPACING * 3, "Functie", FNTSIZE, WIDTH);
                InitControl(lblId, LBLX, SPACING * 4, id.ToString(), FNTSIZE, WIDTH);

                InitControl(txtNaam, TBX, SPACING * 1, naam, FNTSIZE, WIDTH);
                InitControl(cmbFunctie, TBX, SPACING * 3, functie, FNTSIZE, WIDTH);

                cmbFunctie.Items.Clear();
                cmbFunctie.Items.Add("Bediening");
                cmbFunctie.Items.Add("Kok");
                cmbFunctie.Items.Add("Bar");
                cmbFunctie.Items.Add("Sommelier");
                cmbFunctie.Items.Add("Eigenaar");

                InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150);
                btnBevestig.Height = 60;
                btnFunctie = "Wijzigen";
                btnBevestig.Click += btnBevestig_Click;

                popupForm.Controls.Add(lblTitel);
                popupForm.Controls.Add(lblNaam);
                popupForm.Controls.Add(lblFunctie);
                popupForm.Controls.Add(txtNaam);
                popupForm.Controls.Add(cmbFunctie);
                popupForm.Controls.Add(btnBevestig);

                popupForm.ShowDialog();
            }
            else if (listViewMedewerkers.CheckedItems.Count > 1)
                MessageBox.Show("Te veel items aangevinkt!");
            else
                MessageBox.Show("Geen item aangevinkt!");
            
        }

        private void ToevMenukaartUI()
        {
            Label lblTitel = new Label();
            InitControl(lblTitel, TITELX, TITELY, "Aan menu toevoegen", FNTSIZE, 250);
            lblTitel.Height = 30;

            InitControl(lblMenukaart, LBLX, SPACING * 1, "Menukaart", FNTSIZE, WIDTH);
            InitControl(lblSubcategorie, LBLX, SPACING * 2, "Subcategorie", FNTSIZE, WIDTH);
            InitControl(lblNaam, LBLX, SPACING * 3, "Naam", FNTSIZE, WIDTH);

            InitControl(cmbMenukaart, TBX, SPACING * 1, "Menukaart", FNTSIZE, WIDTH);
            InitControl(cmbSubcategorie, TBX, SPACING * 2, "Subcategorie", FNTSIZE, WIDTH);
            InitControl(txtNaam, TBX, SPACING * 3, "", FNTSIZE, WIDTH);

            cmbMenukaart.Items.Add("Lunch");
            cmbMenukaart.Items.Add("Diner");
            cmbMenukaart.Items.Add("Dranken");

            cmbSubcategorie.Items.Add("Voorgerecht");
            cmbSubcategorie.Items.Add("Hoofdgerecht");
            cmbSubcategorie.Items.Add("Nagerecht");

            InitControl(btnBevestig, 120, 300, "Bevestig", FNTSIZE, 150);
            btnBevestig.Height = 60;

            popupForm.Controls.Add(lblTitel);
            popupForm.Controls.Add(lblMenukaart);
            popupForm.Controls.Add(lblSubcategorie);
            popupForm.Controls.Add(lblNaam);
            popupForm.Controls.Add(cmbMenukaart);
            popupForm.Controls.Add(cmbSubcategorie);
            popupForm.Controls.Add(txtNaam);
            popupForm.Controls.Add(btnBevestig);
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

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem checkedItem in listViewMedewerkers.CheckedItems)
                    {


                        checkedItem.Remove();
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

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {

            }
            //}
        }
    }
}
