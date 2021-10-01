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
    public class TaskCommentsClient : ITaskCommentsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public TaskCommentsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Tasks/Comments/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<TaskCommentGetPagedListResponse> GetPagedListAsync(
            TaskCommentGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<TaskCommentGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task CreateAsync(
            TaskComment comment,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Create"), comment, headers, ct);
        }
    }
}
