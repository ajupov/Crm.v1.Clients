using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Tasks.Models;
using Microsoft.Extensions.Options;
using Task = System.Threading.Tasks.Task;

namespace Crm.v1.Clients.Tasks.Clients
{
    public class TaskCommentsClient : ITaskCommentsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public TaskCommentsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<TaskCommentGetPagedListResponse> GetPagedListAsync(
            TaskCommentGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<TaskCommentGetPagedListResponse>(
                _host + "/Tasks/Comments/v1/GetPagedList", null, request, headers, ct);
        }

        public Task CreateAsync(
            TaskComment comment,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync(_host + "/Tasks/Comments/v1/Create", null, comment, headers, ct);
        }
    }
}
