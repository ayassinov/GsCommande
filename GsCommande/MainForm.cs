using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.forms;

namespace Com.GlagSoft.GsCommande
{
    public partial class MainForm : Form
    {
        FormProduitGestion _formProduitGestion = new FormProduitGestion();
        FormFamilleGestion _formFamilleGestion = new FormFamilleGestion();
        FormCommandeDetail _fomCommandeDetail = new FormCommandeDetail();

        public MainForm()
        {
            InitializeComponent();
            AfficherAjoutCommande();
        }

        private void OpenGestionProduit()
        {
            _formProduitGestion = new FormProduitGestion();
            _formProduitGestion.LoadAll();
            _formProduitGestion.CloseGestionProduitForm += CloseGestionProduitForm;
            _formProduitGestion.ShowDialog();
        }

        private void OpenGestionFamille()
        {
            _formFamilleGestion = new FormFamilleGestion();
            _formFamilleGestion.CloseGestionFamilleForm += CloseGestionFamilleForm;
            _formFamilleGestion.LoadAll();
            _formFamilleGestion.ShowDialog();
        }

        private void OpenCommandeDetail()
        {
            _fomCommandeDetail = new FormCommandeDetail();
            _fomCommandeDetail.CloseCommandeDetailForm += CloseCommandeDetailForm;
            _fomCommandeDetail.SelectedCommande = ucCommandeRecherche1.SelectedCommande;
            _fomCommandeDetail.LoadAll();
            _fomCommandeDetail.ShowDialog();
        }

        private void btnGestionProduit_Click(object sender, EventArgs e)
        {
            OpenGestionProduit();
        }

        private void btnGestionFamille_Click(object sender, EventArgs e)
        {
            OpenGestionFamille();
        }

        private void CloseGestionProduitForm()
        {
            _formProduitGestion.Close();
            _formProduitGestion.Dispose();
        }

        private void CloseGestionFamilleForm()
        {
            _formFamilleGestion.Close();
            _formFamilleGestion.Dispose();
        }

        private void CloseCommandeDetailForm()
        {
            _fomCommandeDetail.Close();
            _fomCommandeDetail.Dispose();
            ucCommandeRecherche1.Recherche(); // reload the last search result.
        }

        private void AfficherAjoutCommande()
        {
            ucCommandeAjouter1.Reset();

            ucCommandeRecherche1.Visible = false;
            ucCommandeAjouter1.Visible = true;
            ucListeProduit1.Visible = false;

            btnSauvegarder.Visible = true;
            btnDetail.Visible = false;
            btnImprimer.Visible = false;

            btnChercherCommande.Enabled = true;
            btnAjouterCommande.Enabled = false;
            btnListeProduits.Enabled = true;
        }

        private void AfficherRechercheCommmande()
        {
            ucCommandeRecherche1.ChangeSelectedCommande += ucCommandeRecherche1_ChangeSelectedCommande;
            ucCommandeRecherche1.Reset();

            ucCommandeRecherche1.Visible = true;
            ucCommandeAjouter1.Visible = false;
            ucListeProduit1.Visible = false;

            btnSauvegarder.Visible = false;
            btnDetail.Visible = true;
            btnImprimer.Visible = false;

            btnChercherCommande.Enabled = false;
            btnAjouterCommande.Enabled = true;
            btnListeProduits.Enabled = true;
        }

        private void AfficherListeCommande()
        {
            ucListeProduit1.LoadAll();
            btnImprimer.Enabled = ucListeProduit1.IsShowPrintButton;

            ucListeProduit1.Visible = true;
            ucCommandeAjouter1.Visible = false;
            ucCommandeRecherche1.Visible = false;

            btnSauvegarder.Visible = false;
            btnDetail.Visible = false;
            btnImprimer.Visible = true;

            btnChercherCommande.Enabled = true;
            btnAjouterCommande.Enabled = true;
            btnListeProduits.Enabled = false;
        }

        private void ucCommandeRecherche1_ChangeSelectedCommande()
        {
            btnDetail.Enabled = ucCommandeRecherche1.SelectedCommande != null;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F2))
            {
                if (btnAjouterCommande.Enabled)
                    AfficherAjoutCommande();
                return true;
            }

            if (keyData == (Keys.F3))
            {
                if (btnChercherCommande.Enabled)
                    AfficherRechercheCommmande();
                return true;
            }

            if (keyData == (Keys.F4))
            {
                if (btnListeProduits.Enabled)
                    AfficherListeCommande();
                return true;
            }

            if (keyData == (Keys.F5))
            {
                if (!btnAjouterCommande.Enabled)
                    ucCommandeAjouter1.AddLigneCommande();
                return true;
            }

            if (keyData == (Keys.F6))
            {
                if (!btnAjouterCommande.Enabled)
                    ucCommandeAjouter1.UpdateLigneCommande();
                return true;
            }

            if (keyData == (Keys.F7))
            {
                if (!btnAjouterCommande.Enabled)
                    ucCommandeAjouter1.DeleteLigneCommande();
                return true;
            }

            if (keyData == (Keys.F11))
            {
                OpenGestionFamille();
                return true;
            }

            if (keyData == (Keys.F12))
            {
                OpenGestionProduit();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {
            AfficherAjoutCommande();
        }

        private void btnChercherCommande_Click(object sender, EventArgs e)
        {
            AfficherRechercheCommmande();
        }

        private void btnListeProduits_Click(object sender, EventArgs e)
        {
            AfficherListeCommande();
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            ucCommandeAjouter1.SaveCommande();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            OpenCommandeDetail();
        }
    }
}
