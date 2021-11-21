using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockArrivalItem
    {
        public Guid Id { get; set; }

        public Guid StockArrivalId { get; set; }

        public Guid ProductId { get; set; }

        public decimal Count { get; set; }

        public List<Guid> UniqueElementIds { get; set; }
    }
}
