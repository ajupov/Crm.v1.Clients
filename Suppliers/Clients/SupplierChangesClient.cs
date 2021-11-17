using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Suppliers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Suppliers.Clients
{
    public class SupplierChangesClient : ISupplierChangesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public SupplierChangesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<SupplierChangeGetPagedListResponse> GetPagedListAsync(
            SupplierChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<SupplierChangeGetPagedListResponse>(
                _host + "/Suppliers/Changes/v1/GetPagedList", null, request, headers, ct);
        }
    }
}
