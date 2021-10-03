using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Customers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Customers.Clients
{
    public class CustomerChangesClient : ICustomerChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public CustomerChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<CustomerChangeGetPagedListResponse> GetPagedListAsync(
            CustomerChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<CustomerChangeGetPagedListResponse>(
                _host + "/Customers/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
