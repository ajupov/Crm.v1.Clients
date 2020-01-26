using System;

namespace Crm.v1.Clients.Contacts.RequestParameters
{
    public class ContactChangeGetPagedListRequestParameter
    {
        public Guid ContactId { get; set; }

        public Guid? ChangerUserId { get; set; }

        public DateTime? MinCreateDate { get; set; }

        public DateTime? MaxCreateDate { get; set; }

        public int Offset { get; set; }

        public int Limit { get; set; } = 10;

        public string SortBy { get; set; } = "CreateDateTime";

        public string OrderBy { get; set; } = "desc";
    }
}