namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormProduitSelect
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
            this.cmbProduit = new System.Windows.Forms.ComboBox();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFamille = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.familleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnProduitAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteDemiKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQteKilo
            // 
            this.txtQteKilo.Location = new System.Drawing.Point(95, 118);
            this.txtQteKilo.Name = "txtQteKilo";
            this.txtQteKilo.Size = new System.Drawing.Size(84, 20);
            this.txtQteKilo.TabIndex = 10;
            // 
            // txtQteDemiKilo
            // 
            this.txtQteDemiKilo.Location = new System.Drawing.Point(95, 147);
            this.txtQteDemiKilo.Name = "txtQteDemiKilo";
            this.txtQteDemiKilo.Size = new System.Drawing.Size(84, 20);
            this.txtQteDemiKilo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Qte 1 Kg :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Qte 1/2 Kg :";
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Location = new System.Drawing.Point(43, 93);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(46, 13);
            this.lblProduit.TabIndex = 8;
            this.lblProduit.Text = "Produit :";
            // 
            // cmbProduit
            // 
            this.cmbProduit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produitBindingSource, "Id", true));
            this.cmbProduit.DataSource = this.produitBindingSource;
            this.cmbProduit.DisplayMember = "Libelle";
            this.cmbProduit.FormattingEnabled = true;
            this.cmbProduit.Location = new System.Drawing.Point(95, 90);
            this.cmbProduit.Name = "cmbProduit";
            this.cmbProduit.Size = new System.Drawing.Size(166, 21);
            this.cmbProduit.TabIndex = 6;
            this.cmbProduit.ValueMember = "Id";
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Produit);
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(43, 26);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(45, 13);
            this.lblFamille.TabIndex = 8;
            this.lblFamille.Text = "Famille :";
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.familleBindingSource, "Id", true));
            this.listBox1.DataSource = this.familleBindingSource;
            this.listBox1.DisplayMember = "Libelle";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(95, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 56);
            this.listBox1.TabIndex = 12;
            this.listBox1.ValueMember = "Id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // familleBindingSource
            // 
            this.familleBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.Famille);
            // 
            // btnProduitAjouter
            // 
            this.btnProduitAjouter.Location = new System.Drawing.Point(95, 187);
            this.btnProduitAjouter.Name = "btnProduitAjouter";
            this.btnProduitAjouter.Size = new System.Drawing.Size(84, 23);
            this.btnProduitAjouter.TabIndex = 13;
            this.btnProduitAjouter.Text = "Ajouter";
            this.btnProduitAjouter.UseVisualStyleBackColor = true;
            // 
            // FormProduitSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 222);
            this.Controls.Add(this.btnProduitAjouter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtQteKilo);
            this.Controls.Add(this.txtQteDemiKilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFamille);
            this.Controls.Add(this.lblProduit);
            this.Controls.Add(this.cmbProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduitSelect";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProduitSelect";
            this.Load += new System.EventHandler(this.FormProduitSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQteKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQteDemiKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtQteKilo;
        private System.Windows.Forms.NumericUpDown txtQteDemiKilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.ComboBox cmbProduit;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnProduitAjouter;
        private System.Windows.Forms.BindingSource familleBindingSource;
        private System.Windows.Forms.BindingSource produitBindingSource;

    }
}
