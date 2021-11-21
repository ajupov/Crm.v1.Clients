using System;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockItemUniqueElementChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid StockItemUniqueElementId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
