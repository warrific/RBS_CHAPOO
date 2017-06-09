using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class Bediening_Form : UI.Main_Form
    {
        public Bediening_Form()
        {
            InitializeComponent();
        }
         /*
        public void ZetButtonsInFlowLP(List<ButtonMenuItem> lijstButtons)
        {
            foreach(ButtonMenuItem button in lijstButtons)
            {
                flowLP_MenuItems.Controls.Add(button);
            }
        }
        */
        private void btn_dranken_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();
            
            ButtonSelectie btn_nonalcoholisch = new ButtonSelectie(Categorie.Drank, "nonalcoholisch");
            pnl_optiesbestelling.Controls.Add(btn_nonalcoholisch);
            btn_nonalcoholisch.Text = "Non-Alcoholisch";
            btn_nonalcoholisch.Size = new Size(100, 50);
            btn_nonalcoholisch.Location = new Point(265, 0);

            ButtonSelectie btn_alcoholisch = new ButtonSelectie(Categorie.Drank, "alcoholisch");
            pnl_optiesbestelling.Controls.Add(btn_alcoholisch);
            btn_alcoholisch.Text = "Alcoholisch";
            btn_alcoholisch.Size = new Size(100, 50);
            btn_alcoholisch.Location = new Point(385, 0);
        }

        private void btn_diner_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();

            ButtonSelectie btn_DinerVoor = new ButtonSelectie(Categorie.Diner, "voorgerecht");
            pnl_optiesbestelling.Controls.Add(btn_DinerVoor);
            btn_DinerVoor.Text = "Voorgerecht";
            btn_DinerVoor.Size = new Size(100, 50);
            btn_DinerVoor.Location = new Point(100, 0);

            ButtonSelectie btn_DinerTussen = new ButtonSelectie(Categorie.Diner, "tussengerecht");
            pnl_optiesbestelling.Controls.Add(btn_DinerTussen);
            btn_DinerTussen.Text = "Tussengerecht";
            btn_DinerTussen.Size = new Size(100, 50);
            btn_DinerTussen.Location = new Point(200, 0);

            ButtonSelectie btn_DinerHoofd = new ButtonSelectie(Categorie.Diner, "hoofdgerecht");
            pnl_optiesbestelling.Controls.Add(btn_DinerHoofd);
            btn_DinerHoofd.Text = "Hoofdgerecht";
            btn_DinerHoofd.Size = new Size(100, 50);
            btn_DinerHoofd.Location = new Point(300, 0);

            ButtonSelectie btn_DinerNa = new ButtonSelectie(Categorie.Diner, "nagerecht");
            pnl_optiesbestelling.Controls.Add(btn_DinerNa);
            btn_DinerNa.Text = "Nagerecht";
            btn_DinerNa.Size = new Size(100, 50);
            btn_DinerNa.Location = new Point(400, 0);
        }

        private void btn_lunch_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();

            ButtonSelectie btn_LunchVoor = new ButtonSelectie(Categorie.Lunch, "voorgerecht");
            pnl_optiesbestelling.Controls.Add(btn_LunchVoor);
            btn_LunchVoor.Text = "Voorgerecht";
            btn_LunchVoor.Size = new Size(100, 50);
            btn_LunchVoor.Location = new Point(100, 0);

            ButtonSelectie btn_LunchHoofd = new ButtonSelectie(Categorie.Lunch, "hoofdgerecht");
            pnl_optiesbestelling.Controls.Add(btn_LunchHoofd);
            btn_LunchHoofd.Text = "Hoofdgerecht";
            btn_LunchHoofd.Size = new Size(100, 50);
            btn_LunchHoofd.Location = new Point(200, 0);

            ButtonSelectie btn_LunchNa = new ButtonSelectie(Categorie.Lunch, "nagerecht");
            pnl_optiesbestelling.Controls.Add(btn_LunchNa);
            btn_LunchNa.Text = "Nagerecht";
            btn_LunchNa.Size = new Size(100, 50);
            btn_LunchNa.Location = new Point(300, 0); 
        }

    }
}
