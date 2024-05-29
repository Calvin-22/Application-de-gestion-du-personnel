using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Application_de_gestion_du_personnel.controller;
using Application_de_gestion_du_personnel.model;

namespace Application_de_gestion_du_personnel.view
{
    /// <summary>
    /// formulaire d'absence
    /// </summary>
    public partial class FrmAbsence : Form
    {

       
        /// <summary>
        /// Initialisation du formulaire d'absence
        /// </summary>
        public FrmAbsence()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// Retour à l'accueil des personnels, fermeture de la fenêtre absence. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPersonnel frm = new FrmPersonnel();
            frm.ShowDialog();
            this.Close();
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }
    }
}
