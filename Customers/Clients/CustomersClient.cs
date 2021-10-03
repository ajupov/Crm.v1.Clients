using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Customers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Customers.Clients
{
    public class CustomersClient : ICustomersClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public CustomersClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<Customer> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<Customer>(_host + "/Customers/v1/Get", new { id }, headers, ct);
        }

        public Task<List<Customer>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<Customer>>(
                _host + "/Customers/v1/GetList", null, ids, headers, ct);
        }

        public Task<CustomerGetPagedListResponse> GetPagedListAsync(
            CustomerGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<CustomerGetPagedListResponse>(
                _host + "/Customers/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            Customer customer,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Customers/v1/Create", null, customer, headers, ct);
        }

        public Task UpdateAsync(
            Customer customer,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/v1/Update", null, customer, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/v1/Restore", null, ids, headers, ct);
        }
    }
}
