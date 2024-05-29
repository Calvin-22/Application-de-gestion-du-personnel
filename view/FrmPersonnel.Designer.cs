
namespace Application_de_gestion_du_personnel.view
{
    partial class FrmPersonnel
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
            this.grboxPersonnel = new System.Windows.Forms.GroupBox();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grbAjouter = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblAffectation = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.comboAffectation = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.grboxPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbAjouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grboxPersonnel
            // 
            this.grboxPersonnel.Controls.Add(this.dgvPersonnel);
            this.grboxPersonnel.Location = new System.Drawing.Point(29, 38);
            this.grboxPersonnel.Name = "grboxPersonnel";
            this.grboxPersonnel.Size = new System.Drawing.Size(924, 245);
            this.grboxPersonnel.TabIndex = 2;
            this.grboxPersonnel.TabStop = false;
            this.grboxPersonnel.Text = "Personnel";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(8, 21);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(903, 205);
            this.dgvPersonnel.TabIndex = 2;
            // 
            // btnAbsence
            // 
            this.btnAbsence.Location = new System.Drawing.Point(829, 289);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(111, 32);
            this.btnAbsence.TabIndex = 3;
            this.btnAbsence.Text = "Absence";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(164, 289);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 32);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(37, 289);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 32);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // grbAjouter
            // 
            this.grbAjouter.Controls.Add(this.btnAnnuler);
            this.grbAjouter.Controls.Add(this.btnConfirmer);
            this.grbAjouter.Controls.Add(this.txtTel);
            this.grbAjouter.Controls.Add(this.txtMail);
            this.grbAjouter.Controls.Add(this.txtPrenom);
            this.grbAjouter.Controls.Add(this.txtNom);
            this.grbAjouter.Controls.Add(this.lblAffectation);
            this.grbAjouter.Controls.Add(this.lblMail);
            this.grbAjouter.Controls.Add(this.lblTel);
            this.grbAjouter.Controls.Add(this.lblPrenom);
            this.grbAjouter.Controls.Add(this.comboAffectation);
            this.grbAjouter.Controls.Add(this.lblNom);
            this.grbAjouter.Location = new System.Drawing.Point(29, 327);
            this.grbAjouter.Name = "grbAjouter";
            this.grbAjouter.Size = new System.Drawing.Size(924, 189);
            this.grbAjouter.TabIndex = 8;
            this.grbAjouter.TabStop = false;
            this.grbAjouter.Text = "Ajouter un Personnel";
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
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(667, 34);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(150, 22);
            this.txtTel.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(667, 66);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(150, 22);
            this.txtMail.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(124, 66);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(150, 22);
            this.txtPrenom.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(124, 34);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 22);
            this.txtNom.TabIndex = 6;
            // 
            // lblAffectation
            // 
            this.lblAffectation.AutoSize = true;
            this.lblAffectation.Location = new System.Drawing.Point(528, 105);
            this.lblAffectation.Name = "lblAffectation";
            this.lblAffectation.Size = new System.Drawing.Size(83, 17);
            this.lblAffectation.TabIndex = 5;
            this.lblAffectation.Text = "Affectation :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(528, 66);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(110, 17);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Adresse e-mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(528, 34);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(84, 17);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(25, 66);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(69, 17);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // comboAffectation
            // 
            this.comboAffectation.FormattingEnabled = true;
            this.comboAffectation.Location = new System.Drawing.Point(667, 105);
            this.comboAffectation.Name = "comboAffectation";
            this.comboAffectation.Size = new System.Drawing.Size(150, 24);
            this.comboAffectation.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(25, 34);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 538);
            this.Controls.Add(this.grbAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAbsence);
            this.Controls.Add(this.grboxPersonnel);
            this.Name = "FrmPersonnel";
            this.Text = "Gestion du personnel";
            this.grboxPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbAjouter.ResumeLayout(false);
            this.grbAjouter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grboxPersonnel;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.GroupBox grbAjouter;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblAffectation;
        private System.Windows.Forms.ComboBox comboAffectation;
    }
}