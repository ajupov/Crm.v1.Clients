using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Companies.Models;
using Crm.v1.Clients.Companies.RequestParameters;

namespace Crm.v1.Clients.Companies.Clients
{
    public interface ICompaniesClient
    {
        Task<Dictionary<string, CompanyType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<Dictionary<string, CompanyIndustryType>> GetIndustryTypesAsync(
            string accessToken,
            CancellationToken ct = default);

        Task<Company> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<Company>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<List<Company>> GetPagedListAsync(
            string accessToken,
            CompanyGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, Company company, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, Company company, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}