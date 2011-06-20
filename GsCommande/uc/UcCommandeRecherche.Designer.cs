namespace Com.GlagSoft.GsCommande.uc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new Com.GlagSoft.GsCommande.Outils.NullableDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsLivered = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPrenomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLivreeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.chkIsLivered);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnRecherche);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(106, 55);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.NullValue = "_";
            this.dateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker.TabIndex = 10;
            this.dateTimePicker.Value = new System.DateTime(2011, 6, 20, 15, 57, 31, 726);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 20);
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
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(289, 17);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(255, 20);
            this.txtClient.TabIndex = 3;
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
            // chkIsLivered
            // 
            this.chkIsLivered.AutoSize = true;
            this.chkIsLivered.Location = new System.Drawing.Point(289, 55);
            this.chkIsLivered.Name = "chkIsLivered";
            this.chkIsLivered.Size = new System.Drawing.Size(255, 17);
            this.chkIsLivered.TabIndex = 1;
            this.chkIsLivered.Text = "Inclure dans la recherche les commandes livrées";
            this.chkIsLivered.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commandes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateCommandeDataGridViewTextBoxColumn,
            this.nomPrenomClientDataGridViewTextBoxColumn,
            this.isLivreeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.commandeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Code";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCommandeDataGridViewTextBoxColumn
            // 
            this.dateCommandeDataGridViewTextBoxColumn.DataPropertyName = "DateCommande";
            this.dateCommandeDataGridViewTextBoxColumn.HeaderText = "Date commande";
            this.dateCommandeDataGridViewTextBoxColumn.Name = "dateCommandeDataGridViewTextBoxColumn";
            this.dateCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomPrenomClientDataGridViewTextBoxColumn
            // 
            this.nomPrenomClientDataGridViewTextBoxColumn.DataPropertyName = "NomPrenomClient";
            this.nomPrenomClientDataGridViewTextBoxColumn.HeaderText = "Nom Client";
            this.nomPrenomClientDataGridViewTextBoxColumn.Name = "nomPrenomClientDataGridViewTextBoxColumn";
            this.nomPrenomClientDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btnAll
            // 
            this.btnAll.ContextMenuStrip = this.contextMenuStrip1;
            this.btnAll.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.all;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(208, 90);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(96, 32);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "     &Tout";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(310, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 32);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "     &Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.ContextMenuStrip = this.contextMenuStrip1;
            this.btnRecherche.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Find;
            this.btnRecherche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecherche.Location = new System.Drawing.Point(106, 90);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(96, 32);
            this.btnRecherche.TabIndex = 0;
            this.btnRecherche.Text = "     &Chercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.toolStripMenuItem1.Text = "Inclure les commandes livrées ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // UcCommandeRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcCommandeRecherche";
            this.Size = new System.Drawing.Size(766, 426);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsLivered;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPrenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLivreeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private System.Windows.Forms.Label label4;
        private Outils.NullableDateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
