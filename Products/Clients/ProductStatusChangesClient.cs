using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.V1.Clients.Products.Requests;
using Crm.V1.Clients.Products.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.V1.Clients.Products.Clients
{
    public class ProductStatusChangesClient : IProductStatusChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductStatusChangesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Products/Statuses/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<ProductStatusChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductStatusChangeGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ProductStatusChangeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }
    }
}
