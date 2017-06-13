﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {

        public int id { get; private set; }
        public string naam { get; private set; }
        public double prijs { get; private set; }
        public int voorraad { get; private set; }
        public Categorie KaartType { get; private set; }

        public string shortname { get; private set; }

        public SubCategorie subCategorie
        {
            get; private set;
        }

        public MenuItem(int id_in, string naam_in, double prijs_in, int voorraad_in, Categorie kaartType, string shortname_in, SubCategorie subCategorie)
        {
            id = id_in;
            naam = naam_in;
            prijs = prijs_in;
            voorraad = voorraad_in;
            this.KaartType = KaartType;
            shortname = shortname_in;
            this.subCategorie = subCategorie;
        }

        public void ToonAlleMenuItems()
        {

        }
    }
}
