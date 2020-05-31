using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Companies.Models;
using Crm.V1.Clients.Companies.Requests;
using Crm.V1.Clients.Companies.Responses;

namespace Crm.V1.Clients.Companies.Clients
{
    public interface ICompanyCommentsClient
    {
        Task<CompanyCommentGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            CompanyCommentGetPagedListRequest request,
            CancellationToken ct = default);

        Task CreateAsync(string accessToken, CompanyComment comment, CancellationToken ct = default);
    }
}
