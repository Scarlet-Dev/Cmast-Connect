using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMASTConnect.DataAccess.Interfaces
{
    interface IQueryRepoBase<Q>
    {
        IList<Q> Filter();

        IList<Q> Query();
    }
}
