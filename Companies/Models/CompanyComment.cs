using System;

namespace Crm.v1.Clients.Companies.Models
{
    public class CompanyComment
    {
        public Guid Id { get; set; }

        public Guid CompanyId { get; set; }

        public Guid CommentatorUserId { get; set; }

        public string Value { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}