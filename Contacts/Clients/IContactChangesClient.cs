using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Contacts.Models;
using Crm.v1.Clients.Contacts.RequestParameters;

namespace Crm.v1.Clients.Contacts.Clients
{
    public interface IContactChangesClient
    {
        Task<List<ContactChange>> GetPagedListAsync(
            string accessToken,
            ContactChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}