using System;

namespace Crm.V1.Clients.Companies.Requests
{
    public class CompanyCommentGetPagedListRequest
    {
        public Guid CompanyId { get; set; }

        public DateTime? AfterCreateDateTime { get; set; }

        public int Limit { get; set; } = 10;
    }
}
