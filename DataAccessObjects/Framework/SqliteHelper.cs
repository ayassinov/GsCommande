using System;
using System.Data;
using System.Data.SQLite;

namespace Com.GlagSoft.GsCommande.DataAccessObjects.Framework
{
    public class SqliteHelper : IDisposable
    {
        private const string ConnString = "Data Source=gscommande.db";

        private IDbConnection _connection;

        private IDbCommand _command;

        private IDbConnection Connection
        {
            get { return _connection ?? (_connection = new SQLiteConnection(ConnString)); }
        }

        public SqliteHelper(string sqlText)
        {

            PrepareCommand(sqlText);
        }

        private void PrepareCommand(string sqlText)
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
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
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