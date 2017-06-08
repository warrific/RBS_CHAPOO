using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Bediening_Form : UI.Main_Form
    {
        public Bediening_Form()
        {
            InitializeComponent();
        }

        private void btn_lunch_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
        }

        private void btn_dranken_Click(object sender, EventArgs e)
        {

        }
    }
}
