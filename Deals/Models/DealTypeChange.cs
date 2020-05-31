﻿using System;

namespace Crm.V1.Clients.Deals.Models
{
    public class DealTypeChange
    {
        public Guid Id { get; set; }

        public Guid ChangerUserId { get; set; }

        public Guid TypeId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public string OldValueJson { get; set; }

        public string NewValueJson { get; set; }
    }
}
