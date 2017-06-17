using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(179, 179, 179);
            Size = new Size(768, 1024);
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
