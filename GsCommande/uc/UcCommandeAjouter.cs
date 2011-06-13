using System;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.forms;

namespace Com.GlagSoft.GsCommande.uc
{
    public partial class UcCommandeAjouter : UserControl
    {
        public UcCommandeAjouter()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectProduit_Click(object sender, EventArgs e)
        {
            var form = new FormProduitSelect();
            form.ShowDialog();
        }
    }
}
