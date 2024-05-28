using System;
using Application_de_gestion_du_personnel.dal;
using Application_de_gestion_du_personnel.model;

namespace Application_de_gestion_du_personnel.controller
{
    /// <summary>
    /// Contrôleur de FrmAuthentification
    /// </summary>
    class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly responsableAccess responsableAccess;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            responsableAccess = new responsableAccess();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }

    }
}
