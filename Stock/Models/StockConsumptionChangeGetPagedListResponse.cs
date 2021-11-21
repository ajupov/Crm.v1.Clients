using System.Collections.Generic;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockConsumptionChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<StockConsumptionChange> Changes { get; set; }
    }
}
