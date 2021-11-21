using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Stock.Models
{
    public class StockBalanceGetPagedListRequest
    {
        public decimal? MinCount { get; set; }

        public decimal? MaxCount { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public DateTime? MinModifyDate { get; set; }

        public DateTime? MaxModifyDate { get; set; }

        public List<Guid> CreateUserIds { get; set; }

        public List<Guid> RoomIds { get; set; }

        public List<Guid> ProductIds { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
