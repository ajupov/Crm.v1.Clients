using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Companies.Models;
using Crm.v1.Clients.Companies.RequestParameters;

namespace Crm.v1.Clients.Companies.Clients
{
    public interface ICompanyCommentsClient
    {
        Task<List<CompanyComment>> GetPagedListAsync(
            string accessToken,
            CompanyCommentGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task CreateAsync(string accessToken, CompanyComment comment, CancellationToken ct = default);
    }
}