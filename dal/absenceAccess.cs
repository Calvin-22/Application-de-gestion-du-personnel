using System;
using System.Collections.Generic;
using Application_de_gestion_du_personnel.model;

namespace Application_de_gestion_du_personnel.dal
{
    class absenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public absenceAccess()
        {
            access = Access.GetInstance();
        }

        
        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<absence> GetLesAbsences()
        {
            List<absence> lesAbsences = new List<absence>();
            if (access.Manager != null)
            {
                
                string req = "select d.idpersonnel as idpersonnel, d.datedebut as datedebut, d.datefin as datefin, p.idmotif as idmotif, p.libelle as motif "; //ou p.nom as motif?
                req += "from absence d join motif p on (d.idmotif = p.idmotif) ";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            
                            DateTime dateDebut = (DateTime)record[1];
                            DateTime dateFin = (DateTime)record[2];

                            // Convertir les dates en chaînes de caractères
                            string dateDebutStr = dateDebut.ToString("yyyy-MM-dd HH:mm:ss");
                            string dateFinStr = dateFin.ToString("yyyy-MM-dd HH:mm:ss");

                            motif motif = new motif((int)record[5], (string)record[6]);
                            absence absence = new absence((int)record[0], dateDebutStr, dateFinStr, motif);
                            lesAbsences.Add(absence);

                            //motif motif = new motif((int)record[0], (string)record[1]);
                            //absence absence = new absence((int)record[0], record[1].ToString(), record[2].ToString(), motif);
                            //lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }


        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet personnel à supprimer</param>
        public void DelAbsence(absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.idpersonnel);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet personnel à ajouter</param>
        public void AddAbsence(absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence (idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.idpersonnel);
                parameters.Add("@datedebut", absence.datedebut);
                parameters.Add("@datefin", absence.datefin);
                parameters.Add("@idmotif", absence.motif.idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet personnel à modifier</param>
        public void UpdateAbsence(absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", absence.idpersonnel);
                parameters.Add("@nom", absence.datedebut);
                parameters.Add("@prenom", absence.datefin);
                parameters.Add("@idmotif", absence.motif.idmotif);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
