using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Suppliers.Models
{
    public class SupplierGetPagedListRequest
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public DateTime? MinModifyDate { get; set; }

        public DateTime? MaxModifyDate { get; set; }

        public bool? AllAttributes { get; set; }

        public Dictionary<Guid, string> Attributes { get; set; }

        public List<Guid> SourceIds { get; set; }

        public List<Guid> CreateUserIds { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
