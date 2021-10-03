using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Tasks.Models;
using Microsoft.Extensions.Options;
using Task = System.Threading.Tasks.Task;

namespace Crm.v1.Clients.Tasks.Clients
{
    public class TaskTypesClient : ITaskTypesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public TaskTypesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<TaskType> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<TaskType>(_host + "/Tasks/Types/v1/Get", new { id }, headers, ct);
        }

        public Task<List<TaskType>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<TaskType>>(
                _host + "/Tasks/Types/v1/GetList", null, ids, headers, ct);
        }

        public Task<TaskTypeGetPagedListResponse> GetPagedListAsync(
            TaskTypeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<TaskTypeGetPagedListResponse>(
                _host + "/Tasks/Types/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            TaskType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Tasks/Types/v1/Create", null, type, headers, ct);
        }

        public Task UpdateAsync(
            TaskType type,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Types/v1/Update", null, type, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Types/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Types/v1/Restore", null, ids, headers, ct);
        }
    }
}
