﻿namespace Com.GlagSoft.GsCommande.uc
{
    partial class UcCommandeModifier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodeCommande = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvLigneCommande = new System.Windows.Forms.DataGridView();
            this.LibelleFamille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtekiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDemiKiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligneCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAjouter = new System.Windows.Forms.ToolStripButton();
            this.btnModifier = new System.Windows.Forms.ToolStripButton();
            this.btnSupprimer = new System.Windows.Forms.ToolStripButton();
            this.pnlModifier = new System.Windows.Forms.Panel();
            this.lblIdCommande = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneCommandeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlModifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIdCommande);
            this.groupBox1.Controls.Add(this.lblCodeCommande);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNomClient);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commande";
            // 
            // lblCodeCommande
            // 
            this.lblCodeCommande.AutoSize = true;
            this.lblCodeCommande.Location = new System.Drawing.Point(8, 32);
            this.lblCodeCommande.Name = "lblCodeCommande";
            this.lblCodeCommande.Size = new System.Drawing.Size(38, 13);
            this.lblCodeCommande.TabIndex = 2;
            this.lblCodeCommande.Text = "Code :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(593, 28);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(209, 28);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(332, 20);
            this.txtClient.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date :";
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Location = new System.Drawing.Point(162, 32);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(39, 13);
            this.lblNomClient.TabIndex = 1;
            this.lblNomClient.Text = "Client :";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvLigneCommande
            // 
            this.dgvLigneCommande.AllowUserToAddRows = false;
            this.dgvLigneCommande.AllowUserToDeleteRows = false;
            this.dgvLigneCommande.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLigneCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLigneCommande.AutoGenerateColumns = false;
            this.dgvLigneCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLigneCommande.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLigneCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLigneCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigneCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LibelleFamille,
            this.LibelleProduit,
            this.qtekiloDataGridViewTextBoxColumn,
            this.qteDemiKiloDataGridViewTextBoxColumn,
            this.commandeDataGridViewTextBoxColumn,
            this.produitDataGridViewTextBoxColumn});
            this.dgvLigneCommande.DataSource = this.ligneCommandeBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLigneCommande.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLigneCommande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLigneCommande.GridColor = System.Drawing.Color.White;
            this.dgvLigneCommande.Location = new System.Drawing.Point(3, 51);
            this.dgvLigneCommande.MultiSelect = false;
            this.dgvLigneCommande.Name = "dgvLigneCommande";
            this.dgvLigneCommande.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            this.dgvLigneCommande.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLigneCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLigneCommande.Size = new System.Drawing.Size(748, 320);
            this.dgvLigneCommande.TabIndex = 1;
            // 
            // LibelleFamille
            // 
            this.LibelleFamille.DataPropertyName = "LibelleFamille";
            this.LibelleFamille.HeaderText = "Famille";
            this.LibelleFamille.Name = "LibelleFamille";
            this.LibelleFamille.ReadOnly = true;
            // 
            // LibelleProduit
            // 
            this.LibelleProduit.DataPropertyName = "LibelleProduit";
            this.LibelleProduit.HeaderText = "Produit";
            this.LibelleProduit.Name = "LibelleProduit";
            this.LibelleProduit.ReadOnly = true;
            // 
            // qtekiloDataGridViewTextBoxColumn
            // 
            this.qtekiloDataGridViewTextBoxColumn.DataPropertyName = "Qtekilo";
            this.qtekiloDataGridViewTextBoxColumn.FillWeight = 50F;
            this.qtekiloDataGridViewTextBoxColumn.HeaderText = "Qte kg";
            this.qtekiloDataGridViewTextBoxColumn.Name = "qtekiloDataGridViewTextBoxColumn";
            // 
            // qteDemiKiloDataGridViewTextBoxColumn
            // 
            this.qteDemiKiloDataGridViewTextBoxColumn.DataPropertyName = "QteDemiKilo";
            this.qteDemiKiloDataGridViewTextBoxColumn.FillWeight = 50F;
            this.qteDemiKiloDataGridViewTextBoxColumn.HeaderText = "Qte 1/2 Kg";
            this.qteDemiKiloDataGridViewTextBoxColumn.Name = "qteDemiKiloDataGridViewTextBoxColumn";
            // 
            // commandeDataGridViewTextBoxColumn
            // 
            this.commandeDataGridViewTextBoxColumn.DataPropertyName = "Commande";
            this.commandeDataGridViewTextBoxColumn.HeaderText = "Commande";
            this.commandeDataGridViewTextBoxColumn.Name = "commandeDataGridViewTextBoxColumn";
            this.commandeDataGridViewTextBoxColumn.Visible = false;
            // 
            // produitDataGridViewTextBoxColumn
            // 
            this.produitDataGridViewTextBoxColumn.DataPropertyName = "Produit";
            this.produitDataGridViewTextBoxColumn.HeaderText = "Produit";
            this.produitDataGridViewTextBoxColumn.Name = "produitDataGridViewTextBoxColumn";
            this.produitDataGridViewTextBoxColumn.Visible = false;
            // 
            // ligneCommandeBindingSource
            // 
            this.ligneCommandeBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.LigneCommande);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLigneCommande);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 374);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produits";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjouter,
            this.btnModifier,
            this.btnSupprimer});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(748, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Create;
            this.btnAjouter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(210, 32);
            this.btnAjouter.Text = "Ajouter un produit à la commande";
            this.btnAjouter.ToolTipText = "Ajouter un produit à la commande (F5)";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Modify;
            this.btnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(147, 32);
            this.btnModifier.Text = "Modifier les quantitées";
            this.btnModifier.ToolTipText = "Modifier les quantitées (F6)";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Remove;
            this.btnSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(228, 32);
            this.btnSupprimer.Text = "Supprimer le produit de la commande";
            this.btnSupprimer.ToolTipText = "Supprimer le produit de la commande (F7)";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // pnlModifier
            // 
            this.pnlModifier.Controls.Add(this.groupBox2);
            this.pnlModifier.Controls.Add(this.groupBox1);
            this.pnlModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModifier.Location = new System.Drawing.Point(0, 0);
            this.pnlModifier.Name = "pnlModifier";
            this.pnlModifier.Size = new System.Drawing.Size(754, 443);
            this.pnlModifier.TabIndex = 2;
            // 
            // lblIdCommande
            // 
            this.lblIdCommande.AutoSize = true;
            this.lblIdCommande.Location = new System.Drawing.Point(52, 31);
            this.lblIdCommande.Name = "lblIdCommande";
            this.lblIdCommande.Size = new System.Drawing.Size(0, 13);
            this.lblIdCommande.TabIndex = 3;
            // 
            // UcCommandeModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlModifier);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UcCommandeModifier";
            this.Size = new System.Drawing.Size(754, 443);
            this.EnabledChanged += new System.EventHandler(this.UcCommandeAjouter_EnabledChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneCommandeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlModifier.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvLigneCommande;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource ligneCommandeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleFamille;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtekiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDemiKiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produitDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAjouter;
        private System.Windows.Forms.ToolStripButton btnModifier;
        private System.Windows.Forms.ToolStripButton btnSupprimer;
        private System.Windows.Forms.Panel pnlModifier;
        private System.Windows.Forms.Label lblCodeCommande;
        private System.Windows.Forms.Label lblIdCommande;
    }
}
