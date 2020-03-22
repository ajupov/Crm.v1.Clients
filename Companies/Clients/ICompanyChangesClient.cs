using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Companies.Requests;
using Crm.v1.Clients.Companies.Responses;

namespace Crm.v1.Clients.Companies.Clients
{
    public interface ICompanyChangesClient
    {
        Task<CompanyChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            CompanyChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}