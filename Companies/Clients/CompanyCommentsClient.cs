using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.V1.Clients.Companies.Models;
using Crm.V1.Clients.Companies.Requests;
using Crm.V1.Clients.Companies.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.V1.Clients.Companies.Clients
{
    public class CompanyCommentsClient : ICompanyCommentsClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public CompanyCommentsClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Companies/Comments/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<CompanyCommentGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            CompanyCommentGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<CompanyCommentGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task CreateAsync(string accessToken, CompanyComment comment, CancellationToken ct = default)
        {
            return _httpClientFactory.PutJsonAsync(UriBuilder.Combine(_url, "Create"), comment, accessToken, ct);
        }
    }
}
