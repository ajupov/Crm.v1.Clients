using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Tasks.Models;
using Microsoft.Extensions.Options;
using CrmTaskStatus = Crm.v1.Clients.Tasks.Models.TaskStatus;
using Task = System.Threading.Tasks.Task;

namespace Crm.v1.Clients.Tasks.Clients
{
    public class TaskStatusesClient : ITaskStatusesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public TaskStatusesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<CrmTaskStatus> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<CrmTaskStatus>(_host + "/Tasks/Statuses/v1/Get", new { id }, headers, ct);
        }

        public Task<List<CrmTaskStatus>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<CrmTaskStatus>>(
                _host + "/Tasks/Statuses/v1/GetList", null, ids, headers, ct);
        }

        public Task<TaskStatusGetPagedListResponse> GetPagedListAsync(
            TaskStatusGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<TaskStatusGetPagedListResponse>(
                _host + "/Tasks/Statuses/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            CrmTaskStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Tasks/Statuses/v1/Create", null, status, headers, ct);
        }

        public Task UpdateAsync(
            CrmTaskStatus status,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Statuses/v1/Update", null, status, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Statuses/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Statuses/v1/Restore", null, ids, headers, ct);
        }
    }
}
