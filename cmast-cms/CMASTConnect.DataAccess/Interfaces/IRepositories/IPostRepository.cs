using System;
using System.Collections.Generic;
using System.Text;

namespace CMASTConnect.DataAccess.Interfaces
{
    interface IPostRepository<P>: IRepositoryBase<P>, IQueryRepoBase<P>
    {
        string PublishPost(P model);

        string UnPublishPost(P model);
    }
}
