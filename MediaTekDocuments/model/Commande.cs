﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Commande
    {
        public string Id { get; set; }
        public DateTime DateCommande { get; set; }

        public double Montant { get; set; }



    public Commande(string id,DateTime DateCommande, double Montant)
        {
            this.Id = id;
            this.DateCommande = DateCommande;
            this.Montant = Montant;

        }


        public Commande()
        {
            
        }
    }

}
