using Application_de_gestion_du_personnel.model;
using System;
using System.Collections.Generic;

namespace Application_de_gestion_du_personnel.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les developpeurs
    /// </summary>
    public class responsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public responsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utillisateur a le droit de se connecter (identifiant, pwd)
        /// </summary>
        /// <param name="responsable"></param>
        
        /// <returns>vrai si l'utilisateur a le profil "responsable"</returns>
        public Boolean ControleAuthentification(responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable ";
                req += "where login=@login and pwd=@pwd";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", responsable.login);
                parameters.Add("@pwd", responsable.pwd);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }

        /// <summary>
        /// Récupère et retourne les personnels
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<personnel> GetLesPersonnels()
        {
            List<personnel> lesPersonnels = new List<personnel>();
            if (access.Manager != null)
            {
                string req = "select d.idpersonnel as idpersonnel, d.nom as nom, d.prenom as prenom, d.tel as tel, d.mail as mail ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            personnel personnel = new personnel ((int)record[0], (string)record[1], (string)record[2],
                                (int)record[3], (string)record[4], (int)record[5]);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.idpersonnel);
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
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à ajouter</param>
        public void AddPersonnel(personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel (idpersonnel, nom, prenom, tel, mail, idservice) ";
                req += "values (@idpersonnel, @nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.idpersonnel);
                parameters.Add("@nom", personnel.nom);
                parameters.Add("@prenom", personnel.prenom);
                parameters.Add("@tel", personnel.tel);
                parameters.Add("@mail", personnel.mail);
                parameters.Add("@idservice", personnel.idservice);
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
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set idpersonnel = @idpersonnel, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.idpersonnel);
                parameters.Add("@nom", personnel.nom);
                parameters.Add("@prenom", personnel.prenom);
                parameters.Add("@tel", personnel.tel);
                parameters.Add("@mail", personnel.mail);
                parameters.Add("idservice", personnel.idservice);
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
