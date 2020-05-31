using System.Collections.Generic;
using Crm.V1.Clients.Contacts.Models;

namespace Crm.V1.Clients.Contacts.Responses
{
    public class ContactAttributeChangeGetPagedListResponse
    {
        public int TotalCount { get; set; }

        public List<ContactAttributeChange> Changes { get; set; }
    }
}
