using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Orders.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Orders.Clients
{
    public class OrderCommentsClient : IOrderCommentsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public OrderCommentsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<OrderCommentGetPagedListResponse> GetPagedListAsync(
            OrderCommentGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<OrderCommentGetPagedListResponse>(
                _host + "/Orders/Comments/v1/GetPagedList", null, request, headers, ct);
        }

        public Task CreateAsync(
            OrderComment comment,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync(_host + "/Orders/Comments/v1/Create", null, comment, headers, ct);
        }
    }
}
