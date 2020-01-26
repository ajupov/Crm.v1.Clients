using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Companies.Models;
using Crm.v1.Clients.Companies.RequestParameters;

namespace Crm.v1.Clients.Companies.Clients
{
    public interface ICompanyAttributeChangesClient
    {
        Task<List<CompanyAttributeChange>> GetPagedListAsync(
            string accessToken,
            CompanyAttributeChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}