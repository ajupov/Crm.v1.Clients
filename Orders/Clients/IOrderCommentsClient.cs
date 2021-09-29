﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Orders.Models;
using Crm.v1.Clients.Orders.Requests;
using Crm.v1.Clients.Orders.Responses;

namespace Crm.v1.Clients.Orders.Clients
{
    public interface IOrderCommentsClient
    {
        Task<OrderCommentGetPagedListResponse> GetPagedListAsync(
            OrderCommentGetPagedListRequest request,
            Dictionary<string, string> headers,
            CancellationToken ct = default);

        Task CreateAsync(OrderComment comment, Dictionary<string, string> headers, CancellationToken ct = default);
    }
}
