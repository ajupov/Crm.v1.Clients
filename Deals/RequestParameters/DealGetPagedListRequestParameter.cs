using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Deals.RequestParameters
{
    public class DealGetPagedListRequestParameter
    {
        public string Name { get; set; }

        public DateTime? MinStartDateTime { get; set; }

        public DateTime? MaxStartDateTime { get; set; }

        public DateTime? MinEndDateTime { get; set; }

        public DateTime? MaxEndDateTime { get; set; }

        public decimal? MinSum { get; set; }

        public decimal? MaxSum { get; set; }

        public decimal? MinSumWithoutDiscount { get; set; }

        public decimal? MaxSumWithoutDiscount { get; set; }

        public byte? MinFinishProbability { get; set; }

        public byte? MaxFinishProbability { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public DateTime? MinModifyDate { get; set; }

        public DateTime? MaxModifyDate { get; set; }

        public List<Guid> TypeIds { get; set; }

        public List<Guid> StatusIds { get; set; }

        public List<Guid> CompanyIds { get; set; }

        public List<Guid> ContactIds { get; set; }

        public List<Guid> CreateUserIds { get; set; }

        public List<Guid> ResponsibleUserIds { get; set; }

        public bool? AllAttributes { get; set; }

        public Dictionary<Guid, string> Attributes { get; set; }

        public List<Guid> PositionsProductIds { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}