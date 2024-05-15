using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }


        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// getter sur la liste des commandes
        /// </summary>
        /// <returns>Liste d'objets commande</returns>
        public List<Commande> GetAllCommandes()
        {
            return access.GetAllCommandes();
        }


        /// <summary>
        /// getter sur la liste des commandes complete
        /// </summary>
        /// <returns>Liste d'objets commande complete</returns>
        public List<CommandeComplete> GetAllCommandesComplete()
        {
            return access.GetAllCommandesComplete();
        }

        /// <summary>
        /// Crée une commande d'un livre dans la bdd
        /// </summary>
        /// <param name="commande">L'objet Commande concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommande(Commande commande)
        {
            return access.CreerCommande(commande);
        }

        /// <summary>
        /// Crée une commandedocument d'un livre ou dvd dans la bdd
        /// </summary>
        /// <param name="commandedocument">L'objet CommandeDocument concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerCommandeDocument(CommandeDocument commandedocument)
        {
            return access.CreerCommandeDocument(commandedocument);
        }

        /// <summary>
        /// getter sur la liste des exemplaires
        /// </summary>
        /// <returns>Liste d'objets exemplaires</returns>
        public List<Exemplaire> GetAllExemplaires()
        {
            return access.GetAllExemplaires();
        }

        /// <summary>
        /// getter sur la liste des suivis
        /// </summary>
        /// <returns>Liste d'objets suivi</returns>
        public List<Suivi> GetAllSuivi()
        {
            return access.GetAllSuivi();
        }

        /// <summary>
        /// Supprime une commandedocument dans la bdd
        /// </summary>
        /// <param name="commandedocument">L'objet commandedocument concerné</param>
        /// <returns>True si la mise à jour a pu se faire</returns>
        public bool UpdateCommandeDocument(CommandeDocument commandedocument)
        {
            return access.UpdateCommandeDocument(commandedocument);
        }

        public bool DeleteCommandeDocument(CommandeDocument commandedocument)
        {
            return access.DeleteCommandeDocument(commandedocument);
        }


    }
}
