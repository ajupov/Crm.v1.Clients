using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Companies.Models;
using Crm.v1.Clients.Companies.RequestParameters;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Companies.Clients
{
    public class CompaniesClient : ICompaniesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public CompaniesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Companies/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<Dictionary<string, CompanyType>> GetTypesAsync(string accessToken, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<Dictionary<string, CompanyType>>(
                UriBuilder.Combine(_url, "GetTypes"), null, accessToken, ct);
        }

        public Task<Dictionary<string, CompanyIndustryType>> GetIndustryTypesAsync(
            string accessToken,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<Dictionary<string, CompanyIndustryType>>(
                UriBuilder.Combine(_url, "GetIndustryTypes"), null, accessToken, ct);
        }

        public Task<Company> GetAsync(string accessToken, Guid id, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<Company>(UriBuilder.Combine(_url, "Get"), new {id}, accessToken, ct);
        }

        public Task<List<Company>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<Company>>(
                UriBuilder.Combine(_url, "GetList"), ids, accessToken, ct);
        }

        public Task<List<Company>> GetPagedListAsync(
            string accessToken,
            CompanyGetPagedListRequestParameter request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<Company>>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task<Guid> CreateAsync(string accessToken, Company company, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), company, accessToken, ct);
        }

        public Task UpdateAsync(string accessToken, Company company, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Update"), company, accessToken, ct);
        }

        public Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, accessToken, ct);
        }

        public Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, accessToken, ct);
        }
    }
}