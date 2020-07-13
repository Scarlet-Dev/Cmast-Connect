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
        public string CurrentUsername;

        public Guid OperationId => _guid;

        public PostRepository() : this(Guid.NewGuid()) 
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="guid"></param>
        public PostRepository(Guid guid)
        {
            this._guid = guid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> DeleteRow(int id)
        {
            var command = new MySqlCommand($"delete from Post where id = ${id}");
            var reader = await command.ExecuteReaderAsync();
            int recordsReturned = 0;

            while (await reader.ReadAsync())
            {
                recordsReturned = reader.RecordsAffected;
            }

            return recordsReturned;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<int> InsertRow(Post model)
        {
            var insertStmt = "insert into (title, category, " +
               "author, isPublished, publishedDate, updatedBy, " +
               "updatedOn) into";
            //Need to figure out how to auto increment id.
            var values = $"(${model.Title}, ${model.Category}, ${model.Author}," +
                $"${model.IsPublished}, ${model.PublishedDate}, ${model.UpdatedBy}" +
                $"${model.UpdatedOn});";

            var insertCommand = new MySqlCommand(String.Join(" ",
                insertStmt, values));

            var reader = await insertCommand.ExecuteReaderAsync();
            int recordsReturned = 0;

            while (await reader.ReadAsync())
            {
                recordsReturned = reader.RecordsAffected;
            }
            return recordsReturned;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Post> Join()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IList<Post>> SearchTable(int id)
        {
            var posts = await SearchTable();

            var searchResults = posts.Where(item => item.Id == id);
            var results = new List<Post>(searchResults);

            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<int> UpdateRow(int id, Post model)
        {
            //Finish update statement
            string updateStmt = "update post";
            string set = "set ";
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<int> PublishPost(int postId)
        {
            string updateStmt = "update post";
            string set = "set isPublished = 1" +
                $"publishedDate = ${DateTime.UtcNow}," +
                $"updatedBy = ${CurrentUsername}," +
                $"updatedOn = ${DateTime.UtcNow}";
            string where = $"where id = ${postId};";

            var publishCommand = new MySqlCommand(String.Join(" ", updateStmt, set, where));
            var reader = await publishCommand.ExecuteReaderAsync();
            int recordsReturned = 0;

            while (await reader.ReadAsync())
            {
                recordsReturned = reader.RecordsAffected;
            }

            return recordsReturned;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<int> UnPublishPost(int postId)
        {
            string updateStmt = "update post";
            string set = "set isPublished = 0, update," +
                $"updatedBy = ${CurrentUsername}," +
                $"updatedOn = ${DateTime.UtcNow}";
            string where = $"where id = ${postId};";

            var publishCommand = new MySqlCommand(String.Join(" ", updateStmt, set, where));
            var reader = await publishCommand.ExecuteReaderAsync();
            int recordsReturned = 0;

            while (await reader.ReadAsync())
            {
                recordsReturned = reader.RecordsAffected;
            }

            return recordsReturned;
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
