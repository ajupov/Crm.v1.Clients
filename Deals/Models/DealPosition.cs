using System;

namespace Crm.v1.Clients.Deals.Models
{
    public class DealPosition
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductVendorCode { get; set; }

        public decimal Price { get; set; }

        public decimal Count { get; set; }
    }
}