using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Tasks.Requests;
using Crm.v1.Clients.Tasks.Responses;
using Microsoft.Extensions.Options;
using CrmTaskStatus = Crm.v1.Clients.Tasks.Models.TaskStatus;
using Task = System.Threading.Tasks.Task;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Tasks.Clients
{
    public class TaskStatusesClient : ITaskStatusesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public TaskStatusesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Tasks/Statuses/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<CrmTaskStatus> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<CrmTaskStatus>(
                UriBuilder.Combine(_url, "Get"), new { id }, headers, ct);
        }

        public Task<List<CrmTaskStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<CrmTaskStatus>>(
                UriBuilder.Combine(_url, "GetList"), ids, headers, ct);
        }

        public Task<TaskStatusGetPagedListResponse> GetPagedListAsync(
            TaskStatusGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<TaskStatusGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            CrmTaskStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), status, headers, ct);
        }

        public Task UpdateAsync(
            CrmTaskStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), status, headers, ct);
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
