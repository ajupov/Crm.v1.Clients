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
    public class ProductCategoryChangesClient : IProductCategoryChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductCategoryChangesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Products/Categories/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<ProductCategoryChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductCategoryChangeGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ProductCategoryChangeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }
    }
}
