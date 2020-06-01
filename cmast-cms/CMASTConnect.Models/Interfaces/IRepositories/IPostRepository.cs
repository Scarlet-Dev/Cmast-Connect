namespace CMASTConnect.Interfaces.IRepositories
{
    public interface IPostRepository<P, Ps>: IRepositoryBase<P>, IQueryRepoBase<P,Ps>
    {
        string PublishPost(P model);

        string UnPublishPost(P model);
    }
}
