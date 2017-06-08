using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class RestaurantOverzicht_Form : UI.Main_Form
    {
        public RestaurantOverzicht_Form()
        {
            InitializeComponent();
            Writeonimage();
        }

        private void Writeonimage()
        {
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString("1", font, Brushes.Black, new Point(0, 0));

        }
        
        
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
