using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Suppliers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Suppliers.Clients
{
    public class SupplierCommentsClient : ISupplierCommentsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public SupplierCommentsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<SupplierCommentGetPagedListResponse> GetPagedListAsync(
            SupplierCommentGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<SupplierCommentGetPagedListResponse>(
                _host + "/Suppliers/Comments/v1/GetPagedList", null, request, headers, ct);
        }

        public Task CreateAsync(
            SupplierComment comment,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync(_host + "/Suppliers/Comments/v1/Create", null, comment, headers, ct);
        }
    }
}
