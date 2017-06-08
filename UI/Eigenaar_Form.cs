using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Eigenaar_Form : UI.Main_Form
    {
        public Eigenaar_Form()
        {
            InitializeComponent();
        }
        private void Voorraad_Form_Load()
        {

        }

        private void btnVoorraad_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            lblTitel.Text = "Voorraad";

            Button btnToevoegen = new Button();
            btnToevoegen.Text = "... Toevoegen";
            btnToevoegen.Location = new Point(420, 0);
            btnToevoegen.AutoSize = true;

            panel2.Controls.Add(btnToevoegen);
        }

        private void btnMedewerkers_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            lblTitel.Text = "Medewerkers";
        }

        private void btnMenuItems_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            lblTitel.Text = "Menu-items";
        }
    }
}
