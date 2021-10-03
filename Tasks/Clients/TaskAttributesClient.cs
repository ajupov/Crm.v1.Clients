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
    public class TaskAttributesClient : ITaskAttributesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public TaskAttributesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<TaskAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<TaskAttribute>(_host + "/Tasks/Attributes/v1/Get", new { id }, headers, ct);
        }

        public Task<List<TaskAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<TaskAttribute>>(
                _host + "/Tasks/Attributes/v1/GetList", null, ids, headers, ct);
        }

        public Task<TaskAttributeGetPagedListResponse> GetPagedListAsync(
            TaskAttributeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<TaskAttributeGetPagedListResponse>(
                _host + "/Tasks/Attributes/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            TaskAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(
                _host + "/Tasks/Attributes/v1/Create", null, attribute, headers, ct);
        }

        public Task UpdateAsync(
            TaskAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Attributes/v1/Update", null, attribute, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Attributes/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Tasks/Attributes/v1/Restore", null, ids, headers, ct);
        }
    }
}
