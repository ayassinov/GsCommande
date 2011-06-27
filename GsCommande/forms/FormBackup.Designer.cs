namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormBackup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvdbFiles = new System.Windows.Forms.DataGridView();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupRaisonString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullPathName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFermer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSauvegarder = new System.Windows.Forms.ToolStripButton();
            this.btnRestaurer = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdbFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbFileBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdbFiles
            // 
            this.dgvdbFiles.AllowUserToAddRows = false;
            this.dgvdbFiles.AllowUserToDeleteRows = false;
            this.dgvdbFiles.AutoGenerateColumns = false;
            this.dgvdbFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdbFiles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdbFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdbFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdbFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.BackupRaisonString,
            this.FullPathName});
            this.dgvdbFiles.DataSource = this.bbFileBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdbFiles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdbFiles.Location = new System.Drawing.Point(0, 105);
            this.dgvdbFiles.Name = "dgvdbFiles";
            this.dgvdbFiles.ReadOnly = true;
            this.dgvdbFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdbFiles.Size = new System.Drawing.Size(647, 348);
            this.dgvdbFiles.TabIndex = 1;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.FillWeight = 90F;
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Fichier";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.FillWeight = 80F;
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "Date Création";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BackupRaisonString
            // 
            this.BackupRaisonString.DataPropertyName = "BackupRaisonString";
            this.BackupRaisonString.HeaderText = "Commentaire";
            this.BackupRaisonString.Name = "BackupRaisonString";
            this.BackupRaisonString.ReadOnly = true;
            // 
            // FullPathName
            // 
            this.FullPathName.DataPropertyName = "FullPathName";
            this.FullPathName.HeaderText = "FullPathName";
            this.FullPathName.Name = "FullPathName";
            this.FullPathName.ReadOnly = true;
            this.FullPathName.Visible = false;
            // 
            // bbFileBindingSource
            // 
            this.bbFileBindingSource.DataSource = typeof(Com.GlagSoft.GsCommande.Objects.DataBaseFile);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFermer,
            this.toolStripSeparator1,
            this.btnSauvegarder,
            this.btnRestaurer,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(647, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFermer
            // 
            this.btnFermer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.Exit;
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFermer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(72, 36);
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.backup_manager;
            this.btnSauvegarder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSauvegarder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(108, 36);
            this.btnSauvegarder.Text = "&Sauvegarder";
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // btnRestaurer
            // 
            this.btnRestaurer.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.backup_and_restore;
            this.btnRestaurer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRestaurer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRestaurer.Name = "btnRestaurer";
            this.btnRestaurer.Size = new System.Drawing.Size(92, 36);
            this.btnRestaurer.Text = "&Restaurer";
            this.btnRestaurer.Click += new System.EventHandler(this.btnRestaurer_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Com.GlagSoft.GsCommande.Properties.Resources.drive_delete;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 36);
            this.btnDelete.Text = "S&upprimer sauvegarde";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBackupPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.AutoSize = true;
            this.lblBackupPath.Location = new System.Drawing.Point(155, 20);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(0, 13);
            this.lblBackupPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Répertoire de sauvegarde :";
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 453);
            this.Controls.Add(this.dgvdbFiles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GsCommande - Sauvegarde/Restauration";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdbFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbFileBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdbFiles;
        private System.Windows.Forms.BindingSource bbFileBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFermer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRestaurer;
        private System.Windows.Forms.ToolStripButton btnSauvegarder;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupRaisonString;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPathName;



    }
}
