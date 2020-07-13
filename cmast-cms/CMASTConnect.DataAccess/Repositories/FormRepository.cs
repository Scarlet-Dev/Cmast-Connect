using CMASTConnect.Interfaces.IRepositories;
using CMASTConnect.Models.DTO;
using CMASTConnect.Models.Models.Search;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMASTConnect.DataAccess.Repositories
{
    public class FormRepository : IFormRepository<Form, FormSearch>
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

        public Task<int> InsertRow(Form model)
        {
            throw new NotImplementedException();
        }

        public Task<int> PublishForm(int formId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Form>> SearchTable()
        {
            var selectCommand = new MySqlCommand("");
            var reader = await selectCommand.ExecuteReaderAsync();

            var table = new DataTable();
            var results = new List<Form>();
            while(await reader.ReadAsync())
            {
                table.Load(reader);
                results.Add(table.Rows.Cast<Form>().First());
            }
            return results;
        }

        public async Task<IList<Form>> SearchTable(int id)
        {
            var forms = await SearchTable();
            var query = forms.Where(item => item.Id == id);

            var results = new List<Form>(query);

            return results;
        }

        public Task<int> UnPublishForm(int formId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateRow(int id, Form model)
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
