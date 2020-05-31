using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.Common.All.Types.AttributeType;
using Crm.V1.Clients.Contacts.Models;
using Crm.V1.Clients.Contacts.Requests;
using Crm.V1.Clients.Contacts.Responses;

namespace Crm.V1.Clients.Contacts.Clients
{
    public interface IContactAttributesClient
    {
        Task<Dictionary<string, AttributeType>> GetTypesAsync(string accessToken, CancellationToken ct = default);

        Task<ContactAttribute> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<ContactAttribute>> GetListAsync(
            string accessToken,
            IEnumerable<Guid> ids,
            CancellationToken ct = default);

        Task<ContactAttributeGetPagedListResponse> GetPagedListAsync(
            string accessToken,
            ContactAttributeGetPagedListRequest request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, ContactAttribute attribute, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, ContactAttribute attribute, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}
