using System.Collections.Generic;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockRoomChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<StockRoomChange> Changes { get; set; }
    }
}
