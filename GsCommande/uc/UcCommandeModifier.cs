using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.uc
{
    public partial class UcCommandeModifier : UserControl
    {
        CommandeService _commandeService = new CommandeService();

        FormProduitSelect _formForCreate = new FormProduitSelect();

        public List<LigneCommande> LigneCommandes = new List<LigneCommande>();

        public Commande CommandeForUpdate { get; set; }

        public UcCommandeModifier()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            LigneCommandes = new List<LigneCommande>();
            dgvLigneCommande.DataSource = new List<LigneCommande>();

            try
            {
                lblIdCommande.Text = _commandeService.GetNextId().ToString();
            }
            catch (Exception e)
            {
                GestionException.TraiterException(e, "Ajout Commande");
            }


            txtClient.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now.Date;

            ShowHideButtons();
        }

        public void LoadForUpdate()
        {
            dgvLigneCommande.DataSource = LigneCommandes;

            if (dgvLigneCommande.RowCount > 0)
                dgvLigneCommande.Rows[0].Selected = true;
            lblIdCommande.Enabled = false;
            lblIdCommande.Text = CommandeForUpdate.Id.ToString();
            txtClient.Text = CommandeForUpdate.NomPrenomClient;
            dateTimePicker.Value = CommandeForUpdate.DateCommande.Value.Date;
            ShowHideButtons();
        }

        private void ShowHideButtons()
        {
            btnModifier.Enabled = dgvLigneCommande.SelectedRows.Count > 0;
            btnSupprimer.Enabled = dgvLigneCommande.SelectedRows.Count > 0;
        }

        public void SaveCommande()
        {
            try
            {
                if (LigneCommandes.Count == 0)
                {
                    MessageBox.Show(@"Vous devez ajouter des produits à la commande pour continuer",
                        @"Ajout commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var commande = new Commande()
                                   {
                                       Id = Convert.ToInt32(lblIdCommande.Text),
                                       DateCommande = dateTimePicker.Value,
                                       NomPrenomClient = txtClient.Text,
                                       IsLivree = false,
                                       LigneCommande = LigneCommandes
                                   };

                commande = _commandeService.Create(commande);

                Reset();

                MessageBox.Show(string.Format("La commande numéro {0}  a été ajouter avec succès", commande.Id),
                                @"Ajout commande", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Ajout commande");
            }
        }

        public void UpdateLigneCommande()
        {
            if (!btnModifier.Enabled)
                return;

            if (dgvLigneCommande.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Aucun produit séléctionné", @"Ajout Commande", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            _formForCreate = new FormProduitSelect
                        {
                            LigneCommande = dgvLigneCommande.SelectedRows[0].DataBoundItem as LigneCommande,
                            IsUpdate = true,
                            LigneCommandes = LigneCommandes
                        };

            OpenSelectionForm();
        }

        public void AddLigneCommande()
        {
            if (!btnAjouter.Enabled)
                return;

            _formForCreate = new FormProduitSelect { IsUpdate = false, LigneCommande = null, LigneCommandes = LigneCommandes };
            OpenSelectionForm();
        }

        public void DeleteLigneCommande()
        {
            if (!btnSupprimer.Enabled)
                return;

            if (dgvLigneCommande.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Aucun produit séléctionné", @"Ajout Commande", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(@"Vous êtes sur de vouloir retirer ce produit de la liste ?",
                @"Ajout commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _formForCreate.LigneCommande = null;

            var i = dgvLigneCommande.SelectedRows[0].Index;
            LigneCommandes.Remove(LigneCommandes[i]);
            dgvLigneCommande.DataSource = new List<LigneCommande>();
            dgvLigneCommande.DataSource = LigneCommandes;
            ShowHideButtons();
        }

        private void OpenSelectionForm()
        {
            _formForCreate.LoadAll();
            _formForCreate.CloseFormProduitSelect += form_CloseFormProduitSelect;
            _formForCreate.ShowDialog();
        }

        private void SaveChangeToGrid()
        {
            if (_formForCreate.LigneCommande != null)
            {
                if (_formForCreate.IsUpdate)
                {
                    var i = dgvLigneCommande.SelectedRows[0].Index;
                    LigneCommandes[i] = _formForCreate.LigneCommande;
                }
                else
                {
                    LigneCommandes.Add(_formForCreate.LigneCommande);
                }

                dgvLigneCommande.DataSource = new List<LigneCommande>();
                dgvLigneCommande.DataSource = LigneCommandes;
            }
        }

        private void form_CloseFormProduitSelect()
        {
            SaveChangeToGrid();
            ShowHideButtons();

            _formForCreate.LigneCommande = null;
            _formForCreate.Dispose();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
          //  if (ValidateIdCommande())
                AddLigneCommande();
        }

        private bool ValidateIdCommande()
        {
            if (string.IsNullOrEmpty(lblIdCommande.Text))
            {
                MessageBox.Show(@"Vous devez choisir un code pour la commande", @"Ajout Commande", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            int code;

            try
            {
                code = Convert.ToInt32(lblIdCommande.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Le code de la commande que vous avez choisie n'est pas valide", @"Ajout Commande", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return false;
            }


            if (_commandeService.IsCommandeIdExist(code))
            {
                MessageBox.Show(@"Le code que vous avez entré est utilié déjà par une autre commande.", @"Ajout Commande", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            UpdateLigneCommande();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DeleteLigneCommande();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F5))
            {
                if (btnAjouter.Enabled)
                    AddLigneCommande();
                return true;
            }

            if (keyData == (Keys.F6))
            {
                if (btnModifier.Enabled)
                    UpdateLigneCommande();
                return true;
            }

            if (keyData == (Keys.F7))
            {
                if (btnSupprimer.Enabled)
                    DeleteLigneCommande();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void UcCommandeAjouter_EnabledChanged(object sender, EventArgs e)
        {
            dgvLigneCommande.Enabled = this.Enabled;
        }
    }
}
