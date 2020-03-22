using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Contacts.Requests;
using Crm.v1.Clients.Contacts.Responses;

namespace Crm.v1.Clients.Contacts.Clients
{
    public interface IContactChangesClient
    {
        Task<ContactChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ContactChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}