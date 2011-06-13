using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GlagSoft.GsCommande.forms;

namespace Com.GlagSoft.GsCommande
{
    public partial class MainForm : Form
    {
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
            form.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var form = new FormProduitGestion();
            form.ShowDialog();
        }
    }
}
