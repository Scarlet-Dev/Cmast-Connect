using CMASTConnect.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.DataAccess.Interfaces
{
    interface IUserRepository<U> : IRepositoryBase<U>, IQueryRepoBase<U>
    {
        string ResetPassword(U model);

        string UpdateProfile(U model);
    }
}
