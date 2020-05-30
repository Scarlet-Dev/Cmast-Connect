using System;
using System.Collections.Generic;
using System.Text;
using CMASTConnect.DataAccess.Interfaces;
using CMASTConnect.DTO.Models;

namespace CMASTConnect.DataAccess.Repositories
{
    public class UserRepository : IUserRepository<User>
    {
        private bool disposedValue;

        public UserRepository()
        {

        }

        public void DeleteRow(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> Filter()
        {
            throw new NotImplementedException();
        }

        public void InsertRow(User model)
        {
            throw new NotImplementedException();
        }

        public IList<User> Query()
        {
            throw new NotImplementedException();
        }

        public List<User> SearchTable(string name)
        {
            throw new NotImplementedException();
        }

        public List<User> SearchTable(string name, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRow(int id, User model)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UserRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string ResetPassword(User user)
        {
            throw new NotImplementedException();
        }

        public string UpdateProfile(User user)
        {
            throw new NotImplementedException();
        }
    }
}
