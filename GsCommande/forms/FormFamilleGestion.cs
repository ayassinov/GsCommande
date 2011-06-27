using System;
using System.Drawing;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormFamilleGestion : Form
    {
        private readonly FamilleService _familleService = new FamilleService();

        private Famille _famille;

        public delegate void CloseFormHandler();

        public event CloseFormHandler CloseGestionFamilleForm;

        public FormFamilleGestion()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            try
            {
                familleBindingSource.DataSource = _familleService.ListAll();
                lstFamille.DataSource = familleBindingSource.DataSource;
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des familles");
            }


            SwitchToAddMode(true); //add mode
        }

        private void SwitchToAddMode(bool isAddingMode)
        {
            try
            {
                if (isAddingMode)
                {
                    groupBox3.Text = @"Ajout d'une famille :";
                    WriteToStatus("Ajout d'une famille...");
                    txtLibelle.Text = string.Empty;
                    txtLibelle.Focus();
                    txtLibelle.Select();

                    lstFamille.SelectedIndex = -1;
                    _famille = null;

                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                }
                else
                {
                    groupBox3.Text = @"Modifier Famille :";
                    WriteToStatus(string.Format("Modification de la famille : {0}", _famille.Libelle));
                    txtLibelle.Text = _famille.Libelle;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = true;

                    txtLibelle.Focus();
                }
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Gestion des familles");
            }
        }

        private void WriteToStatus(string msg)
        {
            toolStripStatusLabel1.Text = msg;
        }

        private void AddOrUpdateFamille(bool isUpdate)
        {
            if (string.IsNullOrEmpty(txtLibelle.Text.Trim()))
            {
                MessageBox.Show(@"Vous devez entrer un libelle", @"Gestion des familles", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }


            try
            {
                if (isUpdate)
                {
                    if (_famille.Libelle.ToUpper().CompareTo(txtLibelle.Text.ToUpper()) == 0)
                    {
                        MessageBox.Show(@"Vous devez faire au moins un changement", @"Gestion des familles", MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                        return;
                    }
                    _famille.Libelle = txtLibelle.Text;
                    _familleService.Update(_famille);
                }
                else
                    _familleService.Create(new Famille() { Libelle = txtLibelle.Text });

                LoadAll();
            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, @"Une erreur s'est produite lors de la sauvegarde des données", @"Gestion des familles");
            }
        }

        private void Delete()
        {
            try
            {
                if (MessageBox.Show(@"Vous confirmer la suppression de la famille : " + _famille.Libelle,
                                    @"Gestion des produits",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var isCanDelete = _familleService.IsCanDelete(_famille);
                    if (isCanDelete)
                    {
                        _familleService.Delete(_famille);
                        LoadAll();
                    }

                    else
                    {
                        MessageBox.Show(@"Il est impossible de supprimer la famille car elle contient des produits." +
                            @" Il faut supprimer les produits liées avant de supprimer la famille.",
                                        @"Gestion des produits",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, @"Une erreur s'est produite lors de la sauvegarde de la donnée", @"Gestion des familles");
            }
        }

        private void OnCloseForm()
        {
            if (CloseGestionFamilleForm != null)
                CloseGestionFamilleForm();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                if (btnSave.Enabled)
                    AddOrUpdateFamille(_famille != null);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Z))
            {
                if (btnDelete.Enabled)
                    Delete();
                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                if (btnAdd.Enabled)
                    SwitchToAddMode(true);
                return true;
            }

            if (keyData == (Keys.Escape))
            {
                OnCloseForm();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region event

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SwitchToAddMode(true);
        }

        private void lstFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFamille.SelectedValue != null)
            {
                _famille = lstFamille.SelectedItem as Famille;
                SwitchToAddMode(false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddOrUpdateFamille(_famille != null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void lstFamille_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                Delete();
            }
        }

        private void txtLibelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AddOrUpdateFamille(_famille != null);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            OnCloseForm();
        }

        #endregion
    }
}
