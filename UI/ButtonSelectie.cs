﻿using System.Drawing;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class ButtonSelectie : Button
    {
        public MenuKaart hoofdOptie
        {
            get; private set;
        }
        public Categorie subOptie
        {
            get; private set;
        }

        public ButtonSelectie(MenuKaart hoofdOptie, Categorie subOptie)
        {
            this.hoofdOptie = hoofdOptie;
            this.subOptie = subOptie;

            InitializeComponent();

            this.Size = new Size(125, 50);
            this.BackColor = Color.DarkBlue;
            this.ForeColor = Color.White;
            //this.Click += new EventHandler(btn_Click);

        }
        /*
        private void btn_Click(object sender, EventArgs e)
        {
            MenuItems menuItems = new MenuItems();
            
            List<Model.MenuItem> lijstMenuItems = menuItems.make_list();

            List<ButtonMenuItem> lijstButtonMenuItems = new List<ButtonMenuItem>();

            lijstButtonMenuItems.Clear();

            
            FlowLayoutPanel flowLP_menuItems = new FlowLayoutPanel();
            flowLP_menuItems.Location = new Point(0, 209);
            flowLP_menuItems.Width = 751;
            flowLP_menuItems.Height = 177;
            flowLP_menuItems.BackColor = Color.Azure;
            
            
            // filter menu items, maak buttons en zet buttons in lijst
            foreach (Model.MenuItem menuItem in lijstMenuItems)
            {
                if(menuItem.categorie == this.hoofdOptie && menuItem.kaartType == this.subOptie)
                {
                    ButtonMenuItem button = new ButtonMenuItem(menuItem);
                    lijstButtonMenuItems.Add(button);
                }
            }
            

            foreach(ButtonMenuItem button in lijstButtonMenuItems)
            {
                flowLP_menuItems.Controls.Add(button);
            }
            
        }

        public List<ButtonMenuItem> returnLijstMenuItems()
        {
            return lijstButtonMenuItems;
        }
        */
    }
}
