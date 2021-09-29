using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.v1.Clients.Clients.Customers.Models;
using Crm.v1.Clients.Clients.Customers.Requests;
using Crm.v1.Clients.Clients.Customers.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.v1.Clients.Clients.Customers.Clients
{
    public class CustomerCommentsClient : ICustomerCommentsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public CustomerCommentsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Customers/Comments/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<CustomerCommentGetPagedListResponse> GetPagedListAsync(
            CustomerCommentGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<CustomerCommentGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, headers, ct);
        }

        public Task CreateAsync(
            CustomerComment comment,
            Dictionary<string, string> headers,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync(UriBuilder.Combine(_url, "Create"), comment, headers, ct);
        }
    }
}
