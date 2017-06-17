using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace UI
{
    public partial class OverzichtRestaurant_Form : UI.Main_Form
    {
        public OverzichtRestaurant_Form()
        {
            InitializeComponent();
            list_tafeloverzicht.View = View.Details;
            list_tafeloverzicht.HideSelection = false;

            Logica.Tafel items = new Logica.Tafel();

            List<Model.Tafel> lijst = new List<Model.Tafel>();
            lijst = items.GetAll();
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {

        }
    }
}
