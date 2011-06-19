using System;
using System.Windows.Forms;

namespace Com.GlagSoft.GsCommande.Outils
{
    public static class GestionException
    {
        public static void TraiterException(Exception exception, string title)
        {
            MessageBox.Show("Une inattendu s'est produite", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void TraiterException(Exception exception, string  msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}