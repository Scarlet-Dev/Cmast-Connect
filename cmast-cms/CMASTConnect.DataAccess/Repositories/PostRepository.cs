using CMASTConnect.Models.Search;
using CMASTConnect.Interfaces.IRepositories;
using CMASTConnect.Models.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMASTConnect.DataAccess.Repositories
{

    public class PostRepository : IPostRepository<Post, PostSearch>
    {
        private Guid _guid;
        private bool disposedValue;

        public Guid OperationId => _guid;

        public PostRepository() : this(Guid.NewGuid()) 
        {
        }

        public PostRepository(Guid guid)
        {
            this._guid = guid;
        }

        public async Task<int> DeleteRow(int id)
        {
            var command = new MySqlCommand($"delete from Post where id = ${id}");
            var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                return reader.RecordsAffected;
            }

            return 0;
        }

        public async Task<IList<Post>> Filter(PostSearch filters)
        {
            var selectCmd = new MySqlCommand();
            selectCmd.CommandType = CommandType.Text;

            var whereClause = new MySqlCommand();
            whereClause.CommandType = CommandType.Text;
            
            selectCmd.CommandText += "select * from posts limit 100";
            whereClause.CommandText += "";

            var table = new DataTable();
            var results = new List<Post>();

            var reader = await selectCmd.ExecuteReaderAsync();
            try
            {
                while (await reader.ReadAsync())
                {
                    table.Load(reader);
                    results.Add(table.Rows.Cast<Post>().First());
                }
            }
            catch (Exception e)
            {

            }
            return results;
        }

        public void InsertRow(Post model)
        {
            throw new NotImplementedException();
        }

        public IList<Post> Join()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Post>> SearchTable()
        {
            var results = new List<Post>();
            var table = new DataTable();

            var command = new MySqlCommand("select * from posts limit 100;");
            var reader = await command.ExecuteReaderAsync();
            while(await reader.ReadAsync())
            {
                table.Load(reader);
                results.Add(table.Rows.Cast<Post>().First());
            }
            return results;
        }

        public async Task<IList<Post>> SearchTable(int id)
        {
            var posts = await SearchTable();

            var searchResults = posts.Where(item => item.Id == id);
            var results = new List<Post>(searchResults);

            return results;
        }

        public void UpdateRow(int id, Post model)
        {
            throw new NotImplementedException();
        }

        public string PublishPost(Post post)
        {
            throw new NotImplementedException();
        }

        public string UnPublishPost(Post post)
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

    }
}
