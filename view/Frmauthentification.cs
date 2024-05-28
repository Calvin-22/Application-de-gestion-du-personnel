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
    /// formulaire d'authentification
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// Initialisation du formulaire d'absence
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblverif_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Vérification de l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            String login = txtIdentifiant.Text;
            String pwd = txtMDP.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                responsable responsable = new responsable (login, pwd);
                if (controller.ControleAuthentification(responsable))
                {
                    FrmPersonnel frm = new FrmPersonnel();
                    frm.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas un responsable", "Alerte");
                }
            }
        }
    }
}
