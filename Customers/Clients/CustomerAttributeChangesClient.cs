using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Customers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Customers.Clients
{
    public class CustomerAttributeChangesClient : ICustomerAttributeChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public CustomerAttributeChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<CustomerAttributeChangeGetPagedListResponse> GetPagedListAsync(
            CustomerAttributeChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<CustomerAttributeChangeGetPagedListResponse>(
                _host + "/Customers/Attributes/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
