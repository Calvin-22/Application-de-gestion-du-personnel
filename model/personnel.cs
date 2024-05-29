
namespace Application_de_gestion_du_personnel.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations du personnel
    /// </summary>
    public class personnel
    {
        /// <summary>
        /// class idpersonnel
        /// </summary>
        public int idpersonnel { get; set;  }

        /// <summary>
        /// class nom
        /// </summary>
        public string nom { get; set; }

        /// <summary>
        /// class prenom
        /// </summary>
        public string prenom { get; set; }

        /// <summary>
        /// class tel
        /// </summary>
        public string tel { get; set;  }

        /// <summary>
        /// class mail
        /// </summary>
        public string mail { get; set; }

        /// <summary>
        /// class idservice
        /// </summary>
        public int idservice { get; set; }

        /// <summary>
        /// Valorise les propriété
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        ///<param name="prenom"></param>
        ///<param name="tel"></param>
        ///<param name="mail"></param>
        /// <param name="idservice"></param>
        public personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
        }
    }
}
