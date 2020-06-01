namespace CMASTConnect.Interfaces.IRepositories
{
    public interface IFormRepository<F, Fs>: IRepositoryBase<F>, IQueryRepoBase<F, Fs>
    {
        string PublishForm(F model);

        string UnPublishForm(F model);
    }
}
