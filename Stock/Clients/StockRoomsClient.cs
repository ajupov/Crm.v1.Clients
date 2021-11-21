using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ajupov.Utils.All.Http.JsonHttpClient;
using Crm.v1.Clients.Stock.Models;
using Microsoft.Extensions.Options;

namespace Crm.v1.Clients.Stock.Clients
{
    public class StockRoomsClient : IStockRoomsClient
    {
        private readonly string _host;
        private readonly IJsonHttpClientFactory _factory;

        public StockRoomsClient(IOptions<ClientsOptions> options, IJsonHttpClientFactory factory)
        {
            _host = options.Value.Host;
            _factory = factory;
        }

        public Task<StockRoom> GetAsync(
            Guid id,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.GetAsync<StockRoom>(_host + "/Stock/Rooms/v1/Get", new { id }, headers, ct);
        }

        public Task<List<StockRoom>> GetListAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<List<StockRoom>>(
                _host + "/Stock/Rooms/v1/GetList", null, ids, headers, ct);
        }

        public Task<StockRoomGetPagedListResponse> GetPagedListAsync(
            StockRoomGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<StockRoomGetPagedListResponse>(
                _host + "/Stock/Rooms/v1/GetPagedList", null, request, headers, ct);
        }

        public Task<Guid> CreateAsync(
            StockRoom room,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PostAsync<Guid>(_host + "/Stock/Rooms/v1/Create", null, room, headers, ct);
        }

        public Task UpdateAsync(
            StockRoom room,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Rooms/v1/Update", null, room, headers, ct);
        }

        public Task DeleteAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Rooms/v1/Delete", null, ids, headers, ct);
        }

        public Task RestoreAsync(
            IEnumerable<Guid> ids,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default)
        {
            return _factory.PatchAsync(_host + "/Stock/Rooms/v1/Restore", null, ids, headers, ct);
        }
    }
}
