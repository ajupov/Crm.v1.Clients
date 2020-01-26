using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Activities.Models;
using Crm.v1.Clients.Activities.RequestParameters;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Activities.Clients
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

        public Task<List<ActivityComment>> GetPagedListAsync(
            string accessToken,
            ActivityCommentGetPagedListRequestParameter request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<ActivityComment>>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task CreateAsync(string accessToken, ActivityComment comment, CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Create"), comment, accessToken, ct);
        }
    }
}