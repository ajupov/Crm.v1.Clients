using System;

namespace Crm.v1.Clients.Clients.Customers.Requests
{
    public class CustomerChangeGetPagedListRequest
    {
        public Guid CustomerId { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
