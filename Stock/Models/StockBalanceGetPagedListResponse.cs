using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockBalanceGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<StockBalance> Balances { get; set; }
    }
}
