using Application_de_gestion_du_personnel.dal;
using Application_de_gestion_du_personnel.model;
using System.Collections.Generic;

namespace Application_de_gestion_du_personnel.controller
{
    /// <summary>
    /// Contrôleur de FrmHabilitations
    /// </summary>
    public class FrmHabilitationsController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly responsableAccess responsableAccess;
        

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmHabilitationsController()
        {
            responsableAccess = new responsableAccess();
          
        }

        /// <summary>
        /// Récupère et retourne les infos des développeurs
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<personnel> GetLesPersonnels()
        {
            return responsableAccess.GetLesPersonnels();
        }

        

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à supprimer</param>
        public void DelPersonnnel(personnel personnel)
        {
            responsableAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à ajouter</param>
        public void AddPersonnel (personnel personnel)
        {
            responsableAccess.AddPersonnel (personnel);
        }

        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à modifier</param>
        public void UpdatePersonnel (personnel personnel)
        {
            responsableAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande de changement de pwd
        /// </summary>
        /// <param name="developpeur">objet developpeur avec nouveau pwd</param>
        public void UpdatePwd(personnel personnel)
        {
            responsableAccess.UpdatePwd(personnel);
        }

    }
}
