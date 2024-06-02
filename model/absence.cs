
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
        public int idpersonnel { get; set; }

        /// <summary>
        /// class datedebut
        /// </summary>
        public string datedebut { get; set; }

        /// <summary>
        /// class datefin
        /// </summary>
        public string datefin { get; set; }

    
     

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public absence(int idpersonnel, string datedebut, string datefin, motif motif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.motif = motif;
        }

        /// <summary>
        /// Class motif
        /// </summary>
        public motif motif { get;  set; }
    }
}
