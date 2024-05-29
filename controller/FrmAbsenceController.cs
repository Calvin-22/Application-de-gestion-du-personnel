using System;
using System.Collections.Generic;

using Application_de_gestion_du_personnel.dal;
using Application_de_gestion_du_personnel.model;

namespace Application_de_gestion_du_personnel.controller
{
    class FrmAbsenceController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly responsableAccess responsableAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly absenceAccess absenceAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly motifAccess motifAccess;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmAbsenceController()
        {
            responsableAccess = new responsableAccess();
            absenceAccess = new absenceAccess();
            motifAccess = new motifAccess();
        }



        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<absence> GetLesAbsences()
        {
            return absenceAccess.GetLesAbsences();
        }

        /// <summary>
        /// récupère et retourne les infos des services
        /// </summary>
        /// <returns></returns>
        public List<motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="absence">objet developpeur à supprimer</param>
        public void DelAbsence(absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'un développeur
        /// </summary>
        /// <param name="absence">objet developpeur à ajouter</param>
        public void AddAbsence(absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="absence">objet developpeur à modifier</param>
        public void UpdateAbsence(absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }




    }
}
