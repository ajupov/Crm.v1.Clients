using System;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockConsumptionItem
    {
        public Guid Id { get; set; }

        public Guid StockConsumptionId { get; set; }

        public Guid RoomId { get; set; }

        public Guid ProductId { get; set; }

        public decimal Count { get; set; }

        // public List<Guid> UniqueElementIds { get; set; }
        public StockRoom Room { get; set; }
    }
}
