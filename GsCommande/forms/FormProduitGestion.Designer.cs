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
            this.grbAddProduct = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblFamille = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstfamille = new System.Windows.Forms.ListBox();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbListeDesProduits = new System.Windows.Forms.GroupBox();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnAnnuler = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.grbAddProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            this.grbListeDesProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbListeDesProduits);
            this.panel1.Controls.Add(this.grbAddProduct);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(9, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 481);
            this.panel1.TabIndex = 0;
            // 
            // grbAddProduct
            // 
            this.grbAddProduct.Controls.Add(this.label3);
            this.grbAddProduct.Controls.Add(this.lblCode);
            this.grbAddProduct.Controls.Add(this.lblFamille);
            this.grbAddProduct.Controls.Add(this.txtLibelle);
            this.grbAddProduct.Controls.Add(this.label2);
            this.grbAddProduct.Controls.Add(this.label1);
            this.grbAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAddProduct.Location = new System.Drawing.Point(200, 0);
            this.grbAddProduct.Name = "grbAddProduct";
            this.grbAddProduct.Size = new System.Drawing.Size(412, 481);
            this.grbAddProduct.TabIndex = 2;
            this.grbAddProduct.TabStop = false;
            this.grbAddProduct.Text = "Ajouter produit";
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
            this.groupBox1.Size = new System.Drawing.Size(200, 481);
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
            this.lstfamille.Size = new System.Drawing.Size(194, 462);
            this.lstfamille.TabIndex = 0;
            this.lstfamille.ValueMember = "Id";
            this.lstfamille.SelectedIndexChanged += new System.EventHandler(this.lstfamille_SelectedIndexChanged);
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Famille);
            // 
            // grbListeDesProduits
            // 
            this.grbListeDesProduits.Controls.Add(this.dgvProduits);
            this.grbListeDesProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListeDesProduits.Location = new System.Drawing.Point(200, 0);
            this.grbListeDesProduits.Name = "grbListeDesProduits";
            this.grbListeDesProduits.Size = new System.Drawing.Size(412, 481);
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
            this.dgvProduits.Size = new System.Drawing.Size(406, 462);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(9, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(612, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnSave,
            this.btnDelete,
            this.btnAnnuler});
            this.toolStrip1.Location = new System.Drawing.Point(9, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Create;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 22);
            this.btnAdd.Text = "Nouveau";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 22);
            this.btnSave.Text = "Enregistrer";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 22);
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Delete;
            this.btnAnnuler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(69, 22);
            this.btnAnnuler.Text = "Annuler";
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
            this.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GsCommande - Gestion des produits";
            this.panel1.ResumeLayout(false);
            this.grbAddProduct.ResumeLayout(false);
            this.grbAddProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            this.grbListeDesProduits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
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

    }
}
