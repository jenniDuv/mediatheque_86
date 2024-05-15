using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class CommandeComplete
    {
        public string Id { get; set; }
        public DateTime DateCommande { get; set; }

        public double Montant { get; set; }

        public int NbExemplaire { get; set; }

        public string Etape { get; set; }

        public string IdLivreDvd { get; set; }




        public CommandeComplete(string id, DateTime dateCommande, double montant, int nbExemplaire, string idLivreDvd, string etape)
        {
            this.Id = id;
            this.DateCommande = dateCommande;
            this.Montant = montant;
            NbExemplaire = nbExemplaire;
            IdLivreDvd = idLivreDvd;
            Etape = etape;


        }




    }
}
