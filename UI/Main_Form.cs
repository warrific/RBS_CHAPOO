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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(179, 179, 179);
            Size = new Size(768, 1024);

            //lbl_naam.Text = naam;
            //lbl_functie.Text = functie;
            //lbl_naam.Text = naam;
            //lbl_functie.Text = functie;

            // lijst halen van de Logica laag
            //Werknemers werknemer = new Werknemers();
            //List<Model.Werknemer> lijst = new List<Model.Werknemer>();
            //lijst = werknemer.make_list();

            //Login login = new Login();

            //foreach (Model.Werknemer list_item in lijst)
            //{
            //    list_item.Id.ToString();
            //    list_item.functie.ToString();
            //    list_item.Wachtwoord.ToString();

            //    for (int i = 0; i < 12; i++)
            //    {

            //        if (list_item.Id == i)
            //        {
            //            lbl_naam.Text = list_item.naam;
            //            lbl_functie.Text = list_item.functie.ToString();
            //            return;
            //        }
            //    }

            //}

            //}

            //MenuItems menuitems = new MenuItems();

            //List<Model.MenuItem> lijst = new List<Model.MenuItem>();
            //lijst = menuitems.make_list();

            //    foreach (Model.MenuItem list_item in lijst)
            //    {
            //      ListViewItem id = new ListViewItem(list_item.id.ToString());
            //ListViewItem naam = new ListViewItem(list_item.naam.ToString());
            //ListViewItem prijs = new ListViewItem(list_item.prijs.ToString());
            //ListViewItem voorraad = new ListViewItem(list_item.voorraad.ToString());
            //ListViewItem shortname = new ListViewItem(list_item.shortname.ToString());

            //list_drankorders.Items.Add(id);
            //      list_drankorders.Items.Add(naam);
            //      list_drankorders.Items.Add(prijs);
            //      list_drankorders.Items.Add(voorraad);
            //      list_drankorders.Items.Add(shortname);
            //    }
        }

    private void btn_LogUit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form obj_loginform = new Login_Form();
            obj_loginform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OverzichtRestaurant_Form obj_ovz_restaurant = new OverzichtRestaurant_Form();
            obj_ovz_restaurant.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_naam_Click(object sender, EventArgs e)
        {

        }

    }
}
