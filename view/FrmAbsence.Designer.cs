
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
            this.lbllogo = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.grboxAbsence = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.listAbsence = new System.Windows.Forms.ListBox();
            this.grboxAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Location = new System.Drawing.Point(359, 112);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(35, 17);
            this.lbllogo.TabIndex = 13;
            this.lbllogo.Text = "logo";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(318, 378);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 32);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(318, 416);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 32);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(318, 454);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(111, 32);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(318, 314);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(111, 32);
            this.btnAccueil.TabIndex = 9;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // grboxAbsence
            // 
            this.grboxAbsence.Controls.Add(this.vScrollBar1);
            this.grboxAbsence.Controls.Add(this.listAbsence);
            this.grboxAbsence.Location = new System.Drawing.Point(28, 30);
            this.grboxAbsence.Name = "grboxAbsence";
            this.grboxAbsence.Size = new System.Drawing.Size(254, 457);
            this.grboxAbsence.TabIndex = 8;
            this.grboxAbsence.TabStop = false;
            this.grboxAbsence.Text = "Absence";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(224, 21);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 420);
            this.vScrollBar1.TabIndex = 1;
            // 
            // listAbsence
            // 
            this.listAbsence.FormattingEnabled = true;
            this.listAbsence.ItemHeight = 16;
            this.listAbsence.Location = new System.Drawing.Point(6, 21);
            this.listAbsence.Name = "listAbsence";
            this.listAbsence.Size = new System.Drawing.Size(242, 420);
            this.listAbsence.TabIndex = 0;
            // 
            // FrmAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 517);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.grboxAbsence);
            this.Name = "FrmAbsence";
            this.Text = "Absence";
            this.grboxAbsence.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.GroupBox grboxAbsence;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox listAbsence;
    }
}