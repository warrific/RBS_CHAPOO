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
        public Model.MenuItem menuItem
        {
            get; private set;
        }


        public ButtonMenuItem(Model.MenuItem bestelItem)
        {
            this.menuItem = bestelItem;

            InitializeComponent();

            this.Size = new Size(125, 50);
            this.Text = bestelItem.shortname;

            this.Click += new EventHandler(btn_Click);

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
