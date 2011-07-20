using System;
using System.Windows.Forms;
using GsUpdater.Framework.Tasks;

namespace Com.GlagSoft.GsCommande.forms
{
    partial class FormUpdate : Form
    {
        private const double TauxConversion = 0.0000009409;

        public FormUpdate()
        {
            InitializeComponent();
        }

        public void Init(IUpdateTask currentUpdate)
        {
            // lblDate.Text = currentUpdate.
            lblVersion.Text = currentUpdate.FileVersion.ToString();
            lblTaille.Text = ConvertByteToMegaByte(currentUpdate.FileLength.ToString());
            txtSignature.Text = currentUpdate.Checksum;
            txtDescription.Text = currentUpdate.Description;
            txtDescription.ReadOnly = true;
        }

        private string ConvertByteToMegaByte(string svalue)
        {
            try
            {
                int value = Convert.ToInt32(svalue);
                var fvalue = value * TauxConversion;
                return String.Format("{0:0.##} Mb", fvalue);

            }
            catch (Exception)
            {
                return string.Empty;
            }

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
