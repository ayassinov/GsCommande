using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.uc
{
    public partial class UcCommandeAjouter : UserControl
    {
        CommandeService _commandeService = new CommandeService();

        FormProduitSelect _form = new FormProduitSelect();

        List<LigneCommande> _ligneCommandes = new List<LigneCommande>();

        public UcCommandeAjouter()
        {
            InitializeComponent();
        }

        public void SaveCommande()
        {

            try
            {
                if (_ligneCommandes.Count == 0)
                {
                    MessageBox.Show(@"Vous devez ajouter des produits à la commande pour continuer",
                        @"Ajout commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var commande = new Commande()
                                   {
                                       DateCommande = dateTimePicker.Value,
                                       NomPrenomClient = txtClient.Text,
                                       IsLivree = false,
                                       LigneCommande = _ligneCommandes
                                   };

                commande = _commandeService.Create(commande);

                MessageBox.Show(string.Format("La commande numéro {0}  a été ajouter avec succès", commande.Id),
                                @"Ajout commande", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                GestionException.TraiterException(exception, "Ajout commande");
            }

        }

        private void UpdateLigneCommande()
        {
            if (dgvLigneCommande.SelectedRows.Count == 0)
                return;

            _form = new FormProduitSelect
                        {
                            LigneCommande = dgvLigneCommande.SelectedRows[0].DataBoundItem as LigneCommande,
                            IsUpdate = true,
                            LigneCommandes = _ligneCommandes
                        };
            OpenSelectionForm();
        }

        private void AddLigneCommande()
        {
            _form = new FormProduitSelect { IsUpdate = false, LigneCommande = null, LigneCommandes = _ligneCommandes };
            OpenSelectionForm();
        }

        private void DeleteLigneCommande()
        {
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

            _form.LigneCommande = null;

            var i = dgvLigneCommande.SelectedRows[0].Index;
            _ligneCommandes.Remove(_ligneCommandes[i]);
            dgvLigneCommande.DataSource = new List<LigneCommande>();
            dgvLigneCommande.DataSource = _ligneCommandes;
        }

        private void OpenSelectionForm()
        {
            _form.LoadAll();
            _form.CloseFormProduitSelect += new FormProduitSelect.CloseFormHandler(form_CloseFormProduitSelect);
            _form.ShowDialog();
        }

        private void SaveChangeToGrid()
        {
            if (_form.LigneCommande != null)
            {
                if (_form.IsUpdate)
                {
                    var i = dgvLigneCommande.SelectedRows[0].Index;
                    _ligneCommandes[i] = _form.LigneCommande;
                    dgvLigneCommande.DataSource = new List<LigneCommande>();
                    dgvLigneCommande.DataSource = _ligneCommandes;
                }
                else
                {
                    _ligneCommandes.Add(_form.LigneCommande);
                    dgvLigneCommande.DataSource = new List<LigneCommande>();
                    dgvLigneCommande.DataSource = _ligneCommandes;
                }
            }
        }

        private void form_CloseFormProduitSelect()
        {
            SaveChangeToGrid();

            _form.LigneCommande = null;
            _form.Dispose();
            // _form.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            AddLigneCommande();
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
    }
}
