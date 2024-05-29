
    namespace Application_de_gestion_du_personnel.model
{
    /// <summary>
    /// class service correspondant à la table service 
    /// </summary>
    public class service
    {
        /// <summary>
        /// getter/setter idservice
        /// </summary>
        public int idservice { get; }

        /// <summary>
        /// getter/setter nom
        /// </summary>
        public string nom { get; }

        /// <summary>
        /// valorisation des propriétées 
        /// </summary>
        public service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du profil</returns>
        public override string ToString()
        {
            return this.nom;
        }
    }
}
