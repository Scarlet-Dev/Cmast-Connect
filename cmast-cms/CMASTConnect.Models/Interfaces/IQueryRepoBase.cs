using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMASTConnect.Interfaces
{
    public interface IQueryRepoBase<Q, Qs>
    {
        Task<IList<Q>> Filter(Qs filters);

    }
}
