using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.forms;

namespace Com.GlagSoft.GsCommande
{
    public partial class MainForm : Form
    {
        FormProduitGestion _formProduitGestion = new FormProduitGestion();

        public MainForm()
        {
            InitializeComponent();
            AfficherAjoutCommande();
        }


        private void btnGestionProduit_Click(object sender, EventArgs e)
        {
            OpenGestionProduit();
        }

        private void OpenGestionProduit()
        {
            _formProduitGestion = new FormProduitGestion();
            _formProduitGestion.LoadAll();
            _formProduitGestion.CloseGestionProduitForm += CloseGestionProduitForm;
            _formProduitGestion.ShowDialog();
        }

        private void btnGestionFamille_Click(object sender, EventArgs e)
        {
            var form = new FormFamilleGestion();
            form.LoadAll();
            form.ShowDialog();
        }

        private void CloseGestionProduitForm()
        {
            _formProduitGestion.Close();
        }

        private void AfficherAjoutCommande()
        {
            ucCommandeRecherche1.Visible = false;
            ucCommandeAjouter1.Visible = true;
            ucListeProduit1.Visible = false;

            btnSauvegarder.Visible = true;
            btnModifier.Visible = false;
            btnImprimer.Visible = false;

            btnChercherCommande.Enabled = true;
            btnAjouterCommande.Enabled = false;
            btnListeProduits.Enabled = true;
        }

        private void AfficherRechercheCommmande()
        {
            ucCommandeRecherche1.Visible = true;
            ucCommandeAjouter1.Visible = false;
            ucListeProduit1.Visible = false;

            btnSauvegarder.Visible = false;
            btnModifier.Visible = true;
            btnImprimer.Visible = false;

            btnChercherCommande.Enabled = false;
            btnAjouterCommande.Enabled = true;
            btnListeProduits.Enabled = true;
        }

        private void AfficherListeCommande()
        {
            ucListeProduit1.Visible = true;
            ucCommandeAjouter1.Visible = false;
            ucCommandeRecherche1.Visible = false;

            btnSauvegarder.Visible = false;
            btnModifier.Visible = false;
            btnImprimer.Visible = true;

            btnChercherCommande.Enabled = true;
            btnAjouterCommande.Enabled = true;
            btnListeProduits.Enabled = false;
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



    }
}
