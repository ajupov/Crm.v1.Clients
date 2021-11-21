using System;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockItemUniqueElement
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid? CreateUserId { get; set; }

        public Guid ProductId { get; set; }

        public StockItemUniqueElementStatus Status { get; set; }

        public string Value { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }
    }
}
