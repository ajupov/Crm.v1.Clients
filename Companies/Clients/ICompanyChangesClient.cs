using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Companies.Models;
using Crm.v1.Clients.Companies.RequestParameters;

namespace Crm.v1.Clients.Companies.Clients
{
    public interface ICompanyChangesClient
    {
        Task<List<CompanyChange>> GetPagedListAsync(
            string accessToken,
            CompanyChangeGetPagedListRequestParameter request,
            CancellationToken ct = default);
    }
}