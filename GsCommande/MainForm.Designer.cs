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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSauvegarder = new System.Windows.Forms.ToolStripButton();
            this.btnModifier = new System.Windows.Forms.ToolStripButton();
            this.btnImprimer = new System.Windows.Forms.ToolStripButton();
            this.btnAjouterCommande = new System.Windows.Forms.ToolStripButton();
            this.btnChercherCommande = new System.Windows.Forms.ToolStripButton();
            this.btnListeProduits = new System.Windows.Forms.ToolStripButton();
            this.btnGestionFamille = new System.Windows.Forms.ToolStripButton();
            this.btnGestionProduit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.statusStrip1.Location = new System.Drawing.Point(3, 376);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1076, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1076, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.fichierToolStripMenuItem.Text = "F&ichier";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSauvegarder,
            this.btnModifier,
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
            this.toolStrip1.Size = new System.Drawing.Size(1076, 40);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucListeProduit1);
            this.panel1.Controls.Add(this.ucCommandeRecherche1);
            this.panel1.Controls.Add(this.ucCommandeAjouter1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 310);
            this.panel1.TabIndex = 4;
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
            // btnModifier
            // 
            this.btnModifier.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Modify;
            this.btnModifier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(80, 37);
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.ToolTipText = "Modifier (CTRL + E)";
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
            this.btnListeProduits.Size = new System.Drawing.Size(127, 37);
            this.btnListeProduits.Text = "&Liste des Produits";
            this.btnListeProduits.ToolTipText = "Liste des Produits (F4)";
            this.btnListeProduits.Click += new System.EventHandler(this.btnListeProduits_Click);
            // 
            // btnGestionFamille
            // 
            this.btnGestionFamille.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Notes;
            this.btnGestionFamille.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGestionFamille.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGestionFamille.Name = "btnGestionFamille";
            this.btnGestionFamille.Size = new System.Drawing.Size(124, 37);
            this.btnGestionFamille.Text = "Gérer les &familles";
            this.btnGestionFamille.Click += new System.EventHandler(this.btnGestionFamille_Click);
            // 
            // btnGestionProduit
            // 
            this.btnGestionProduit.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Notes;
            this.btnGestionProduit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGestionProduit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGestionProduit.Name = "btnGestionProduit";
            this.btnGestionProduit.Size = new System.Drawing.Size(143, 37);
            this.btnGestionProduit.Text = "Gestion des &produits";
            this.btnGestionProduit.Click += new System.EventHandler(this.btnGestionProduit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // ucListeProduit1
            // 
            this.ucListeProduit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListeProduit1.Location = new System.Drawing.Point(0, 0);
            this.ucListeProduit1.Name = "ucListeProduit1";
            this.ucListeProduit1.Size = new System.Drawing.Size(1076, 310);
            this.ucListeProduit1.TabIndex = 5;
            // 
            // ucCommandeRecherche1
            // 
            this.ucCommandeRecherche1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCommandeRecherche1.Location = new System.Drawing.Point(0, 0);
            this.ucCommandeRecherche1.Name = "ucCommandeRecherche1";
            this.ucCommandeRecherche1.Size = new System.Drawing.Size(1076, 310);
            this.ucCommandeRecherche1.TabIndex = 1;
            // 
            // ucCommandeAjouter1
            // 
            this.ucCommandeAjouter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCommandeAjouter1.Location = new System.Drawing.Point(0, 0);
            this.ucCommandeAjouter1.Name = "ucCommandeAjouter1";
            this.ucCommandeAjouter1.Size = new System.Drawing.Size(1076, 310);
            this.ucCommandeAjouter1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripButton btnModifier;
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
    }
}