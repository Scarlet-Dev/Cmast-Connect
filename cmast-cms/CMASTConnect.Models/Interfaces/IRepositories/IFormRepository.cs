using System.Threading.Tasks;

namespace CMASTConnect.Interfaces.IRepositories
{
    public interface IFormRepository<F, Fs>: IRepositoryBase<F>, IQueryRepoBase<F, Fs>
    {
        Task<int> PublishForm(int id);

        Task<int> UnPublishForm(int id);
    }
}
