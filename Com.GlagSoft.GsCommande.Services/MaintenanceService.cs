using System;
using Com.GlagSoft.GsCommande.DataAccessObjects;

namespace Com.GlagSoft.GsCommande.Services
{
    public class MaintenanceService
    {
        MaintenanceData _maintenanceData = new MaintenanceData();

        public void CleanDataBase()
        {

            _maintenanceData.BeginTransaction();

            try
            {
                _maintenanceData.CleanDataBase();

                _maintenanceData.Commit();

                _maintenanceData.Vacuum();
            }
            catch (Exception exception)
            {
                _maintenanceData.RollBack();
                throw;
            }


        }

        public void CleanAll()
        {
            _maintenanceData.BeginTransaction();

            try
            {
                _maintenanceData.CleanAllData();

                _maintenanceData.Commit();

                _maintenanceData.Vacuum();
            }
            catch (Exception exception)
            {
                _maintenanceData.RollBack();
                throw;
            }
        }
    }
}