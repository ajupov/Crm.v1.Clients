using System;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockRoomChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid StockRoomId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
