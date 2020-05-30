namespace CMASTConnect.DataAccess.Interfaces.IRepositories
{
    interface IFormRepository<F>: IRepositoryBase<F>, IQueryRepoBase<F>
    {
        string PublishForm(F model);

        string UnPublishForm(F model);
    }
}
