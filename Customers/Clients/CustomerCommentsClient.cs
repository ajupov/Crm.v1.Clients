using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Customers.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Customers.Clients
{
    public class CustomerCommentsClient : ICustomerCommentsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public CustomerCommentsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<CustomerCommentGetPagedListResponse> GetPagedListAsync(
            CustomerCommentGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<CustomerCommentGetPagedListResponse>(
                _host + "/Customers/Comments/v1/GetPagedList", null, request, headers, ct);
        }

        public Task CreateAsync(
            CustomerComment comment,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync(_host + "/Customers/Comments/v1/Create", null, comment, headers, ct);
        }
    }
}
