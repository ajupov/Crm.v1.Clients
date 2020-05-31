using System;

namespace Crm.V1.Clients.Companies.Models
{
    public class CompanyChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid CompanyId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
