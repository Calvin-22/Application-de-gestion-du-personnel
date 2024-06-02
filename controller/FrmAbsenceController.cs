using System;
using System.Collections.Generic;

using Application_de_gestion_du_personnel.dal;
using Application_de_gestion_du_personnel.model;

namespace Application_de_gestion_du_personnel.controller
{
    class FrmAbsenceController
    {

        /// <summary>
        /// objet d'accès aux opérations possibles sur absence
        /// </summary>
        private readonly absenceAccess absenceAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur motif
        /// </summary>
        private readonly motifAccess motifAccess;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmAbsenceController()
        {
            absenceAccess = new absenceAccess();
            motifAccess = new motifAccess();
        }



        /// <summary>
        /// Récupère et retourne les infos des absences
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<absence> GetLesAbsences()
        {
            return absenceAccess.GetLesAbsences();
        }

        /// <summary>
        /// récupère et retourne les infos des motifs
        /// </summary>
        /// <returns></returns>
        public List<motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'un motif
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

         
        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        /// <param name="cible">transport id cible</param>
        public void AddAbsence(int cible, absence absence)
        {
            absenceAccess.AddAbsence(cible, absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }
    }
}
