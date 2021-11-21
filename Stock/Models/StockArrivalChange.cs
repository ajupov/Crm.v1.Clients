using System;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockArrivalChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid StockArrivalId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
