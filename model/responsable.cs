
namespace Application_de_gestion_du_personnel.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations d'authentification
    /// </summary>
    public class responsable
    {
        public string identifiant { get; }
        public string Pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="identifiant"></param>
        /// <param name="pwd"></param>
        public responsable(string identifiant, string pwd)
        {
            this.identifiant = identifiant;
            this.Pwd = pwd;
        }
    }
}
