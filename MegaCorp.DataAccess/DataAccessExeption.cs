using System;
using System.Runtime.Serialization;

namespace MegaCorp.DataAccess
{
    [Serializable]
    public class DataAccessExeption : Exception
    {
        public DataAccessExeption(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}