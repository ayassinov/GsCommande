using System;
using System.Data;

namespace Com.GlagSoft.GsCommande.DataAccessObjects.Framework
{
    public class CustomDataReader : IDisposable
    {
        private const int NotExistIndexColumnValue = -1;

        public IDataReader Reader { get; set; }

        public CustomDataReader(IDataReader reader)
        {
            Reader = reader;
        }

        public bool Read()
        {
            return Reader.Read();
        }

        public bool GetBoolFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);

            if (numcol == NotExistIndexColumnValue)
                return false;

            return !(Reader.IsDBNull(numcol)) && Reader.GetBoolean(numcol);
        }

        public string GetStringFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? null : Reader.GetString(numcol);
        }

        public int? GetIntNullableFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? (int?)null : Reader.GetInt32(numcol);
        }

        public int GetIntFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? -1 : Reader.GetInt32(numcol);
        }

        public long GetLongFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? -1 : Reader.GetInt64(numcol);
        }

        public byte[] GetBlobFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? null : (byte[])Reader.GetValue(numcol);
        }

        public DateTime GetDateTimeFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? DateTime.MinValue : Reader.GetDateTime(numcol);
        }

        public DateTime? GetDateTimeNullableFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? (DateTime?)null : Reader.GetDateTime(numcol);
        }

        public double GetDoubleFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? -1 : Reader.GetDouble(numcol);
        }

        public double? GetDoubleNullableFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? (double?)null : Reader.GetDouble(numcol);
        }

        public float GetFloatFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? -1 : Reader.GetFloat(numcol);
        }

        public TimeSpan GetTimeSpanFromReader(string col)
        {
            var numcol = GetIndexFromColumnName(col);
            return numcol == NotExistIndexColumnValue || Reader.IsDBNull(numcol) ? new TimeSpan(0, 0, 0, 0) : (TimeSpan)Reader.GetValue(numcol);
        }

        private int GetIndexFromColumnName(string columnName)
        {
            return Reader.GetOrdinal(columnName);
        }

        public void Dispose()
        {
            if (Reader != null)
            {
                Reader.Dispose();
                Reader = null;
            }
        }
    }
}