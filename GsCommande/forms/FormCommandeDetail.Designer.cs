﻿namespace Com.GlagSoft.GsCommande.forms
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSupprimer = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ucCommandeAjouter1 = new Com.GlagSoft.GsCommande.uc.UcCommandeModifier();
            this.pnlCommandeLivree = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlCommandeLivree.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuitter,
            this.toolStripSeparator1,
            this.btnSave,
            this.btnSupprimer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(754, 31);
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
            this.btnQuitter.Size = new System.Drawing.Size(72, 28);
            this.btnQuitter.Text = "&Fermer";
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.Text = "S&auvegarder";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Remove;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(90, 28);
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(754, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(188, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // ucCommandeAjouter1
            // 
            this.ucCommandeAjouter1.CommandeForUpdate = null;
            this.ucCommandeAjouter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCommandeAjouter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCommandeAjouter1.Location = new System.Drawing.Point(0, 80);
            this.ucCommandeAjouter1.Name = "ucCommandeAjouter1";
            this.ucCommandeAjouter1.Size = new System.Drawing.Size(754, 403);
            this.ucCommandeAjouter1.TabIndex = 6;
            // 
            // pnlCommandeLivree
            // 
            this.pnlCommandeLivree.Controls.Add(this.label1);
            this.pnlCommandeLivree.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommandeLivree.Location = new System.Drawing.Point(0, 31);
            this.pnlCommandeLivree.Name = "pnlCommandeLivree";
            this.pnlCommandeLivree.Size = new System.Drawing.Size(754, 49);
            this.pnlCommandeLivree.TabIndex = 7;
            this.pnlCommandeLivree.Visible = false;
            // 
            // FormCommandeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 505);
            this.Controls.Add(this.ucCommandeAjouter1);
            this.Controls.Add(this.pnlCommandeLivree);
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
            this.pnlCommandeLivree.ResumeLayout(false);
            this.pnlCommandeLivree.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnQuitter;
        private System.Windows.Forms.ToolStripButton btnSupprimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private uc.UcCommandeModifier ucCommandeAjouter1;
        private System.Windows.Forms.Panel pnlCommandeLivree;

    }
}
