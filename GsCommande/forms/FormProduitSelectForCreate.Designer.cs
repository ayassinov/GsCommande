namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormProduitSelectForCreate
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
            this.txtQteKilo = new System.Windows.Forms.NumericUpDown();
            this.txtQteDemiKilo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProduit = new System.Windows.Forms.Label();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFamille = new System.Windows.Forms.Label();
            this.lstFamille = new System.Windows.Forms.ListBox();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnProduitAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstProduit = new System.Windows.Forms.ListBox();
            this.BtnSauvegarder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteDemiKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQteKilo
            // 
            this.txtQteKilo.Location = new System.Drawing.Point(82, 19);
            this.txtQteKilo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtQteKilo.Name = "txtQteKilo";
            this.txtQteKilo.Size = new System.Drawing.Size(84, 20);
            this.txtQteKilo.TabIndex = 0;
            // 
            // txtQteDemiKilo
            // 
            this.txtQteDemiKilo.Location = new System.Drawing.Point(82, 52);
            this.txtQteDemiKilo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtQteDemiKilo.Name = "txtQteDemiKilo";
            this.txtQteDemiKilo.Size = new System.Drawing.Size(84, 20);
            this.txtQteDemiKilo.TabIndex = 1;
            this.txtQteDemiKilo.Leave += new System.EventHandler(this.txtQteDemiKilo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Qte 1 Kg :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qte 1/2 Kg :";
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Location = new System.Drawing.Point(5, 104);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(46, 13);
            this.lblProduit.TabIndex = 8;
            this.lblProduit.Text = "Produit :";
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Produit);
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(5, 12);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(45, 13);
            this.lblFamille.TabIndex = 8;
            this.lblFamille.Text = "Famille :";
            // 
            // lstFamille
            // 
            this.lstFamille.DataSource = this.familleBindingSource;
            this.lstFamille.DisplayMember = "Libelle";
            this.lstFamille.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstFamille.FormattingEnabled = true;
            this.lstFamille.Location = new System.Drawing.Point(57, 12);
            this.lstFamille.Name = "lstFamille";
            this.lstFamille.Size = new System.Drawing.Size(165, 82);
            this.lstFamille.TabIndex = 0;
            this.lstFamille.ValueMember = "Id";
            this.lstFamille.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFamille_DrawItem);
            this.lstFamille.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Famille);
            // 
            // btnProduitAjouter
            // 
            this.btnProduitAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProduitAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduitAjouter.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Create;
            this.btnProduitAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduitAjouter.Location = new System.Drawing.Point(328, 100);
            this.btnProduitAjouter.Name = "btnProduitAjouter";
            this.btnProduitAjouter.Size = new System.Drawing.Size(95, 34);
            this.btnProduitAjouter.TabIndex = 13;
            this.btnProduitAjouter.TabStop = false;
            this.btnProduitAjouter.Text = "      &Ajouter";
            this.btnProduitAjouter.UseVisualStyleBackColor = true;
            this.btnProduitAjouter.Click += new System.EventHandler(this.btnProduitAjouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQteDemiKilo);
            this.groupBox1.Controls.Add(this.txtQteKilo);
            this.groupBox1.Location = new System.Drawing.Point(228, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 89);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lstProduit
            // 
            this.lstProduit.DataSource = this.produitBindingSource;
            this.lstProduit.DisplayMember = "Libelle";
            this.lstProduit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstProduit.FormattingEnabled = true;
            this.lstProduit.Location = new System.Drawing.Point(57, 104);
            this.lstProduit.MaximumSize = new System.Drawing.Size(165, 238);
            this.lstProduit.MinimumSize = new System.Drawing.Size(165, 15);
            this.lstProduit.Name = "lstProduit";
            this.lstProduit.Size = new System.Drawing.Size(165, 238);
            this.lstProduit.TabIndex = 1;
            this.lstProduit.ValueMember = "Id";
            this.lstProduit.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstProduit_DrawItem);
            // 
            // BtnSauvegarder
            // 
            this.BtnSauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSauvegarder.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Save;
            this.BtnSauvegarder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSauvegarder.Location = new System.Drawing.Point(310, 308);
            this.BtnSauvegarder.Name = "BtnSauvegarder";
            this.BtnSauvegarder.Size = new System.Drawing.Size(113, 34);
            this.BtnSauvegarder.TabIndex = 13;
            this.BtnSauvegarder.TabStop = false;
            this.BtnSauvegarder.Text = "      &Sauvegarder";
            this.BtnSauvegarder.UseVisualStyleBackColor = true;
            this.BtnSauvegarder.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // FormProduitSelectForCreate
            // 
            this.AcceptButton = this.btnProduitAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 354);
            this.Controls.Add(this.lstProduit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSauvegarder);
            this.Controls.Add(this.btnProduitAjouter);
            this.Controls.Add(this.lstFamille);
            this.Controls.Add(this.lblFamille);
            this.Controls.Add(this.lblProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(427, 167);
            this.Name = "FormProduitSelectForCreate";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GsCommande";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProduitSelect_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtQteKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteDemiKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtQteKilo;
        private System.Windows.Forms.NumericUpDown txtQteDemiKilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.ListBox lstFamille;
        private System.Windows.Forms.Button btnProduitAjouter;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstProduit;
        private System.Windows.Forms.Button BtnSauvegarder;

    }
}
