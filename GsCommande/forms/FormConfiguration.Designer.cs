namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOuvrirDossier = new System.Windows.Forms.Button();
            this.btnOuvrirFichierBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRestoreFolder = new System.Windows.Forms.TextBox();
            this.lblDbFile = new System.Windows.Forms.Label();
            this.txtDbFilePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.openFileDialogdb = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOuvrirDossier);
            this.groupBox1.Controls.Add(this.btnOuvrirFichierBase);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRestoreFolder);
            this.groupBox1.Controls.Add(this.lblDbFile);
            this.groupBox1.Controls.Add(this.txtDbFilePath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres";
            // 
            // btnOuvrirDossier
            // 
            this.btnOuvrirDossier.Location = new System.Drawing.Point(415, 60);
            this.btnOuvrirDossier.Name = "btnOuvrirDossier";
            this.btnOuvrirDossier.Size = new System.Drawing.Size(35, 20);
            this.btnOuvrirDossier.TabIndex = 6;
            this.btnOuvrirDossier.Text = "...";
            this.btnOuvrirDossier.UseVisualStyleBackColor = true;
            this.btnOuvrirDossier.Click += new System.EventHandler(this.btnOuvrirDossier_Click);
            // 
            // btnOuvrirFichierBase
            // 
            this.btnOuvrirFichierBase.Location = new System.Drawing.Point(415, 19);
            this.btnOuvrirFichierBase.Name = "btnOuvrirFichierBase";
            this.btnOuvrirFichierBase.Size = new System.Drawing.Size(35, 20);
            this.btnOuvrirFichierBase.TabIndex = 5;
            this.btnOuvrirFichierBase.Text = "...";
            this.btnOuvrirFichierBase.UseVisualStyleBackColor = true;
            this.btnOuvrirFichierBase.Click += new System.EventHandler(this.btnOuvrirFichierBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dossier pour les sauvegardes :";
            // 
            // txtRestoreFolder
            // 
            this.txtRestoreFolder.Location = new System.Drawing.Point(163, 60);
            this.txtRestoreFolder.Name = "txtRestoreFolder";
            this.txtRestoreFolder.Size = new System.Drawing.Size(246, 20);
            this.txtRestoreFolder.TabIndex = 2;
            // 
            // lblDbFile
            // 
            this.lblDbFile.AutoSize = true;
            this.lblDbFile.Location = new System.Drawing.Point(11, 22);
            this.lblDbFile.Name = "lblDbFile";
            this.lblDbFile.Size = new System.Drawing.Size(149, 13);
            this.lblDbFile.TabIndex = 1;
            this.lblDbFile.Text = "Fichier del  base de données :";
            // 
            // txtDbFilePath
            // 
            this.txtDbFilePath.Location = new System.Drawing.Point(163, 19);
            this.txtDbFilePath.Name = "txtDbFilePath";
            this.txtDbFilePath.Size = new System.Drawing.Size(246, 20);
            this.txtDbFilePath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAnnuler);
            this.groupBox2.Controls.Add(this.btnQuitter);
            this.groupBox2.Controls.Add(this.btnConfirmer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(9, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.No;
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(305, 18);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(77, 36);
            this.btnAnnuler.TabIndex = 0;
            this.btnAnnuler.Text = "        Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Exit;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(305, 18);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(77, 36);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "         Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.OK;
            this.btnConfirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmer.Location = new System.Drawing.Point(388, 18);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(87, 36);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "     Modifier";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // openFileDialogdb
            // 
            this.openFileDialogdb.Filter = "Fichier db | *.db";
            // 
            // FormConfiguration
            // 
            this.AcceptButton = this.btnConfirmer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 176);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguration";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GsCommande - Paramètres";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRestoreFolder;
        private System.Windows.Forms.Label lblDbFile;
        private System.Windows.Forms.TextBox txtDbFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialogdb;
        private System.Windows.Forms.Button btnOuvrirFichierBase;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnOuvrirDossier;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnAnnuler;

    }
}
