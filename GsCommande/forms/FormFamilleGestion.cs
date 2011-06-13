using System;
using System.Drawing;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormFamilleGestion : Form
    {

        private readonly FamilleService _familleService = new FamilleService();

        private Famille _famille;

        public FormFamilleGestion()
        {
            InitializeComponent();
            LoadAll();
        }

        private void LoadAll()
        {
            lstFamille.DataSource = _familleService.ListAll();

            SwitchToAddMode(true); //add mode
        }

        private void SwitchToAddMode(bool isAddingMode)
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
                MessageBoxEx.Show(@"Vous devez entrer un libelle", @"Gestion des familles", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }


            try
            {
                if (isUpdate)
                {
                    if (_famille.Libelle.ToUpper().CompareTo(txtLibelle.Text.ToUpper()) == 0)
                    {
                        LoadAll();
                        return;
                    }
                    _famille.Libelle = txtLibelle.Text;
                    _familleService.Update(_famille);
                }
                else
                    _familleService.Create(new Famille() { Libelle = txtLibelle.Text });

                LoadAll();
            }
            catch (Exception)
            {

                MessageBoxEx.Show(@"Une erreur s'est produite lors de la sauvegarde de la donnée", @"Gestion des familles", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }

        private void Delete()
        {
            if (_famille == null)
                return;

            try
            {
                _familleService.Delete(_famille);
            }
            catch (Exception)
            {

                MessageBoxEx.Show("Une erreur s'est produite lors de la sauvegarde de la donnée", "Gestion des familles", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                AddOrUpdateFamille(_famille != null);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Z))
            {
                Delete();
                LoadAll();
                return true;
            }

            if (keyData == (Keys.Control | Keys.N))
            {
                SwitchToAddMode(true);
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
            LoadAll();
        }

        private void lstFamille_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                Delete();
                LoadAll();
            }
        }


        private void txtLibelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AddOrUpdateFamille(_famille != null);
            }
        }

        #endregion




    }
}
