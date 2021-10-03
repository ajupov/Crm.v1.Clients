using System;
using System.Collections.Generic;
using Crm.Common.All.Types.AttributeType;

namespace Crm.v1.Clients.Tasks.Models
{
    public class TaskAttributeGetPagedListRequest
    {
        public List<AttributeType> Types { get; set; }

        public string Key { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public DateTime? MinModifyDate { get; set; }

        public DateTime? MaxModifyDate { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}
