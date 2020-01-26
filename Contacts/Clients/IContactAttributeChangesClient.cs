using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Contacts.Models;
using Crm.v1.Clients.Contacts.RequestParameters;

namespace Crm.v1.Clients.Contacts.Clients
{
    public interface IContactAttributeChangesClient
    {
        Task<List<ContactAttributeChange>> GetPagedListAsync(
            string accessToken,
            ContactAttributeChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}