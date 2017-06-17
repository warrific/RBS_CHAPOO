using System.Drawing;

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
            this.BackColor = Color.DarkRed;
            this.ForeColor = Color.White;
        }
    }
}
