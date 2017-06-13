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
//Extra toekomstige functionaliteiten: refresh, undo, waarschuwing niets geselecteerd

namespace UI
{
    public partial class Eigenaar_Form : UI.Main_Form
    {
        Form popupForm = new Form();

        //Standards
        int titelx = 75;
        int titely = 10;
        int lblx = 20;
        int tbx = 200;
        int spacing = 45;
        int fntSize = 15;
        int width = 150;

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
            //listViewMedewerkers.Columns.Add("Voornaam", 150);
            //listViewMedewerkers.Columns.Add("Achternaam", 150);
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

        TextBox txtNaam = new TextBox();
        ComboBox cmbFunctie = new ComboBox();
        TextBox txtCode = new TextBox();

        private void ToevMedwUI()
        {
            Label lblTitel = new Label();
            InitControl(lblTitel, titelx, titely, "Medewerker Toevoegen", fntSize, 250);
            lblTitel.Height = 30;

            Label lblNaam = new Label();
            Label lblAchternaam = new Label();
            Label lblFunctie = new Label();
            Label lblCode = new Label();
            InitControl(lblNaam, lblx, spacing * 1, "Naam", fntSize, width);
            InitControl(lblFunctie, lblx, spacing * 3, "Functie", fntSize, width);
            InitControl(lblCode, lblx, spacing * 4, "Code", fntSize, width);

            //Original textbox creation

            InitControl(txtNaam, tbx, spacing * 1, "", fntSize, width);
            InitControl(cmbFunctie, tbx, spacing * 3, "Functie", fntSize, width);
            InitControl(txtCode, tbx, spacing * 4, "", fntSize, width);

            cmbFunctie.Items.Add("Bediening");
            cmbFunctie.Items.Add("Kok");
            cmbFunctie.Items.Add("Barman");
            cmbFunctie.Items.Add("Sommelier");
            cmbFunctie.Items.Add("Eigenaar");

            Button btnBevestig = new Button();

            InitControl(btnBevestig, 120, 300, "Bevestig", fntSize, 150);
            btnBevestig.Height = 60;
            btnBevestig.Click += btnBevestig_Click;

            popupForm.Controls.Add(lblTitel);
            popupForm.Controls.Add(lblNaam);
            popupForm.Controls.Add(lblFunctie);
            popupForm.Controls.Add(lblCode);
            popupForm.Controls.Add(txtNaam);
            popupForm.Controls.Add(cmbFunctie);
            popupForm.Controls.Add(txtCode);
            popupForm.Controls.Add(btnBevestig);
        }
        private void btnBevestig_Click(object sender, EventArgs e)
        {
            Werknemers werknemers = new Werknemers();

            string naam = txtNaam.Text;
            string functie = cmbFunctie.Text;
            int code = int.Parse(txtCode.Text);

            werknemers.ToevoegenWerknemer(naam, functie, code);

            RefreshMedewerkers();

            popupForm.Close();
        }

        private void WijzMedwUI()
        {
            foreach (ListViewItem checkedItem in listViewMedewerkers.CheckedItems)
            {
                MenuItems menuitems = new MenuItems();

                int id = int.Parse(checkedItem.SubItems[0].Text);

            }
            Label lblTitel = new Label();
            InitControl(lblTitel, titelx, titely, "Medewerker Wijzigen", fntSize, 250);
            lblTitel.Height = 30;

            Label lblNaam = new Label();
            Label lblFunctie = new Label();
            InitControl(lblNaam, lblx, spacing * 1, "Naam", fntSize, width);
            InitControl(lblFunctie, lblx, spacing * 3, "Functie", fntSize, width);

            InitControl(txtNaam, tbx, spacing * 1, "", fntSize, width);
            InitControl(cmbFunctie, tbx, spacing * 3, "Functie", fntSize, width);

            cmbFunctie.Items.Add("Bediening");
            cmbFunctie.Items.Add("Kok");
            cmbFunctie.Items.Add("Barman");
            cmbFunctie.Items.Add("Sommelier");
            cmbFunctie.Items.Add("Eigenaar");

            Button btnBevestig = new Button();

            InitControl(btnBevestig, 120, 300, "Bevestig", fntSize, 150);
            btnBevestig.Height = 60;
            

            popupForm.Controls.Add(lblTitel);
            popupForm.Controls.Add(lblNaam);
            popupForm.Controls.Add(lblFunctie);
            popupForm.Controls.Add(txtNaam);
            popupForm.Controls.Add(cmbFunctie);
            popupForm.Controls.Add(btnBevestig);
        }

        private void ToevMenukaartUI()
        {
            Label lblTitel = new Label();
            InitControl(lblTitel, titelx, titely, "Aan menu toevoegen", fntSize, 250);
            lblTitel.Height = 30;

            Label lblMenukaart = new Label();
            Label lblSubcategorie = new Label();
            Label lblNaam = new Label();
            InitControl(lblMenukaart, lblx, spacing * 1, "Menukaart", fntSize, width);
            InitControl(lblSubcategorie, lblx, spacing * 2, "Subcategorie", fntSize, width);
            InitControl(lblNaam, lblx, spacing * 3, "Naam", fntSize, width);

            ComboBox cmbMenukaart = new ComboBox();
            ComboBox cmbSubcategorie = new ComboBox();
            TextBox txtNaam = new TextBox();

            InitControl(cmbMenukaart, tbx, spacing * 1, "Menukaart", fntSize, width);
            InitControl(cmbSubcategorie, tbx, spacing * 2, "Subcategorie", fntSize, width);
            InitControl(txtNaam, tbx, spacing * 3, "", fntSize, width);

            cmbMenukaart.Items.Add("Lunch");
            cmbMenukaart.Items.Add("Diner");
            cmbMenukaart.Items.Add("Dranken");

            cmbSubcategorie.Items.Add("Voorgerecht");
            cmbSubcategorie.Items.Add("Hoofdgerecht");
            cmbSubcategorie.Items.Add("Nagerecht");

            Button btnBevestig = new Button();

            InitControl(btnBevestig, 120, 300, "Bevestig", fntSize, 150);
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

            popupForm.ShowDialog();
        }

        private void btnWijzMedw_Click(object sender, EventArgs e)
        {
            InitPopupForm();

            popupForm.Controls.Clear();

            WijzMedwUI();

            popupForm.ShowDialog();
        }

        private void btnVerwMedw_Click(object sender, EventArgs e)
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
            string message = "Weet u zeker dat u dit menu-item wilt verwijderen?";
            string caption = "Waarschuwing";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                
            }
        }
    }
}
