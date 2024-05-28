
namespace Application_de_gestion_du_personnel.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations des absences
    /// </summary>
    public class absence
    {
        /// <summary>
        /// class idpersonnel
        /// </summary>
        public int idpersonnel { get; }

        /// <summary>
        /// class datedebut
        /// </summary>
        public string datedebut { get; }

        /// <summary>
        /// class datefin
        /// </summary>
        public string datefin { get; }

        /// <summary>
        /// class idmotif
        /// </summary>
        public int idmotif { get; }
     

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public absence(int idpersonnel, string datedebut, string datefin, int idmotif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idmotif = idmotif;
        }
    }
}
