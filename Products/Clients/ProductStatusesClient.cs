﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http;
using Crm.V1.Clients.Products.Models;
using Crm.V1.Clients.Products.Requests;
using Crm.V1.Clients.Products.Responses;
using Microsoft.Extensions.Options;
using UriBuilder = Ajupov.Utils.All.Http.UriBuilder;

namespace Crm.V1.Clients.Products.Clients
{
    public class ProductStatusesClient : IProductStatusesClient
    {
        private readonly string _url;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductStatusesClient(IOptions<ClientsSettings> options, IHttpClientFactory httpClientFactory)
        {
            _url = UriBuilder.Combine(options.Value.ApiHost, "Products/Statuses/v1");
            _httpClientFactory = httpClientFactory;
        }

        public Task<ProductStatus> GetAsync(string accessToken, Guid id, CancellationToken ct = default)
        {
            return _httpClientFactory.GetAsync<ProductStatus>(
                UriBuilder.Combine(_url, "Get"), new {id}, accessToken, ct);
        }

        public Task<List<ProductStatus>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<List<ProductStatus>>(
                UriBuilder.Combine(_url, "GetList"), ids, accessToken, ct);
        }

        public Task<ProductStatusGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ProductStatusGetPagedListRequest request,
            CancellationToken ct = default)
        {
            return _httpClientFactory.PostJsonAsync<ProductStatusGetPagedListResponse>(
                UriBuilder.Combine(_url, "GetPagedList"), request, accessToken, ct);
        }

        public Task<Guid> CreateAsync(string accessToken, ProductStatus status, CancellationToken ct = default)
        {
            return _httpClientFactory.PutJsonAsync<Guid>(UriBuilder.Combine(_url, "Create"), status, accessToken, ct);
        }

        public Task UpdateAsync(string accessToken, ProductStatus status, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Update"), status, accessToken, ct);
        }

        public Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Delete"), ids, accessToken, ct);
        }

        public Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default)
        {
            return _httpClientFactory.PatchJsonAsync(UriBuilder.Combine(_url, "Restore"), ids, accessToken, ct);
        }
    }
}
