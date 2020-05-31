using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.Common.All.Types.AttributeType;
using Crm.V1.Clients.Companies.Models;
using Crm.V1.Clients.Companies.Requests;
using Crm.V1.Clients.Companies.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.V1.Clients.Companies.Clients
{
    public class CompanyAttributesClient : ICompanyAttributesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public CompanyAttributesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Companies/Attributes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<Dictionary<string, AttributeType>> GetTypesAsync(string accessToken, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<Dictionary<string, AttributeType>>(
                UriBuilder.Combine(_url, "GetTypes"), null, accessToken, ct);
        }

        public Task<CompanyAttribute> GetAsync(string accessToken, Guid id, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<CompanyAttribute>(
                UriBuilder.Combine(_url, "Get"), new {id}, accessToken, ct);
        }

        public Task<List<CompanyAttribute>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<CompanyAttribute>>(
                UriBuilder.Combine(_url, "GetList"), ids, accessToken, ct);
        }

        public Task<CompanyAttributeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            CompanyAttributeGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<CompanyAttributeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task<Guid> CreateAsync(string accessToken, CompanyAttribute attribute, CancellationToken ct = default)
        {
            return _httpClientFactory.PutJsonAsync<Guid>(
                UriBuilder.Combine(_url, "Create"), attribute, accessToken, ct);
        }

        public Task UpdateAsync(string accessToken, CompanyAttribute attribute, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), attribute, accessToken, ct);
        }

        public Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, accessToken, ct);
        }

        public Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, accessToken, ct);
        }
    }
}
