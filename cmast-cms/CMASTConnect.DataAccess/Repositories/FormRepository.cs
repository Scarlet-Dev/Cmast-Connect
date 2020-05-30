using CMASTConnect.DataAccess.Interfaces.IRepositories;
using CMASTConnect.DataAccess.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.DataAccess.Repositories
{
    class FormRepository : IFormRepository<Form>
    {
        private bool disposedValue;

        public FormRepository()
        {

        }

        public void DeleteRow(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertRow(Form model)
        {
            throw new NotImplementedException();
        }

        public List<Form> SearchTable(string name)
        {
            throw new NotImplementedException();
        }

        public List<Form> SearchTable(string name, int id)
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

        public string PublishForm(Form form)
        {
            throw new NotImplementedException();
        }

        public string UnPublishForm(Form form)
        {
            throw new NotImplementedException();
        }

        public IList<Form> Filter()
        {
            throw new NotImplementedException();
        }

        public IList<Form> Query()
        {
            throw new NotImplementedException();
        }
    }
}
