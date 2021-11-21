using System.Collections.Generic;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockArrivalChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<StockArrivalChange> Changes { get; set; }
    }
}
