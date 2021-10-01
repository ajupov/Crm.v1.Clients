using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Tasks.Models;
using Crm.v1.Clients.Tasks.Requests;
using Crm.v1.Clients.Tasks.Responses;
using Microsoft.Extensions.Options;
using Task = System.Threading.Tasks.Task;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Tasks.Clients
{
    public class TaskAttributesClient : ITaskAttributesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public TaskAttributesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Tasks/Attributes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<TaskAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<TaskAttribute>(
                UriBuilder.Combine(_url, "Get"), new { id }, headers, ct);
        }

        public Task<List<TaskAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<TaskAttribute>>(
                UriBuilder.Combine(_url, "GetList"), ids, headers, ct);
        }

        public Task<TaskAttributeGetPagedListResponse> GetPagedListAsync(
            TaskAttributeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<TaskAttributeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            TaskAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(
                UriBuilder.Combine(_url, "Create"), attribute, headers, ct);
        }

        public Task UpdateAsync(
            TaskAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), attribute, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, headers, ct);
        }
    }
}
