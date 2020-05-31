using System;
using System.Collections.Generic;
using Crm.V1.Clients.Contacts.Models;

namespace Crm.V1.Clients.Contacts.Responses
{
    public class ContactGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public DateTime? LastModifyDateTime { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
