using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Services;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormProduitSelect : Form
    {

        private readonly FamilleService _familleService = new FamilleService();
        private readonly ProduitService _produitService = new ProduitService();


        public FormProduitSelect()
        {
            InitializeComponent();
            LoadAll();
        }

        private void LoadAll()
        {
            listBox1.DataSource = _familleService.ListAll();

        }

        private void FormProduitSelect_Load(object sender, EventArgs e)
        {
            //cmbProduit.AutoCompleteCustomSource = new AutoCompleteStringCollection() { "Test", "Bonjour", "Aurevoir", "Merde", "TTPM" };
            //cmbProduit.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                var familleId = (int)listBox1.SelectedValue;
                cmbProduit.DataSource =
                    cmbProduit.DataSource = _produitService.GetByFamille(new Famille { Id = familleId });

            }
        }
    }
}
