using System;
using System.IO;
using Com.GlagSoft.GsCommande.DataAccessObjects;
using Com.GlagSoft.GsCommande.DataAccessObjects.Framework;
using Com.GlagSoft.GsCommande.Objects;
using Com.GlagSoft.GsCommande.Outils;

namespace Com.GlagSoft.GsCommande.Services
{
    public class MaintenanceService
    {
        MaintenanceData _maintenanceData = new MaintenanceData();

        public void CleanDataBase()
        {

            BaseData.BeginTransaction();

            try
            {
                _maintenanceData.CleanDataBase();

                BaseData.Commit();

                _maintenanceData.Vacuum();
            }
            catch (Exception)
            {
                BaseData.RollBack();
                throw;
            }


        }

        public void CleanAll()
        {
            BaseData.BeginTransaction();

            try
            {
                _maintenanceData.CleanAllData();

                BaseData.Commit();

                _maintenanceData.Vacuum();
            }
            catch (Exception)
            {
                BaseData.RollBack();
                throw;
            }
        }

        public bool IsDataBaseValid()
        {
            var isValide = false;

            try
            {
                isValide = _maintenanceData.IsDataBaseValid();
            }
            catch (Exception exception)
            {
                GestionException.LogOnly(exception);
                throw;
            }

            return isValide;
        }

        public void RestaurerBase(DataBaseFile selectedFile)
        {
            var fileToCopy = Path.Combine(GestionParametre.Instance.RestoreFolder, selectedFile.FileName);

            File.Copy(fileToCopy, GestionParametre.Instance.DataBaseFilePath, true);
        }

        public void BackupDataBase(BackupRaison backupRaison)
        {
            var fileToSave = string.Format("{0}{1}{2}{3}{4}{5}{6}.db",
                                                 (int)backupRaison,
                                                 DateTime.Now.Day.ToString("00"),
                                                 DateTime.Now.Month.ToString("00"),
                                                 DateTime.Now.Year.ToString("00"),
                                                 DateTime.Now.Hour.ToString("00"),
                                                 DateTime.Now.Minute.ToString("00"),
                                                 DateTime.Now.Second.ToString("00"));

            fileToSave = Path.Combine(GestionParametre.Instance.RestoreFolder, fileToSave);

            File.Copy(GestionParametre.Instance.DataBaseFilePath, fileToSave);
        }
    }
}