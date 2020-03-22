using System.Collections.Generic;
using Crm.v1.Clients.Contacts.Models;

namespace Crm.v1.Clients.Contacts.Responses
{
    public class ContactChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ContactChange> Changes { get; set; }
    }
}