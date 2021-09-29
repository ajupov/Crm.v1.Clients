using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.Tasks.Models;
using Crm.v1.Clients.Clients.Tasks.Requests;
using Crm.v1.Clients.Clients.Tasks.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Clients.Tasks.Clients
{
    public class ActivityCommentsClient : IActivityCommentsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ActivityCommentsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Activities/Comments/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<ActivityCommentGetPagedListResponse> GetPagedListAsync(

            ActivityCommentGetPagedListRequest request,
            Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ActivityCommentGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task CreateAsync(ActivityComment comment, Dictionary<string, string> headers, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Create"), comment, accessToken, ct);
        }
    }
}
