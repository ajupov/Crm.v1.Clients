using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Contacts.Models;
using Crm.V1.Clients.Contacts.Requests;
using Crm.V1.Clients.Contacts.Responses;

namespace Crm.V1.Clients.Contacts.Clients
{
    public interface IContactCommentsClient
    {
        Task<ContactCommentGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ContactCommentGetPagedListRequest request,
            CancellationToken ct = default);

        Task CreateAsync(string accessToken, ContactComment comment, CancellationToken ct = default);
    }
}
