using System;
using System.Windows.Forms;
using NLog;

namespace Com.GlagSoft.GsCommande.Outils
{
    public static class GestionException
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void TraiterException(Exception exception, string title)
        {
            Logger.LogException(LogLevel.Error, exception.Message, exception);
            MessageBox.Show("Une erreur inattendu s'est produite pendant l'exécution du programme", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void TraiterException(Exception exception, string msg, string title)
        {
            Logger.LogException(LogLevel.Error, exception.Message, exception);
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void LogOnly(Exception exception)
        {
            Logger.LogException(LogLevel.Error, exception.Message, exception);
        }
    }
}