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
    public partial class StatusChange_Form : UI.Main_Form
    {
        public StatusChange_Form()
        {
            InitializeComponent();
            Size = new Size(768, 1024);

        }

        string tafelstatus;
        string bestellingsstatus;
        string categorie;

        public string TafelStatus
        {
            get { return tafelstatus ; }
        }

        public string BestellingsStatus
        {
            get{ return bestellingsstatus;}
        }

        public string Categorie
        {
            get { return categorie; }

        }

        // Even this could be removed, if you set this button as the Accept
        //  button on the Form, or set a DialogResult value on the button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioBtn_vrij_CheckedChanged(object sender, EventArgs e)
        {
            tafelstatus = "vrij";
        }

        private void radioBtn_bezet_CheckedChanged(object sender, EventArgs e)
        {
            tafelstatus = "bezet";
        }

        private void radioBtn_open_CheckedChanged(object sender, EventArgs e)
        {
            bestellingsstatus = "open";
        }

        private void radioBtn_gereed_CheckedChanged(object sender, EventArgs e)
        {
            bestellingsstatus = "gereed";
        }

        private void radioBtn_lunch_CheckedChanged(object sender, EventArgs e)
        {
            categorie = "lunch";
        }

        private void radioBtn_diner_CheckedChanged(object sender, EventArgs e)
        {
            categorie = "diner";
        }

        private void radioBtn_drank_CheckedChanged(object sender, EventArgs e)
        {
            categorie = "drank";
        }


        private void btn_save_Click(object sender, EventArgs e)
        {

            if (radioBtn_vrij.Checked)
            {
                tafelstatus = radioBtn_vrij.Text;
            }
            else
            {
                tafelstatus = radioBtn_bezet.Text;
            }
            
            if(radioBtn_open.Checked)
            {
                bestellingsstatus = radioBtn_open.Text;
            }

            else
            {
                bestellingsstatus = radioBtn_gereed.Text;
            }

            if(radioBtn_lunch.Checked)
            {
                categorie = radioBtn_lunch.Text;
            }
            
            else if (radioBtn_diner.Checked)
            {
                categorie = radioBtn_diner.Text;
            }
            
            else
            {
                categorie = radioBtn_drank.Text;
            }


            //Obj_Ovz_Rest.ShowDialog();
               //string invoer1 = TafelStatus;
              // string invoer2 = BestellingsStatus;
              // string invoer3 = Categorie;
              // List<string> status_lijst = new List<string>();
              // status_lijst.Add(invoer1);
              // status_lijst.Add(invoer2);
              // status_lijst.Add(invoer3);
                 
              //  Logica.RestaurantOverzicht restaurantoverzicht = new Logica.RestaurantOverzicht();
              //  restaurantoverzicht.AddGegevens(status_lijst);

        }

        
    }
}
