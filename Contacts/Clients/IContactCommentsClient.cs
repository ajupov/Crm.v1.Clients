using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Contacts.Models;
using Crm.v1.Clients.Contacts.Requests;
using Crm.v1.Clients.Contacts.Responses;

namespace Crm.v1.Clients.Contacts.Clients
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