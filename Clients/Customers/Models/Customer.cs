using System;
using System.Collections.Generic;

namespace Crm.v1.Clients.Clients.Customers.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Guid? SourceId { get; set; }

        public Guid? CreateUserId { get; set; }

        public Guid? ResponsibleUserId { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Image { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime? ModifyDateTime { get; set; }

        public CustomerSource Source { get; set; }

        public List<CustomerAttributeLink> AttributeLinks { get; set; }
    }
}
