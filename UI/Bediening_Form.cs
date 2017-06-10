//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using Model;
//using Logica;
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
    public partial class Bediening_Form : UI.Main_Form
    {
        public Bediening_Form()
        {
            InitializeComponent();
        }

        private void btn_dranken_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();

            Button btn_nonalcoholisch = new Button();
            pnl_optiesbestelling.Controls.Add(btn_nonalcoholisch);
            btn_nonalcoholisch.Text = "Non-Alcoholisch";
            btn_nonalcoholisch.Size = new Size(100, 50);
            btn_nonalcoholisch.Location = new Point(265, 0);

            Button btn_alcoholisch = new Button();
            pnl_optiesbestelling.Controls.Add(btn_alcoholisch);
            btn_alcoholisch.Text = "Alcoholisch";
            btn_alcoholisch.Size = new Size(100, 50);
            btn_alcoholisch.Location = new Point(385, 0);
        }

        private void btn_diner_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();

            Button btn_DinerVoor = new Button();
            pnl_optiesbestelling.Controls.Add(btn_DinerVoor);
            btn_DinerVoor.Text = "Voorgerecht";
            btn_DinerVoor.Size = new Size(100, 50);
            btn_DinerVoor.Location = new Point(100, 0);

            Button btn_DinerTussen = new Button();
            pnl_optiesbestelling.Controls.Add(btn_DinerTussen);
            btn_DinerTussen.Text = "Tussengerecht";
            btn_DinerTussen.Size = new Size(100, 50);
            btn_DinerTussen.Location = new Point(200, 0);

            Button btn_DinerHoofd = new Button();
            pnl_optiesbestelling.Controls.Add(btn_DinerHoofd);
            btn_DinerHoofd.Text = "Hoofdgerecht";
            btn_DinerHoofd.Size = new Size(100, 50);
            btn_DinerHoofd.Location = new Point(300, 0);

            Button btn_DinerNa = new Button();
            pnl_optiesbestelling.Controls.Add(btn_DinerNa);
            btn_DinerNa.Text = "Nagerecht";
            btn_DinerNa.Size = new Size(100, 50);
            btn_DinerNa.Location = new Point(400, 0);
        }

        private void btn_lunch_Click(object sender, EventArgs e)
        {
            pnl_optiesbestelling.Controls.Clear();

            Button btn_LunchVoor = new Button();
            pnl_optiesbestelling.Controls.Add(btn_LunchVoor);
            btn_LunchVoor.Text = "Voorgerecht";
            btn_LunchVoor.Size = new Size(100, 50);
            btn_LunchVoor.Location = new Point(100, 0);
            
            Button btn_LunchHoofd = new Button();
            pnl_optiesbestelling.Controls.Add(btn_LunchHoofd);
            btn_LunchHoofd.Text = "Hoofdgerecht";
            btn_LunchHoofd.Size = new Size(100, 50);
            btn_LunchHoofd.Location = new Point(200, 0);

            Button btn_LunchNa = new Button();
            pnl_optiesbestelling.Controls.Add(btn_LunchNa);
            btn_LunchNa.Text = "Nagerecht";
            btn_LunchNa.Size = new Size(100, 50);
            btn_LunchNa.Location = new Point(300, 0); 
        }

    }
}
