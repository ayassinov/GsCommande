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

        public List<LigneCommande> LigneCommandes = new List<LigneCommande>();

        public Commande CommandeForUpdate { get; set; }

        public UcCommandeAjouter()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            dgvLigneCommande.DataSource = new List<Commande>();
            txtClient.Text = string.Empty;
            dateTimePicker.Value = DateTime.Now.Date;
            LoadAll();
        }

        public void LoadForUpdate()
        {
            dgvLigneCommande.DataSource = LigneCommandes;
            if (dgvLigneCommande.RowCount > 0)
                dgvLigneCommande.Rows[0].Selected = true;
            txtClient.Text = CommandeForUpdate.NomPrenomClient;
            dateTimePicker.Value = CommandeForUpdate.DateCommande.Value.Date;
            LoadAll();
        }

        private void LoadAll()
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

            _form = new FormProduitSelect
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

            _form = new FormProduitSelect { IsUpdate = false, LigneCommande = null, LigneCommandes = LigneCommandes };
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

            _form.LigneCommande = null;

            var i = dgvLigneCommande.SelectedRows[0].Index;
            LigneCommandes.Remove(LigneCommandes[i]);
            dgvLigneCommande.DataSource = new List<LigneCommande>();
            dgvLigneCommande.DataSource = LigneCommandes;
            LoadAll();
        }

        private void OpenSelectionForm()
        {
            _form.LoadAll();
            _form.CloseFormProduitSelect += form_CloseFormProduitSelect;
            _form.ShowDialog();
        }

        private void SaveChangeToGrid()
        {
            if (_form.LigneCommande != null)
            {
                if (_form.IsUpdate)
                {
                    var i = dgvLigneCommande.SelectedRows[0].Index;
                    LigneCommandes[i] = _form.LigneCommande;
                    dgvLigneCommande.DataSource = new List<LigneCommande>();
                    dgvLigneCommande.DataSource = LigneCommandes;
                }
                else
                {
                    LigneCommandes.Add(_form.LigneCommande);
                    dgvLigneCommande.DataSource = new List<LigneCommande>();
                    dgvLigneCommande.DataSource = LigneCommandes;
                }
            }
        }

        private void form_CloseFormProduitSelect()
        {
            SaveChangeToGrid();
            LoadAll();

            _form.LigneCommande = null;
            //   _form.Close();
            _form.Dispose();
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

        private void UcCommandeAjouter_EnabledChanged(object sender, EventArgs e)
        {
            if(this.Enabled)
            {
                dgvLigneCommande.Enabled = true;
            }
            else
            {
                dgvLigneCommande.Enabled = false;
            }
        }
    }
}
