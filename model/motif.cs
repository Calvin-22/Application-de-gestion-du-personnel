
namespace Application_de_gestion_du_personnel.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations de la table motif
    /// </summary>
    public class motif
    {
        /// <summary>
        /// class idmotif
        /// </summary>
        public int idmotif { get; }

        /// <summary>
        /// class libelle
        /// </summary>
        public string libelle { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le libelle)
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
