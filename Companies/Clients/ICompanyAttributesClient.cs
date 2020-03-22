using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.Common.All.Types.AttributeType;
using Crm.v1.Clients.Companies.Models;
using Crm.v1.Clients.Companies.Requests;
using Crm.v1.Clients.Companies.Responses;

namespace Crm.v1.Clients.Companies.Clients
{
    public interface ICompanyAttributesClient
    {
        Task<Dictionary<string, AttributeType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<CompanyAttribute> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<CompanyAttribute>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<CompanyAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            CompanyAttributeGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, CompanyAttribute attribute, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, CompanyAttribute attribute, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}