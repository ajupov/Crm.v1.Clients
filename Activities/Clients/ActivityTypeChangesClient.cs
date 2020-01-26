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
    public class ActivityTypeChangesClient : IActivityTypeChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ActivityTypeChangesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Activities/Types/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<List<ActivityTypeChange>> GetPagedListAsync(
            string accessToken,
            ActivityTypeChangeGetPagedListRequestParameter request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<ActivityTypeChange>>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }
    }
}