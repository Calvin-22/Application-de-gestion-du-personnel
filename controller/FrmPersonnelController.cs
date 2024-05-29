using Application_de_gestion_du_personnel.dal;
using Application_de_gestion_du_personnel.model;
using System.Collections.Generic;

namespace Application_de_gestion_du_personnel.controller
{
    /// <summary>
    /// Contrôleur de FrmHabilitations
    /// </summary>
    public class FrmPersonnelController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly responsableAccess responsableAccess;
        

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmPersonnelController()
        {
            responsableAccess = new responsableAccess();
          
        }

        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<personnel> GetLesPersonnels()
        {
            return responsableAccess.GetLesPersonnels();
        }

        /// <summary>
        /// récupère et retourne les infos des services
        /// </summary>
        /// <returns></returns>
        public List<service> GetLesServices()
        {
            return responsableAccess.GetlesServices();
        }


        

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="personnel">objet developpeur à supprimer</param>
        public void DelPersonnnel(personnel personnel)
        {
            responsableAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un développeur
        /// </summary>
        /// <param name="personnel">objet developpeur à ajouter</param>
        public void AddPersonnel (personnel personnel)
        {
            responsableAccess.AddPersonnel (personnel);
        }

        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="personnel">objet developpeur à modifier</param>
        public void UpdatePersonnel (personnel personnel)
        {
            responsableAccess.UpdatePersonnel(personnel);
        }

        

    }
}
