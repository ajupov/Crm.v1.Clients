using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Tasks.Requests;
using Crm.v1.Clients.Tasks.Responses;
using Microsoft.Extensions.Options;
using CrmTask = Crm.v1.Clients.Tasks.Models.Task;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Tasks.Clients
{
    public class TasksClient : ITasksClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public TasksClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Tasks/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<CrmTask> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<CrmTask>(UriBuilder.Combine(_url, "Get"), new { id }, headers, ct);
        }

        public Task<List<CrmTask>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<CrmTask>>(
                UriBuilder.Combine(_url, "GetList"), ids, headers, ct);
        }

        public Task<TaskGetPagedListResponse> GetPagedListAsync(
            TaskGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<TaskGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            CrmTask task,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), task, headers, ct);
        }

        public Task UpdateAsync(
            CrmTask task,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), task, headers, ct);
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
