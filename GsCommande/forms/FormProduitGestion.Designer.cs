namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormProduitGestion
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbListeDesProduits = new System.Windows.Forms.GroupBox();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbAddProduct = new System.Windows.Forms.GroupBox();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblFamille = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstfamille = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnModifier = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnAnnuler = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.grbListeDesProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.grbAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbListeDesProduits);
            this.panel1.Controls.Add(this.grbAddProduct);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(9, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 475);
            this.panel1.TabIndex = 0;
            // 
            // grbListeDesProduits
            // 
            this.grbListeDesProduits.Controls.Add(this.dgvProduits);
            this.grbListeDesProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListeDesProduits.Location = new System.Drawing.Point(200, 0);
            this.grbListeDesProduits.Name = "grbListeDesProduits";
            this.grbListeDesProduits.Size = new System.Drawing.Size(421, 475);
            this.grbListeDesProduits.TabIndex = 1;
            this.grbListeDesProduits.TabStop = false;
            this.grbListeDesProduits.Text = "Liste des produits :";
            this.grbListeDesProduits.Visible = false;
            // 
            // dgvProduits
            // 
            this.dgvProduits.AllowUserToAddRows = false;
            this.dgvProduits.AllowUserToDeleteRows = false;
            this.dgvProduits.AllowUserToOrderColumns = true;
            this.dgvProduits.AllowUserToResizeColumns = false;
            this.dgvProduits.AllowUserToResizeRows = false;
            this.dgvProduits.AutoGenerateColumns = false;
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.familleDataGridViewTextBoxColumn});
            this.dgvProduits.DataSource = this.produitBindingSource;
            this.dgvProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduits.Location = new System.Drawing.Point(3, 16);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.ReadOnly = true;
            this.dgvProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduits.Size = new System.Drawing.Size(415, 456);
            this.dgvProduits.TabIndex = 0;
            this.dgvProduits.SelectionChanged += new System.EventHandler(this.dgvProduits_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleDataGridViewTextBoxColumn.Width = 200;
            // 
            // familleDataGridViewTextBoxColumn
            // 
            this.familleDataGridViewTextBoxColumn.DataPropertyName = "Famille";
            this.familleDataGridViewTextBoxColumn.HeaderText = "Famille";
            this.familleDataGridViewTextBoxColumn.Name = "familleDataGridViewTextBoxColumn";
            this.familleDataGridViewTextBoxColumn.ReadOnly = true;
            this.familleDataGridViewTextBoxColumn.Visible = false;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Produit);
            // 
            // grbAddProduct
            // 
            this.grbAddProduct.Controls.Add(this.cmbFamille);
            this.grbAddProduct.Controls.Add(this.label3);
            this.grbAddProduct.Controls.Add(this.lblCode);
            this.grbAddProduct.Controls.Add(this.lblFamille);
            this.grbAddProduct.Controls.Add(this.txtLibelle);
            this.grbAddProduct.Controls.Add(this.label2);
            this.grbAddProduct.Controls.Add(this.label1);
            this.grbAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAddProduct.Location = new System.Drawing.Point(200, 0);
            this.grbAddProduct.Name = "grbAddProduct";
            this.grbAddProduct.Size = new System.Drawing.Size(421, 475);
            this.grbAddProduct.TabIndex = 2;
            this.grbAddProduct.TabStop = false;
            this.grbAddProduct.Text = "Ajouter produit";
            // 
            // cmbFamille
            // 
            this.cmbFamille.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.familleBindingSource, "Id", true));
            this.cmbFamille.DataSource = this.familleBindingSource1;
            this.cmbFamille.DisplayMember = "Libelle";
            this.cmbFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(80, 29);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(150, 21);
            this.cmbFamille.TabIndex = 7;
            this.cmbFamille.ValueMember = "Id";
            this.cmbFamille.SelectedIndexChanged += new System.EventHandler(this.cmbFamille_SelectedIndexChanged);
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Famille);
            // 
            // familleBindingSource1
            // 
            this.familleBindingSource1.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Famille);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Libelle :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(77, 58);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(42, 13);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "lblCode";
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(77, 32);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(49, 13);
            this.lblFamille.TabIndex = 4;
            this.lblFamille.Text = "lblFamille";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(80, 83);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(150, 20);
            this.txtLibelle.TabIndex = 3;
            this.txtLibelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLibelle_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Famille :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstfamille);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 475);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Familles :";
            // 
            // lstfamille
            // 
            this.lstfamille.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.familleBindingSource, "Id", true));
            this.lstfamille.DataSource = this.familleBindingSource;
            this.lstfamille.DisplayMember = "Libelle";
            this.lstfamille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstfamille.FormattingEnabled = true;
            this.lstfamille.Location = new System.Drawing.Point(3, 16);
            this.lstfamille.Name = "lstfamille";
            this.lstfamille.Size = new System.Drawing.Size(194, 456);
            this.lstfamille.TabIndex = 0;
            this.lstfamille.ValueMember = "Id";
            this.lstfamille.SelectedIndexChanged += new System.EventHandler(this.lstfamille_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(9, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnSave,
            this.btnModifier,
            this.btnDelete,
            this.btnAnnuler});
            this.toolStrip1.Location = new System.Drawing.Point(9, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(621, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 28);
            this.btnExit.Text = "&Fermer";
            this.btnExit.ToolTipText = "Fermer (ESC)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Create;
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 28);
            this.btnAdd.Text = "&Nouveau";
            this.btnAdd.ToolTipText = "Nouveau (CTRL + N)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Save;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 28);
            this.btnSave.Text = "&Enregistrer";
            this.btnSave.ToolTipText = "Enregistrer (CTRL + S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Modify;
            this.btnModifier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModifier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(80, 28);
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.ToolTipText = "Modifier (CTRL + E)";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Remove;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 28);
            this.btnDelete.Text = "&Supprimer";
            this.btnDelete.ToolTipText = "Supprimer (CTRL + D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.No;
            this.btnAnnuler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAnnuler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(77, 28);
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.ToolTipText = "Annuler (CTRL + Z)";
            this.btnAnnuler.Visible = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormProduitGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduitGestion";
            this.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GsCommande - Gestion des produits";
            this.panel1.ResumeLayout(false);
            this.grbListeDesProduits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.grbAddProduct.ResumeLayout(false);
            this.grbAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbListeDesProduits;
        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstfamille;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox grbAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnAnnuler;
        private System.Windows.Forms.ToolStripButton btnModifier;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.BindingSource familleBindingSource1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}
