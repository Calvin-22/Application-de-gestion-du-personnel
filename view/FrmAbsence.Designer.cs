
namespace Application_de_gestion_du_personnel.view
{
    partial class FrmAbsence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbAjouter = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.lblfin = new System.Windows.Forms.Label();
            this.comboAbsence1 = new System.Windows.Forms.ComboBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.grboxAbsence = new System.Windows.Forms.GroupBox();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbAjouter.SuspendLayout();
            this.grboxAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAjouter
            // 
            this.grbAjouter.Controls.Add(this.btnAnnuler);
            this.grbAjouter.Controls.Add(this.btnConfirmer);
            this.grbAjouter.Controls.Add(this.txtFin);
            this.grbAjouter.Controls.Add(this.txtDebut);
            this.grbAjouter.Controls.Add(this.lblAffectation);
            this.grbAjouter.Controls.Add(this.lblfin);
            this.grbAjouter.Controls.Add(this.comboAbsence1);
            this.grbAjouter.Controls.Add(this.lblDebut);
            this.grbAjouter.Location = new System.Drawing.Point(35, 308);
            this.grbAjouter.Name = "grbAjouter";
            this.grbAjouter.Size = new System.Drawing.Size(924, 189);
            this.grbAjouter.TabIndex = 14;
            this.grbAjouter.TabStop = false;
            this.grbAjouter.Text = "Ajouter une Absence";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(154, 140);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(120, 32);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(28, 140);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(120, 32);
            this.btnConfirmer.TabIndex = 10;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(124, 66);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(150, 22);
            this.txtFin.TabIndex = 7;
            // 
            // txtDebut
            // 
            this.txtDebut.Location = new System.Drawing.Point(124, 34);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(150, 22);
            this.txtDebut.TabIndex = 6;
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Location = new System.Drawing.Point(527, 39);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(50, 17);
            this.lblAffectation.TabIndex = 5;
            this.lblAffectation.Text = "Motif : ";
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.Location = new System.Drawing.Point(25, 66);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(69, 17);
            this.lblfin.TabIndex = 2;
            this.lblfin.Text = "Date Fin :";
            // 
            // comboAbsence1
            // 
            this.comboAbsence1.FormattingEnabled = true;
            this.comboAbsence1.Location = new System.Drawing.Point(583, 34);
            this.comboAbsence1.Name = "comboAbsence1";
            this.comboAbsence1.Size = new System.Drawing.Size(150, 24);
            this.comboAbsence1.TabIndex = 8;
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(25, 34);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(86, 17);
            this.lblDebut.TabIndex = 1;
            this.lblDebut.Text = "Date début :";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(43, 270);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 32);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(170, 270);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 32);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(848, 270);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(111, 32);
            this.btnAccueil.TabIndex = 11;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // grboxAbsence
            // 
            this.grboxAbsence.Controls.Add(this.dgvAbsences);
            this.grboxAbsence.Location = new System.Drawing.Point(35, 19);
            this.grboxAbsence.Name = "grboxAbsence";
            this.grboxAbsence.Size = new System.Drawing.Size(621, 245);
            this.grboxAbsence.TabIndex = 10;
            this.grboxAbsence.TabStop = false;
            this.grboxAbsence.Text = "Absence";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(8, 21);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 51;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.Size = new System.Drawing.Size(603, 205);
            this.dgvAbsences.TabIndex = 2;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 517);
            this.Controls.Add(this.grbAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.grboxAbsence);
            this.Name = "FrmAbsence";
            this.Text = "Gestion des absences";
            this.grbAjouter.ResumeLayout(false);
            this.grbAjouter.PerformLayout();
            this.grboxAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.Label lblfin;
        private System.Windows.Forms.ComboBox comboAbsence1;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.GroupBox grboxAbsence;
        private System.Windows.Forms.DataGridView dgvAbsences;
    }
}