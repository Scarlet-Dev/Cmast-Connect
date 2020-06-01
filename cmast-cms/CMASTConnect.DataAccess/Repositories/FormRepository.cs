using CMASTConnect.Interfaces.IRepositories;
using CMASTConnect.Models.DTO;
using CMASTConnect.Models.Models.Search;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CMASTConnect.DataAccess.Repositories
{
    class FormRepository : IFormRepository<Form, FormSearch>
    {
        private bool disposedValue;

        public Guid OperationId => throw new NotImplementedException();

        public Task<int> DeleteRow(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Form>> Filter(FormSearch filters)
        {
            throw new NotImplementedException();
        }

        public void InsertRow(Form model)
        {
            throw new NotImplementedException();
        }

        public string PublishForm(Form model)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Form>> SearchTable()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Form>> SearchTable(int id)
        {
            throw new NotImplementedException();
        }

        public string UnPublishForm(Form model)
        {
            throw new NotImplementedException();
        }

        public void UpdateRow(int id, Form model)
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
        // ~FormRepository()
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
