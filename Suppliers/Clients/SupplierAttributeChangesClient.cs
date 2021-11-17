using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Suppliers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Suppliers.Clients
{
    public class SupplierAttributeChangesClient : ISupplierAttributeChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public SupplierAttributeChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<SupplierAttributeChangeGetPagedListResponse> GetPagedListAsync(
            SupplierAttributeChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<SupplierAttributeChangeGetPagedListResponse>(
                _host + "/Suppliers/Attributes/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
