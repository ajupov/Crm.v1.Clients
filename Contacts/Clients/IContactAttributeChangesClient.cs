﻿using System.Threading;
using System.Threading.Tasks;
using Crm.V1.Clients.Contacts.Requests;
using Crm.V1.Clients.Contacts.Responses;

namespace Crm.V1.Clients.Contacts.Clients
{
    public interface IContactAttributeChangesClient
    {
        Task<ContactAttributeChangeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ContactAttributeChangeGetPagedListRequest request,
            CancellationToken ct = default);
    }
}
