
namespace Application_de_gestion_du_personnel.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations du personnel
    /// </summary>
    public class personnel
    {
        public int idpersonnel { get; }
        public string nom { get; }
        public string prenom { get; }
        public int tel { get; }
        public string mail { get; }
        public int idservice { get; }

        /// <summary>
        /// Valorise les propriété
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        ///<param name="prenom"></param>
        ///<param name="tel"></param>
        ///<param name="mail"></param>
        /// <param name="idservice"></param>
        public personnel(int idpersonnel, string nom, string prenom, int tel, string mail, int idservice)
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
