using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Customers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Customers.Clients
{
    public class CustomerSourcesClient : ICustomerSourcesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public CustomerSourcesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<CustomerSource> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<CustomerSource>(_host + "/Customers/Sources/v1/Get", new { id }, headers, ct);
        }

        public Task<List<CustomerSource>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<CustomerSource>>(
                _host + "/Customers/Sources/v1/GetList", null, ids, headers, ct);
        }

        public Task<CustomerSourceGetPagedListResponse> GetPagedListAsync(
            CustomerSourceGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<CustomerSourceGetPagedListResponse>(
                _host + "/Customers/Sources/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            CustomerSource source,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Customers/Sources/v1/Create", null, source, headers, ct);
        }

        public Task UpdateAsync(
            CustomerSource source,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/Sources/v1/Update", null, source, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/Sources/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/Sources/v1/Restore", null, ids, headers, ct);
        }
    }
}
