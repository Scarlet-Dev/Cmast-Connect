using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CMASTConnect.Interfaces.IRepositories;
using CMASTConnect.Models.DTO;
using CMASTConnect.Models.Search;

namespace CMASTConnect.Repositories
{
    public class UserRepository : IUserRepository<User, UserSearch>
    {
        private bool disposedValue;

        public Guid OperationId => throw new NotImplementedException();

        public Task<int> DeleteRow(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> Filter(UserSearch filters)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertRow(User model)
        {
            throw new NotImplementedException();
        }

        public string ResetPassword(User model)
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> SearchTable()
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> SearchTable(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateProfile(User model)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateRow(int id, User model)
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
    }
}
