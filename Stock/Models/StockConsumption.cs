using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockConsumption
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid? CreateUserId { get; set; }

        public StockConsumptionType Type { get; set; }

        public Guid? SupplierId { get; set; }

        public Guid? OrderId { get; set; }

        public Guid? InventoryId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public List<StockConsumptionItem> Items { get; set; }
    }
}
