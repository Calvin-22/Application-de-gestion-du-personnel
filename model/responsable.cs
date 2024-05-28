
namespace Application_de_gestion_du_personnel.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations d'authentification
    /// </summary>
    public class responsable
    {
        /// <summary>
        /// class identifiant
        /// </summary>
        public string login { get; }

        /// <summary>
        /// class pwd, mot de passe
        /// </summary>
        public string pwd { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
