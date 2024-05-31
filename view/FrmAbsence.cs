using System;
using System.Collections.Generic;
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
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des développeurs
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmAbsenceController controller;


        /// <summary>
        /// Initialisation du formulaire d'absence
        /// </summary>
        public FrmAbsence()
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
            controller = new FrmAbsenceController();
            RemplirListeAbsences();
            RemplirListeMotifs();
            EnCoursDeModifAbsence(false);

        }

        /// <summary>
        /// Afficher les Absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            List<absence> LesAbsences = controller.GetLesAbsences();
            bdgAbsences.DataSource = LesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = true;
            dgvAbsences.Columns["motif"].Visible = true;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RemplirListeMotifs()
        {
            List<motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            comboAbsence1.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click1(object sender, EventArgs e)
        {

            if (dgvAbsences.SelectedRows.Count > 0)
            {

                EnCoursDeModifAbsence(true);

                absence absence = (absence)bdgAbsences.List[bdgAbsences.Position];
                txtDebut.Text = absence.datedebut;
                txtFin.Text = absence.datefin;
                comboAbsence1.SelectedIndex = comboAbsence1.FindStringExact(absence.motif.libelle);
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
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grboxAbsence.Enabled = !modif;
            if (modif)
            {
                grbAjouter.Text = "Modifier une Absence";
            }
            else
            {
                grbAjouter.Text = "Ajouter une Absence";
                txtDebut.Text = "";
                txtFin.Text = "";
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (!txtDebut.Text.Equals("") && !txtFin.Text.Equals("") && comboAbsence1.SelectedIndex != -1)
            {
                motif motif = (motif)bdgMotifs.List[bdgMotifs.Position];
                if (enCoursDeModifAbsence)
                {
                   
                    absence absence = (absence)bdgAbsences.List[bdgAbsences.Position];
                    absence.datedebut = txtDebut.Text;
                    absence.datefin = txtFin.Text;
                    absence.motif = motif;
                    controller.UpdateAbsence(absence);
                }
                else
                {
                    absence absence = new absence(0, txtDebut.Text, txtFin.Text, motif);
                    controller.AddAbsence(absence);
                }
                RemplirListeAbsences();
                EnCoursDeModifAbsence(false);
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
                EnCoursDeModifAbsence(false);
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
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                absence absence = (absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + absence.datedebut + " " + absence.datefin + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
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

    }   
}
