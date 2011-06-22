namespace Com.GlagSoft.GsCommande.uc
{
    partial class UcListeProduit
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
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familleStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQteKiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQteDemiKiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduits
            // 
            this.dgvProduits.AllowUserToAddRows = false;
            this.dgvProduits.AllowUserToDeleteRows = false;
            this.dgvProduits.AutoGenerateColumns = false;
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.familleStringDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.totalQteKiloDataGridViewTextBoxColumn,
            this.totalQteDemiKiloDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.familleDataGridViewTextBoxColumn});
            this.dgvProduits.DataSource = this.produitBindingSource;
            this.dgvProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduits.Location = new System.Drawing.Point(0, 0);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.ReadOnly = true;
            this.dgvProduits.Size = new System.Drawing.Size(587, 357);
            this.dgvProduits.TabIndex = 0;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Produit);
            // 
            // familleStringDataGridViewTextBoxColumn
            // 
            this.familleStringDataGridViewTextBoxColumn.DataPropertyName = "FamilleString";
            this.familleStringDataGridViewTextBoxColumn.FillWeight = 300F;
            this.familleStringDataGridViewTextBoxColumn.HeaderText = "Libelle Famille";
            this.familleStringDataGridViewTextBoxColumn.Name = "familleStringDataGridViewTextBoxColumn";
            this.familleStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code Produit";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
            this.libelleDataGridViewTextBoxColumn.FillWeight = 300F;
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libelle Produit";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQteKiloDataGridViewTextBoxColumn
            // 
            this.totalQteKiloDataGridViewTextBoxColumn.DataPropertyName = "TotalQteKilo";
            this.totalQteKiloDataGridViewTextBoxColumn.FillWeight = 50F;
            this.totalQteKiloDataGridViewTextBoxColumn.HeaderText = "Total Qte Kg";
            this.totalQteKiloDataGridViewTextBoxColumn.Name = "totalQteKiloDataGridViewTextBoxColumn";
            this.totalQteKiloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQteDemiKiloDataGridViewTextBoxColumn
            // 
            this.totalQteDemiKiloDataGridViewTextBoxColumn.DataPropertyName = "TotalQteDemiKilo";
            this.totalQteDemiKiloDataGridViewTextBoxColumn.HeaderText = "Total Qte 1/2 Kg";
            this.totalQteDemiKiloDataGridViewTextBoxColumn.Name = "totalQteDemiKiloDataGridViewTextBoxColumn";
            this.totalQteDemiKiloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // familleDataGridViewTextBoxColumn
            // 
            this.familleDataGridViewTextBoxColumn.DataPropertyName = "Famille";
            this.familleDataGridViewTextBoxColumn.HeaderText = "Famille";
            this.familleDataGridViewTextBoxColumn.Name = "familleDataGridViewTextBoxColumn";
            this.familleDataGridViewTextBoxColumn.ReadOnly = true;
            this.familleDataGridViewTextBoxColumn.Visible = false;
            // 
            // UcListeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProduits);
            this.Name = "UcListeProduit";
            this.Size = new System.Drawing.Size(587, 357);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQteKiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQteDemiKiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produitBindingSource;
    }
}
