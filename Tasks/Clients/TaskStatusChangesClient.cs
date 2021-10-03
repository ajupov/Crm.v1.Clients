using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Tasks.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Tasks.Clients
{
    public class TaskStatusChangesClient : ITaskStatusChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public TaskStatusChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<TaskStatusChangeGetPagedListResponse> GetPagedListAsync(
            TaskStatusChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<TaskStatusChangeGetPagedListResponse>(
                _host + "/Tasks/Statuses/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
