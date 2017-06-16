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
            get; protected set;
        }


        public ButtonMenuItem(Model.MenuItem menuItem)
        {
            this.menuItem = menuItem;

            InitializeComponent();
            this.BackColor = Color.DarkGreen;
            this.ForeColor = Color.White;
            this.Size = new Size(125, 40);
            this.Text = menuItem.shortname;
        }
    }
}
