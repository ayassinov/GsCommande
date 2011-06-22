using System;
using System.Data;
using System.Data.SQLite;

namespace Com.GlagSoft.GsCommande.DataAccessObjects.Framework
{
    public class SqliteHelper : IDisposable
    {
        private static SqliteHelper _helper = new SqliteHelper();

        public static SqliteHelper Helper
        {
            get
            {
                if (_helper == null)
                    _helper = new SqliteHelper();

                return _helper;
            }
        }

        private const string ConnString = "Data Source=gscommande.db";

        private IDbConnection _connection;

        private IDbCommand _command;

        private IDbTransaction _transaction;

        private bool _isTransactional;

        private IDbConnection Connection
        {
            get { return _connection ?? (_connection = new SQLiteConnection(ConnString)); }
        }

        public SqliteHelper(string sqlText)
        {
            PrepareCommand(sqlText);
            _isTransactional = false;

            if (_transaction != null)
                throw new Exception("Transaction est encours !! en mode non transaction");
        }

        private SqliteHelper()
        {
        }

        public void BeginTransaction()
        {
            if (_transaction != null)
                throw new Exception("Transaction est d�j� encours !!");

            Connection.Open();
            _transaction = Connection.BeginTransaction(IsolationLevel.ReadCommitted);
            _isTransactional = true;
        }

        public void Commit()
        {
            _transaction.Commit();
            _isTransactional = false;
            Dispose();
        }

        public void RollBack()
        {
            _transaction.Rollback();
            if (_connection.State != ConnectionState.Closed)
                _connection.Close();

            _isTransactional = false;
            Dispose();
        }

        public void PrepareCommand(string sqlText)
        {
            _command = new SQLiteCommand
                                   {
                                       Connection = (SQLiteConnection)Connection,
                                       CommandText = sqlText,
                                       CommandType = CommandType.Text
                                   };

            if (_command.Connection.State == ConnectionState.Closed)
                _command.Connection.Open();
        }

        public void AddInParameter(string key, DbType dbType, object value)
        {
            _command.Parameters.Add(new SQLiteParameter { DbType = dbType, ParameterName = key, Value = value });
        }

        public CustomDataReader ExecuteQuery()
        {
            return new CustomDataReader(_command.ExecuteReader());
        }

        public int ExecuteCreateQuery()
        {
            var id = ExecuteScalar();

            if (id == null)
                throw new Exception("Object not inserted");

            return Convert.ToInt32(id);
        }

        public bool ExecuteNonQuery()
        {
            return _command.ExecuteNonQuery() > 0;
        }

        public object ExecuteScalar()
        {
            return _command.ExecuteScalar();
        }

        public void Dispose()
        {
            if (_isTransactional) // return if is in transaction.
                return;

            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }

            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            if (_command != null)
            {
                _command.Dispose();
                _command = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}