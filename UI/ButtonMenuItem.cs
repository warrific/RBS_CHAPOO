﻿using System;
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
        BestelItem bestelItem;


        public ButtonMenuItem(BestelItem bestelItem)
        {
            this.bestelItem = bestelItem;

            InitializeComponent();

            this.Size = new Size(125, 50);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}