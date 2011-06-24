namespace Com.GlagSoft.GsCommande
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResetTotal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBachup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.modèleDuRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChercherCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestionFamille = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesfamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestionProduit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnListerProduit = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSauvegarder = new System.Windows.Forms.ToolStripButton();
            this.btnDetail = new System.Windows.Forms.ToolStripButton();
            this.btnImprimer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAjouterCommande = new System.Windows.Forms.ToolStripButton();
            this.btnChercherCommande = new System.Windows.Forms.ToolStripButton();
            this.btnListeProduits = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGestionFamille = new System.Windows.Forms.ToolStripButton();
            this.btnGestionProduit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucListeProduit1 = new Com.GlagSoft.GsCommande.uc.UcListeProduit();
            this.ucCommandeRecherche1 = new Com.GlagSoft.GsCommande.uc.UcCommandeRecherche();
            this.ucCommandeAjouter1 = new Com.GlagSoft.GsCommande.uc.UcCommandeAjouter();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.mnuGestionFamille,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(708, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfiguration,
            this.toolStripSeparator5,
            this.réinitialiserToolStripMenuItem,
            this.mnuBachup,
            this.toolStripSeparator3,
            this.modèleDuRapportToolStripMenuItem,
            this.toolStripSeparator6,
            this.mnuExit});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.fichierToolStripMenuItem.Text = "F&ichier";
            // 
            // mnuConfiguration
            // 
            this.mnuConfiguration.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.config;
            this.mnuConfiguration.Name = "mnuConfiguration";
            this.mnuConfiguration.Size = new System.Drawing.Size(212, 22);
            this.mnuConfiguration.Text = "&Configuration";
            this.mnuConfiguration.Click += new System.EventHandler(this.mnuReset_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // réinitialiserToolStripMenuItem
            // 
            this.réinitialiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResetCommande,
            this.mnuResetTotal});
            this.réinitialiserToolStripMenuItem.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.restore;
            this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
            this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.réinitialiserToolStripMenuItem.Text = "Réinitialisation";
            // 
            // mnuResetCommande
            // 
            this.mnuResetCommande.Image = global::Com.GlagSoft.GsCommande.Properties.Resources._warning;
            this.mnuResetCommande.Name = "mnuResetCommande";
            this.mnuResetCommande.Size = new System.Drawing.Size(142, 22);
            this.mnuResetCommande.Text = "Commandes";
            this.mnuResetCommande.Click += new System.EventHandler(this.mnuResetCommande_Click);
            // 
            // mnuResetTotal
            // 
            this.mnuResetTotal.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.danger;
            this.mnuResetTotal.Name = "mnuResetTotal";
            this.mnuResetTotal.Size = new System.Drawing.Size(142, 22);
            this.mnuResetTotal.Text = "Totale";
            this.mnuResetTotal.Click += new System.EventHandler(this.mnuResetTotal_Click);
            // 
            // mnuBachup
            // 
            this.mnuBachup.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.load;
            this.mnuBachup.Name = "mnuBachup";
            this.mnuBachup.Size = new System.Drawing.Size(212, 22);
            this.mnuBachup.Text = "Sauvegarde / Restauration";
            this.mnuBachup.Click += new System.EventHandler(this.mnuBachup_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // modèleDuRapportToolStripMenuItem
            // 
            this.modèleDuRapportToolStripMenuItem.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.designer;
            this.modèleDuRapportToolStripMenuItem.Name = "modèleDuRapportToolStripMenuItem";
            this.modèleDuRapportToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.modèleDuRapportToolStripMenuItem.Text = "Modifier les rapports";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Exit;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(212, 22);
            this.mnuExit.Text = "&Quitter";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddCommand,
            this.mnuChercherCommande});
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(82, 19);
            this.commandeToolStripMenuItem.Text = "Commande";
            // 
            // mnuAddCommand
            // 
            this.mnuAddCommand.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Create;
            this.mnuAddCommand.Name = "mnuAddCommand";
            this.mnuAddCommand.Size = new System.Drawing.Size(122, 22);
            this.mnuAddCommand.Text = "&Ajouter";
            // 
            // mnuChercherCommande
            // 
            this.mnuChercherCommande.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Search;
            this.mnuChercherCommande.Name = "mnuChercherCommande";
            this.mnuChercherCommande.Size = new System.Drawing.Size(122, 22);
            this.mnuChercherCommande.Text = "&Chercher";
            // 
            // mnuGestionFamille
            // 
            this.mnuGestionFamille.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesfamillesToolStripMenuItem,
            this.mnuGestionProduit,
            this.toolStripSeparator7,
            this.mnListerProduit});
            this.mnuGestionFamille.Name = "mnuGestionFamille";
            this.mnuGestionFamille.Size = new System.Drawing.Size(58, 19);
            this.mnuGestionFamille.Text = "Produit";
            // 
            // gérerLesfamillesToolStripMenuItem
            // 
            this.gérerLesfamillesToolStripMenuItem.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.tag_blue_edit;
            this.gérerLesfamillesToolStripMenuItem.Name = "gérerLesfamillesToolStripMenuItem";
            this.gérerLesfamillesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gérerLesfamillesToolStripMenuItem.Text = "Gérer les &familles";
            // 
            // mnuGestionProduit
            // 
            this.mnuGestionProduit.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.tag_yellow_edit;
            this.mnuGestionProduit.Name = "mnuGestionProduit";
            this.mnuGestionProduit.Size = new System.Drawing.Size(166, 22);
            this.mnuGestionProduit.Text = "Gérer les &produits";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(163, 6);
            // 
            // mnListerProduit
            // 
            this.mnListerProduit.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Report;
            this.mnListerProduit.Name = "mnListerProduit";
            this.mnListerProduit.Size = new System.Drawing.Size(166, 22);
            this.mnListerProduit.Text = "Liste des &produits";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAPropos});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // mnuAPropos
            // 
            this.mnuAPropos.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.about;
            this.mnuAPropos.Name = "mnuAPropos";
            this.mnuAPropos.Size = new System.Drawing.Size(122, 22);
            this.mnuAPropos.Text = "A &propos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSauvegarder,
            this.btnDetail,
            this.btnImprimer,
            this.toolStripSeparator1,
            this.btnAjouterCommande,
            this.btnChercherCommande,
            this.btnListeProduits,
            this.toolStripSeparator2,
            this.btnGestionFamille,
            this.btnGestionProduit});
            this.toolStrip1.Location = new System.Drawing.Point(3, 26);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(708, 40);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Save;
            this.btnSauvegarder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSauvegarder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(100, 37);
            this.btnSauvegarder.Text = "&Sauvegarder";
            this.btnSauvegarder.ToolTipText = "Sauvegarder (CTRL + S)";
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.view_detail;
            this.btnDetail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(73, 37);
            this.btnDetail.Text = "&Détail";
            this.btnDetail.ToolTipText = "Détail (CTRL + F)";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Print;
            this.btnImprimer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(84, 37);
            this.btnImprimer.Text = "&Imprimer";
            this.btnImprimer.ToolTipText = "Imprimer (CTRL+P)";
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnAjouterCommande
            // 
            this.btnAjouterCommande.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.New_document;
            this.btnAjouterCommande.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAjouterCommande.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAjouterCommande.Name = "btnAjouterCommande";
            this.btnAjouterCommande.Size = new System.Drawing.Size(161, 37);
            this.btnAjouterCommande.Text = "&Ajouter une commande";
            this.btnAjouterCommande.ToolTipText = "Ajouter une commande (F2)";
            this.btnAjouterCommande.Click += new System.EventHandler(this.btnAjouterCommande_Click);
            // 
            // btnChercherCommande
            // 
            this.btnChercherCommande.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Search;
            this.btnChercherCommande.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChercherCommande.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChercherCommande.Name = "btnChercherCommande";
            this.btnChercherCommande.Size = new System.Drawing.Size(170, 37);
            this.btnChercherCommande.Text = "&Chercher une commande";
            this.btnChercherCommande.ToolTipText = "Chercher une commande (F3)";
            this.btnChercherCommande.Click += new System.EventHandler(this.btnChercherCommande_Click);
            // 
            // btnListeProduits
            // 
            this.btnListeProduits.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Report;
            this.btnListeProduits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListeProduits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListeProduits.Name = "btnListeProduits";
            this.btnListeProduits.Size = new System.Drawing.Size(127, 28);
            this.btnListeProduits.Text = "&Liste des Produits";
            this.btnListeProduits.ToolTipText = "Liste des Produits (F4)";
            this.btnListeProduits.Click += new System.EventHandler(this.btnListeProduits_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnGestionFamille
            // 
            this.btnGestionFamille.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.tag_blue_edit;
            this.btnGestionFamille.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGestionFamille.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGestionFamille.Name = "btnGestionFamille";
            this.btnGestionFamille.Size = new System.Drawing.Size(132, 36);
            this.btnGestionFamille.Text = "Gérer les &familles";
            this.btnGestionFamille.ToolTipText = "Gérer les familles (F11)";
            this.btnGestionFamille.Click += new System.EventHandler(this.btnGestionFamille_Click);
            // 
            // btnGestionProduit
            // 
            this.btnGestionProduit.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.tag_yellow_edit;
            this.btnGestionProduit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGestionProduit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGestionProduit.Name = "btnGestionProduit";
            this.btnGestionProduit.Size = new System.Drawing.Size(151, 36);
            this.btnGestionProduit.Text = "Gestion des &produits";
            this.btnGestionProduit.ToolTipText = "Gestion des produits (F12)";
            this.btnGestionProduit.Click += new System.EventHandler(this.btnGestionProduit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucListeProduit1);
            this.panel1.Controls.Add(this.ucCommandeRecherche1);
            this.panel1.Controls.Add(this.ucCommandeAjouter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel1.Size = new System.Drawing.Size(708, 346);
            this.panel1.TabIndex = 4;
            // 
            // ucListeProduit1
            // 
            this.ucListeProduit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListeProduit1.IsShowPrintButton = false;
            this.ucListeProduit1.Location = new System.Drawing.Point(0, 20);
            this.ucListeProduit1.Name = "ucListeProduit1";
            this.ucListeProduit1.Size = new System.Drawing.Size(708, 326);
            this.ucListeProduit1.TabIndex = 5;
            // 
            // ucCommandeRecherche1
            // 
            this.ucCommandeRecherche1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCommandeRecherche1.Location = new System.Drawing.Point(0, 20);
            this.ucCommandeRecherche1.Name = "ucCommandeRecherche1";
            this.ucCommandeRecherche1.SelectedCommande = null;
            this.ucCommandeRecherche1.Size = new System.Drawing.Size(708, 326);
            this.ucCommandeRecherche1.TabIndex = 1;
            // 
            // ucCommandeAjouter1
            // 
            this.ucCommandeAjouter1.CommandeForUpdate = null;
            this.ucCommandeAjouter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCommandeAjouter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCommandeAjouter1.Location = new System.Drawing.Point(0, 20);
            this.ucCommandeAjouter1.Name = "ucCommandeAjouter1";
            this.ucCommandeAjouter1.Size = new System.Drawing.Size(708, 326);
            this.ucCommandeAjouter1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(730, 330);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GsCommande - Version 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSauvegarder;
        private System.Windows.Forms.Panel panel1;
        private uc.UcCommandeAjouter ucCommandeAjouter1;
        private System.Windows.Forms.ToolStripButton btnDetail;
        private System.Windows.Forms.ToolStripButton btnImprimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAjouterCommande;
        private System.Windows.Forms.ToolStripButton btnChercherCommande;
        private System.Windows.Forms.ToolStripButton btnListeProduits;
        private System.Windows.Forms.ToolStripButton btnGestionFamille;
        private System.Windows.Forms.ToolStripButton btnGestionProduit;
        private uc.UcCommandeRecherche ucCommandeRecherche1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private uc.UcListeProduit ucListeProduit1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuConfiguration;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddCommand;
        private System.Windows.Forms.ToolStripMenuItem mnuChercherCommande;
        private System.Windows.Forms.ToolStripMenuItem mnuGestionFamille;
        private System.Windows.Forms.ToolStripMenuItem gérerLesfamillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGestionProduit;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAPropos;
        private System.Windows.Forms.ToolStripMenuItem mnuBachup;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuResetCommande;
        private System.Windows.Forms.ToolStripMenuItem mnuResetTotal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem modèleDuRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnListerProduit;
    }
}