﻿using System;

namespace Crm.V1.Clients.Activities.Models
{
    public class ActivityComment
    {
        public Guid Id { get; set; }

        public Guid ActivityId { get; set; }

        public Guid CommentatorUserId { get; set; }

        public string Value { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
