using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Products.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Products.Clients
{
    public class ProductStatusChangesClient : IProductStatusChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public ProductStatusChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<ProductStatusChangeGetPagedListResponse> GetPagedListAsync(
            ProductStatusChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<ProductStatusChangeGetPagedListResponse>(
                _host + "/Products/Statuses/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
