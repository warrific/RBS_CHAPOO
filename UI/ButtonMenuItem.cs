using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class ButtonMenuItem : Button
    {
        Model.MenuItem bestelItem;


        public ButtonMenuItem(Model.MenuItem bestelItem)
        {
            this.bestelItem = bestelItem;

            InitializeComponent();

            this.Size = new Size(125, 50);            // Uitgecomment omdat het een error gaf, dit word iets anders. bestelitem krijgt de klasse menu item in zich, dus het word iets van bestelItem.MenuItem.naam            //this.Text = bestelItem.naam;            this.Click += new EventHandler(btn_Click);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
