using System.Threading.Tasks;

namespace CMASTConnect.Interfaces.IRepositories
{
    public interface IPostRepository<P, Ps>: IRepositoryBase<P>, IQueryRepoBase<P,Ps>
    {
        Task<int> PublishPost(int id);

        Task<int> UnPublishPost(int id);
    }
}
