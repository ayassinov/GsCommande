using System.Windows.Forms;
using GsUpdater.Framework.Tasks;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        public void Init(IUpdateTask currentUpdate)
        {
            // lblDate.Text = currentUpdate.
            lblVersion.Text = currentUpdate.FileVersion.ToString();
            lblTaille.Text = currentUpdate.FileLength.ToString();
            lblSignature.Text = currentUpdate.Checksum;
            txtDescription.Text = currentUpdate.Description;
            txtDescription.ReadOnly = true;
        }

        private void btnFermer_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            GsUpdater.Framework.UpdateManager.Instance.DoUpdate();
        }
    }
}
