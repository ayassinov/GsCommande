namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormCommandeDetail
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnQuitter = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLivrer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSupprimer = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAnnulerLivraison = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCommandeAjouter1 = new Com.GlagSoft.GsCommande.uc.UcCommandeAjouter();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuitter,
            this.btnSave,
            this.toolStripSeparator2,
            this.btnLivrer,
            this.toolStripSeparator1,
            this.btnSupprimer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(672, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Exit;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(72, 36);
            this.btnQuitter.Text = "&Fermer";
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.Text = "S&auvegarder";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnLivrer
            // 
            this.btnLivrer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.shipping;
            this.btnLivrer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLivrer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLivrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLivrer.Name = "btnLivrer";
            this.btnLivrer.Size = new System.Drawing.Size(72, 36);
            this.btnLivrer.Text = "&Livrer";
            this.btnLivrer.Click += new System.EventHandler(this.btnLivrer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Remove;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(90, 36);
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(672, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btnAnnulerLivraison
            // 
            this.btnAnnulerLivraison.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerLivraison.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.No;
            this.btnAnnulerLivraison.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulerLivraison.Location = new System.Drawing.Point(254, 252);
            this.btnAnnulerLivraison.Name = "btnAnnulerLivraison";
            this.btnAnnulerLivraison.Size = new System.Drawing.Size(195, 35);
            this.btnAnnulerLivraison.TabIndex = 5;
            this.btnAnnulerLivraison.Text = "     &Annuler la Livraison";
            this.btnAnnulerLivraison.UseVisualStyleBackColor = true;
            this.btnAnnulerLivraison.Click += new System.EventHandler(this.btnAnnulerLivraison_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(200, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // ucCommandeAjouter1
            // 
            this.ucCommandeAjouter1.CommandeForUpdate = null;
            this.ucCommandeAjouter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCommandeAjouter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCommandeAjouter1.Location = new System.Drawing.Point(0, 39);
            this.ucCommandeAjouter1.Name = "ucCommandeAjouter1";
            this.ucCommandeAjouter1.Size = new System.Drawing.Size(672, 444);
            this.ucCommandeAjouter1.TabIndex = 6;
            // 
            // FormCommandeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 505);
            this.Controls.Add(this.ucCommandeAjouter1);
            this.Controls.Add(this.btnAnnulerLivraison);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCommandeDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GsCommande - Modifier commande";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCommandeDetail_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnQuitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnLivrer;
        private System.Windows.Forms.ToolStripButton btnSupprimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnAnnulerLivraison;
        private System.Windows.Forms.Label label1;
        private uc.UcCommandeAjouter ucCommandeAjouter1;

    }
}
