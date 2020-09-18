using System.Collections.Generic;
using Crm.V1.Clients.Contacts.Models;

namespace Crm.V1.Clients.Contacts.Responses
{
    public class ContactCommentGetPagedListResponse
    {
        public bool HasCommentsBefore { get; set; }

        public List<ContactComment> Comments { get; set; }
    }
}
