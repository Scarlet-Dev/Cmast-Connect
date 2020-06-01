namespace CMASTConnect.Interfaces.IRepositories
{
    public interface IUserRepository<U, Us> : IRepositoryBase<U>, IQueryRepoBase<U,Us>
    {
        string ResetPassword(U model);

        string UpdateProfile(U model);
    }
}
