using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Products.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Products.Clients
{
    public class ProductChangesClient : IProductChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public ProductChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<ProductChangeGetPagedListResponse> GetPagedListAsync(
            ProductChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<ProductChangeGetPagedListResponse>(
                _host + "/Products/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
