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
using Logica;

namespace UI
{
    public partial class ButtonMenuItemVerlaag : ButtonMenuItem
    {
        

        public ButtonMenuItemVerlaag(Model.MenuItem menuItem) : base(menuItem)
        {
            this.menuItem = menuItem;
            InitializeComponent();
            this.Size = new Size(40, 40);
            this.Text = "-1";
        }
    }
}
