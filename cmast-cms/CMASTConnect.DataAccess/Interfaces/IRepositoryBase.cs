using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.DataAccess.Interfaces
{
    internal interface IRepositoryBase<T> : IDisposable
    {
        List<T> SearchTable(string name);

        List<T> SearchTable(string name, int id);

        void InsertRow(T model);

        void UpdateRow(int id, T model);

        void DeleteRow(int id);
    }
}
