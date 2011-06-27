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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcListeProduit));
            FastReport.Design.DesignerSettings designerSettings1 = new FastReport.Design.DesignerSettings();
            FastReport.Design.DesignerRestrictions designerRestrictions1 = new FastReport.Design.DesignerRestrictions();
            FastReport.Export.Email.EmailSettings emailSettings1 = new FastReport.Export.Email.EmailSettings();
            FastReport.PreviewSettings previewSettings1 = new FastReport.PreviewSettings();
            FastReport.ReportSettings reportSettings1 = new FastReport.ReportSettings();
            this.dgvProduits = new System.Windows.Forms.DataGridView();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportListeProduit = new FastReport.Report();
            this.environmentSettings1 = new FastReport.EnvironmentSettings();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQteKiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQteDemiKiloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportListeProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduits
            // 
            this.dgvProduits.AllowUserToAddRows = false;
            this.dgvProduits.AllowUserToDeleteRows = false;
            this.dgvProduits.AutoGenerateColumns = false;
            this.dgvProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduits.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.familleStringDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.totalQteKiloDataGridViewTextBoxColumn,
            this.totalQteDemiKiloDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.familleDataGridViewTextBoxColumn});
            this.dgvProduits.DataSource = this.produitBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduits.Location = new System.Drawing.Point(0, 0);
            this.dgvProduits.Name = "dgvProduits";
            this.dgvProduits.ReadOnly = true;
            this.dgvProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduits.Size = new System.Drawing.Size(587, 357);
            this.dgvProduits.TabIndex = 0;
            this.dgvProduits.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduits_ColumnHeaderMouseClick);
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Produit);
            // 
            // reportListeProduit
            // 
            this.reportListeProduit.ReportResourceString = resources.GetString("reportListeProduit.ReportResourceString");
            this.reportListeProduit.RegisterData(this.produitBindingSource, "produitBindingSource");
            // 
            // environmentSettings1
            // 
            designerSettings1.ApplicationConnection = null;
            designerSettings1.DefaultFont = new System.Drawing.Font("Arial", 10F);
            designerSettings1.Icon = ((System.Drawing.Icon)(resources.GetObject("designerSettings1.Icon")));
            designerSettings1.Restrictions = designerRestrictions1;
            designerSettings1.Text = "";
            this.environmentSettings1.DesignerSettings = designerSettings1;
            emailSettings1.Address = "";
            emailSettings1.Host = "";
            emailSettings1.MessageTemplate = "";
            emailSettings1.Name = "";
            emailSettings1.Password = "";
            emailSettings1.UserName = "";
            this.environmentSettings1.EmailSettings = emailSettings1;
            previewSettings1.Icon = ((System.Drawing.Icon)(resources.GetObject("previewSettings1.Icon")));
            previewSettings1.Text = "";
            previewSettings1.TopMost = true;
            this.environmentSettings1.PreviewSettings = previewSettings1;
            this.environmentSettings1.ReportSettings = reportSettings1;
            this.environmentSettings1.UIStyle = FastReport.Utils.UIStyle.Office2007Blue;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code Produit";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // familleStringDataGridViewTextBoxColumn
            // 
            this.familleStringDataGridViewTextBoxColumn.DataPropertyName = "FamilleString";
            this.familleStringDataGridViewTextBoxColumn.FillWeight = 300F;
            this.familleStringDataGridViewTextBoxColumn.HeaderText = "Libelle Famille";
            this.familleStringDataGridViewTextBoxColumn.Name = "familleStringDataGridViewTextBoxColumn";
            this.familleStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.familleStringDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
            this.libelleDataGridViewTextBoxColumn.FillWeight = 300F;
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libelle Produit";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.ReadOnly = true;
            this.libelleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // totalQteKiloDataGridViewTextBoxColumn
            // 
            this.totalQteKiloDataGridViewTextBoxColumn.DataPropertyName = "TotalQteKilo";
            this.totalQteKiloDataGridViewTextBoxColumn.HeaderText = "Total Qte Kg";
            this.totalQteKiloDataGridViewTextBoxColumn.Name = "totalQteKiloDataGridViewTextBoxColumn";
            this.totalQteKiloDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalQteKiloDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // totalQteDemiKiloDataGridViewTextBoxColumn
            // 
            this.totalQteDemiKiloDataGridViewTextBoxColumn.DataPropertyName = "TotalQteDemiKilo";
            this.totalQteDemiKiloDataGridViewTextBoxColumn.HeaderText = "Total Qte 1/2 Kg";
            this.totalQteDemiKiloDataGridViewTextBoxColumn.Name = "totalQteDemiKiloDataGridViewTextBoxColumn";
            this.totalQteDemiKiloDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalQteDemiKiloDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            ((System.ComponentModel.ISupportInitialize)(this.reportListeProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduits;
        private System.Windows.Forms.BindingSource produitBindingSource;
        public FastReport.Report reportListeProduit;
        private FastReport.EnvironmentSettings environmentSettings1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQteKiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQteDemiKiloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
    }
}
