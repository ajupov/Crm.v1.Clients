using System;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierCommentGetPagedListRequest
    {
        public Guid SupplierId { get; set; }

        public DateTime? BeforeCreateDateTime { get; set; }

        public DateTime? AfterCreateDateTime { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
