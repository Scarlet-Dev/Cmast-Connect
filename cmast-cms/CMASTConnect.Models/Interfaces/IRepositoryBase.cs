using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMASTConnect.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable
    {
        Guid OperationId { get; }

        Task<IList<T>> SearchTable();

        Task<IList<T>> SearchTable(int id);

        Task<int> InsertRow(T model);

        Task<int> UpdateRow(int id, T model);

        Task<int> DeleteRow(int id);
    }
}
