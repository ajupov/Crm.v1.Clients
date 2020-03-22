using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Companies.Requests;
using Crm.v1.Clients.Companies.Responses;

namespace Crm.v1.Clients.Companies.Clients
{
    public interface ICompanyAttributeChangesClient
    {
        Task<CompanyAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            CompanyAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}