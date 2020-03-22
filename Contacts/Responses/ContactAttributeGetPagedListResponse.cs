using System;
using System.Collections.Generic;
using Crm.v1.Clients.Contacts.Models;

namespace Crm.v1.Clients.Contacts.Responses
{
    public class ContactAttributeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<ContactAttribute> Attributes { get; set; }
    }
}