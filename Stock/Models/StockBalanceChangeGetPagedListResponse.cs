using System.Collections.Generic;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockBalanceChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<StockBalanceChange> Changes { get; set; }
    }
}
