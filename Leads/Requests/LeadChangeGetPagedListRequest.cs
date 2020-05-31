using System;

namespace Crm.V1.Clients.Leads.Requests
{
    public class LeadChangeGetPagedListRequest
    {
        public Guid LeadId { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
