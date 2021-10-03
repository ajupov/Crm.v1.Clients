using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Tasks.Models;
using Microsoft.Extensions.Options;
using CrmTask = Crm.v1.Clients.Tasks.Models.Task;
using Task = System.Threading.Tasks.Task;

namespace Crm.v1.Clients.Tasks.Clients
{
    public class TasksClient : ITasksClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public TasksClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<CrmTask> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<CrmTask>(_host + "/Tasks/v1/Get", new { id }, headers, ct);
        }

        public Task<List<CrmTask>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<CrmTask>>(_host + "/Tasks/v1/GetList", null, ids, headers, ct);
        }

        public Task<TaskGetPagedListResponse> GetPagedListAsync(
            TaskGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<TaskGetPagedListResponse>(
                _host + "/Tasks/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            CrmTask task,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Tasks/v1/Create", null, task, headers, ct);
        }

        public Task UpdateAsync(
            CrmTask task,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/v1/Update", null, task, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/v1/Restore", null, ids, headers, ct);
        }
    }
}
