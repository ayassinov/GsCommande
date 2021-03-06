﻿namespace Com.GlagSoft.GsCommande.uc
{
    partial class UcCommandeRecherche
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new Com.GlagSoft.GsCommande.Outils.NullableDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPrenomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLivreeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.dgvLigneCommande = new System.Windows.Forms.DataGridView();
            this.libelleFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtekiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDemiKiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligneCommandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.grbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneCommandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnRecherche);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(586, 18);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.NullValue = "_";
            this.dateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.Value = new System.DateTime(2011, 6, 20, 15, 57, 31, 726);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(106, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(268, 18);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(255, 20);
            this.txtClient.TabIndex = 3;
            this.txtClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code commande :";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.clear;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(209, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 32);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "     &Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Remove;
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(311, 60);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(96, 32);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "     &Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Find;
            this.btnRecherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecherche.Location = new System.Drawing.Point(107, 60);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(96, 32);
            this.btnRecherche.TabIndex = 0;
            this.btnRecherche.Text = "     &Chercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCommandes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commandes";
            // 
            // dgvCommandes
            // 
            this.dgvCommandes.AllowUserToAddRows = false;
            this.dgvCommandes.AllowUserToDeleteRows = false;
            this.dgvCommandes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCommandes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCommandes.AutoGenerateColumns = false;
            this.dgvCommandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCommandes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomPrenomClientDataGridViewTextBoxColumn,
            this.dateCommandeDataGridViewTextBoxColumn,
            this.isLivreeDataGridViewCheckBoxColumn});
            this.dgvCommandes.DataSource = this.commandeBindingSource;
            this.dgvCommandes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommandes.Location = new System.Drawing.Point(3, 16);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.ReadOnly = true;
            this.dgvCommandes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            this.dgvCommandes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCommandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommandes.Size = new System.Drawing.Size(728, 297);
            this.dgvCommandes.TabIndex = 0;
            this.dgvCommandes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommandes_ColumnHeaderMouseClick);
            this.dgvCommandes.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommandes_RowHeaderMouseDoubleClick);
            this.dgvCommandes.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Code";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nomPrenomClientDataGridViewTextBoxColumn
            // 
            this.nomPrenomClientDataGridViewTextBoxColumn.DataPropertyName = "NomPrenomClient";
            this.nomPrenomClientDataGridViewTextBoxColumn.HeaderText = "Nom Client";
            this.nomPrenomClientDataGridViewTextBoxColumn.Name = "nomPrenomClientDataGridViewTextBoxColumn";
            this.nomPrenomClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomPrenomClientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dateCommandeDataGridViewTextBoxColumn
            // 
            this.dateCommandeDataGridViewTextBoxColumn.DataPropertyName = "DateCommande";
            this.dateCommandeDataGridViewTextBoxColumn.HeaderText = "Date commande";
            this.dateCommandeDataGridViewTextBoxColumn.Name = "dateCommandeDataGridViewTextBoxColumn";
            this.dateCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateCommandeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // isLivreeDataGridViewCheckBoxColumn
            // 
            this.isLivreeDataGridViewCheckBoxColumn.DataPropertyName = "IsLivree";
            this.isLivreeDataGridViewCheckBoxColumn.HeaderText = "Est livré";
            this.isLivreeDataGridViewCheckBoxColumn.Name = "isLivreeDataGridViewCheckBoxColumn";
            this.isLivreeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Commande);
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.dgvLigneCommande);
            this.grbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetail.Location = new System.Drawing.Point(0, 0);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(300, 316);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Detail de la commande :";
            // 
            // dgvLigneCommande
            // 
            this.dgvLigneCommande.AllowUserToAddRows = false;
            this.dgvLigneCommande.AllowUserToDeleteRows = false;
            this.dgvLigneCommande.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLigneCommande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLigneCommande.AutoGenerateColumns = false;
            this.dgvLigneCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLigneCommande.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLigneCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLigneCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigneCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libelleFamilleDataGridViewTextBoxColumn,
            this.libelleProduitDataGridViewTextBoxColumn,
            this.qtekiloDataGridViewTextBoxColumn,
            this.qteDemiKiloDataGridViewTextBoxColumn});
            this.dgvLigneCommande.DataSource = this.ligneCommandeBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLigneCommande.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLigneCommande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLigneCommande.GridColor = System.Drawing.Color.White;
            this.dgvLigneCommande.Location = new System.Drawing.Point(3, 16);
            this.dgvLigneCommande.MultiSelect = false;
            this.dgvLigneCommande.Name = "dgvLigneCommande";
            this.dgvLigneCommande.ReadOnly = true;
            this.dgvLigneCommande.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvLigneCommande.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLigneCommande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLigneCommande.Size = new System.Drawing.Size(294, 297);
            this.dgvLigneCommande.TabIndex = 3;
            // 
            // libelleFamilleDataGridViewTextBoxColumn
            // 
            this.libelleFamilleDataGridViewTextBoxColumn.DataPropertyName = "LibelleFamille";
            this.libelleFamilleDataGridViewTextBoxColumn.HeaderText = "Famille";
            this.libelleFamilleDataGridViewTextBoxColumn.Name = "libelleFamilleDataGridViewTextBoxColumn";
            this.libelleFamilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleProduitDataGridViewTextBoxColumn
            // 
            this.libelleProduitDataGridViewTextBoxColumn.DataPropertyName = "LibelleProduit";
            this.libelleProduitDataGridViewTextBoxColumn.HeaderText = "Produit";
            this.libelleProduitDataGridViewTextBoxColumn.Name = "libelleProduitDataGridViewTextBoxColumn";
            this.libelleProduitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtekiloDataGridViewTextBoxColumn
            // 
            this.qtekiloDataGridViewTextBoxColumn.DataPropertyName = "Qtekilo";
            this.qtekiloDataGridViewTextBoxColumn.HeaderText = "1 Kg";
            this.qtekiloDataGridViewTextBoxColumn.Name = "qtekiloDataGridViewTextBoxColumn";
            this.qtekiloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qteDemiKiloDataGridViewTextBoxColumn
            // 
            this.qteDemiKiloDataGridViewTextBoxColumn.DataPropertyName = "QteDemiKilo";
            this.qteDemiKiloDataGridViewTextBoxColumn.HeaderText = "1/2 Kg";
            this.qteDemiKiloDataGridViewTextBoxColumn.Name = "qteDemiKiloDataGridViewTextBoxColumn";
            this.qteDemiKiloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ligneCommandeBindingSource
            // 
            this.ligneCommandeBindingSource.DataMember = "LigneCommande";
            this.ligneCommandeBindingSource.DataSource = this.commandeBindingSource;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 110);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1039, 316);
            this.splitContainer1.SplitterDistance = 734;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // UcCommandeRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcCommandeRecherche";
            this.Size = new System.Drawing.Size(1039, 426);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.grbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneCommandeBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCommandes;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private System.Windows.Forms.Label label4;
        private Outils.NullableDateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.DataGridView dgvLigneCommande;
        private System.Windows.Forms.BindingSource ligneCommandeBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtekiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDemiKiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPrenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLivreeDataGridViewCheckBoxColumn;
    }
}
