﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Companies.Models;
using Crm.V1.Clients.Companies.Requests;
using Crm.V1.Clients.Companies.Responses;

namespace Crm.V1.Clients.Companies.Clients
{
    public interface ICompaniesClient
    {
        Task<Dictionary<string, CompanyType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<Dictionary<string, CompanyIndustryType>> GetIndustryTypesAsync(
            string accessToken,
            CancellationToken ct = default);

        Task<Company> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<Company>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<CompanyGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            CompanyGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, Company company, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, Company company, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}
