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
        }

        private void ucCommandeAjouter1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form = new FormFamilleGestion();
            form.LoadAll();
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            _formProduitGestion = new FormProduitGestion();
            _formProduitGestion.LoadAll();
            _formProduitGestion.CloseGestionProduitForm += CloseGestionProduitForm;
            _formProduitGestion.ShowDialog();
        }

        private void CloseGestionProduitForm()
        {
            _formProduitGestion.Close();
        }
    }
}
