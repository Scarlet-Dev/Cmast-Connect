using System;
using System.Collections.Generic;
using System.Text;
using CMASTConnect.Models.DTO;
using MySql.Data.MySqlClient;
using MySqlConnector;

namespace CMASTConnect.DataAccess
{
    public class CmastConnectDbConnection : IDisposable
    {
        public readonly MySqlConnection MySql;
        private bool disposedValue;

        public CmastConnectDbConnection() : this(String.Empty) { }

        public CmastConnectDbConnection(string connection)
        {
            MySql = new MySqlConnection(connection);
            OpenDB();
        }

        private async void OpenDB()
        {
            //await MySql.OpenAsync();
        }
        

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    MySql.CloseAsync();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
