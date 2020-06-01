using System;

namespace CMASTConnect.Interfaces.IServices
{
    interface IEmailService<E>: IServiceBase<E>
    {
        Guid OperationId { get; }
    }
}
