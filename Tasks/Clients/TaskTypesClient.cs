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
    public class TaskTypesClient : ITaskTypesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public TaskTypesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Tasks/Types/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<TaskType> GetAsync(Guid id, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<TaskType>(
                UriBuilder.Combine(_url, "Get"), new { id }, headers, ct);
        }

        public Task<List<TaskType>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<TaskType>>(
                UriBuilder.Combine(_url, "GetList"), ids, headers, ct);
        }

        public Task<TaskTypeGetPagedListResponse> GetPagedListAsync(
            TaskTypeGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<TaskTypeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            TaskType type,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), type, headers, ct);
        }

        public Task UpdateAsync(TaskType type, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), type, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, headers, ct);
        }
    }
}
