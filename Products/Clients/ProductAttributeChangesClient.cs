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
    public class ProductAttributeChangesClient : IProductAttributeChangesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductAttributeChangesClient(
            IOptions<ClientsSettings> options,
            IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Products/Attributes/Changes/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<ProductAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ProductAttributeChangeGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }
    }
}
