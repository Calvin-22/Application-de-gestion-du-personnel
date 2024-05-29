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
    /// formulaire du Personnel
    /// </summary>
    public partial class FrmPersonnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private BindingSource bdgPersonnels = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmPersonnelController controller;

        /// <summary>
        /// Initialisation du formulaire du Personnel
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListePersonnels();
            RemplirListeServices(); 
            EnCoursDeModifPersonnel(false);
        }

        /// <summary>
        /// Afficher les Personnels
        /// </summary>
        private void RemplirListePersonnels()
        {
            List<personnel> LesPersonnels = controller.GetLesPersonnels();
            bdgPersonnels.DataSource = LesPersonnels;
            dgvPersonnel.DataSource = bdgPersonnels;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.Columns["idservice"].Visible = false;
            dgvPersonnel.Columns["service"].Visible = true;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RemplirListeServices()
        {
            List<service> LesServices = controller.GetLesServices();
            bdgServices.DataSource = LesServices;
            comboAffectation.DataSource = bdgServices;
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            
            if (dgvPersonnel.SelectedRows.Count > 0)
            {

                EnCoursDeModifPersonnel(true);
                
                personnel personnel = (personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.nom;
                txtPrenom.Text = personnel.prenom;
                txtTel.Text = personnel.tel;
                txtMail.Text = personnel.mail;
                comboAffectation.SelectedIndex = comboAffectation.FindStringExact(personnel.service.nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }   
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grboxPersonnel.Enabled = !modif;
            if (modif)
            {
                grbAjouter.Text = "Modifier un Personnel";
            }
            else
            {
                grbAjouter.Text = "Ajouter un Personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }
       
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && comboAffectation.SelectedIndex != -1)
            {
                if (enCoursDeModifPersonnel)
                {
                    service service = (service)bdgServices.List[bdgServices.Position];
                    personnel personnel = (personnel)bdgPersonnels.List[bdgPersonnels.Position];
                    personnel.nom = txtNom.Text;
                    personnel.prenom = txtPrenom.Text;
                    personnel.tel = txtTel.Text;
                    personnel.mail = txtMail.Text;
                    personnel.service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                   personnel personnel = new personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, null);
                   controller.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                EnCoursDeModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifPersonnel(false);
            }
        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            this.Hide(); // cacher le formulaire précédent 
            FrmAbsence frm = new FrmAbsence(); // ouvrir nouveau formulaire
            frm.ShowDialog(); // ouverture 
            this.Close(); // fermeture du formulaire caché 
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                personnel personnel = (personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.nom + " " + personnel.prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }
    }
}
