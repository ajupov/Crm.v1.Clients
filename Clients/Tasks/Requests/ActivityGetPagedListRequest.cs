using System;
using System.Collections.Generic;
using Crm.v1.Clients.Clients.Tasks.Models;

namespace Crm.v1.Clients.Clients.Tasks.Requests
{
    public class ActivityGetPagedListRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Result { get; set; }

        public DateTime? MinStartDateTime { get; set; }

        public DateTime? MaxStartDateTime { get; set; }

        public DateTime? MinEndDateTime { get; set; }

        public DateTime? MaxEndDateTime { get; set; }

        public DateTime? MinDeadLineDateTime { get; set; }

        public DateTime? MaxDeadLineDateTime { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public DateTime? MinModifyDate { get; set; }

        public DateTime? MaxModifyDate { get; set; }

        public List<Guid> TypeIds { get; set; }

        public List<Guid> StatusIds { get; set; }

        public List<Guid> LeadIds { get; set; }

        public List<Guid> CompanyIds { get; set; }

        public List<Guid> ContactIds { get; set; }

        public List<Guid> DealIds { get; set; }

        public List<Guid> CreateUserIds { get; set; }

        public List<Guid> ResponsibleUserIds { get; set; }

        public List<ActivityPriority> Priorities { get; set; }

        public bool? AllAttributes { get; set; }

        public Dictionary<Guid, string> Attributes { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
