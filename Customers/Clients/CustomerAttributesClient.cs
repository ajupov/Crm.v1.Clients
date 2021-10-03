using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Customers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Customers.Clients
{
    public class CustomerAttributesClient : ICustomerAttributesClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public CustomerAttributesClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<CustomerAttribute> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<CustomerAttribute>(
                _host + "/Customers/Attributes/v1/Get", new { id }, headers, ct);
        }

        public Task<List<CustomerAttribute>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<CustomerAttribute>>(
                _host + "/Customers/Attributes/v1/GetList", null, ids, headers, ct);
        }

        public Task<CustomerAttributeGetPagedListResponse> GetPagedListAsync(
            CustomerAttributeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<CustomerAttributeGetPagedListResponse>(
                _host + "/Customers/Attributes/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            CustomerAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Customers/Attributes/v1/Create", null, attribute, headers, ct);
        }

        public Task UpdateAsync(
            CustomerAttribute attribute,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/Attributes/v1/Update", null, attribute, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/Attributes/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Customers/Attributes/v1/Restore", null, ids, headers, ct);
        }
    }
}
