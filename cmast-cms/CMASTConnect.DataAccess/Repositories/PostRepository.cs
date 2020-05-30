using CMASTConnect.DataAccess.Interfaces;
using CMASTConnect.DTO.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.DataAccess.Repositories
{
    class PostRepository : IPostRepository<Post>
    {
        private bool disposedValue;

        public PostRepository()
        {
        }

        public void DeleteRow(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Post> Filter()
        {
            throw new NotImplementedException();
        }

        public void InsertRow(Post model)
        {
            throw new NotImplementedException();
        }

        public IList<Post> Query()
        {
            throw new NotImplementedException();
        }

        public List<Post> SearchTable(string name)
        {
            throw new NotImplementedException();
        }

        public List<Post> SearchTable(string name, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateRow(int id, Post model)
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
        // ~PostRepository()
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

        public string PublishPost(Post post)
        {
            throw new NotImplementedException();
        }

        public string UnPublishPost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
