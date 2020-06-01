using System;

namespace CMASTConnect.Interfaces.IServices
{
    public interface IEmailService<E>: IServiceBase<E>
    {
        Guid OperationId { get; }
    }
}
