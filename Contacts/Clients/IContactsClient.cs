using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.Contacts.Models;
using Crm.v1.Clients.Contacts.RequestParameters;

namespace Crm.v1.Clients.Contacts.Clients
{
    public interface IContactsClient
    {
        Task<Contact> GetAsync(string accessToken, Guid id, CancellationToken ct = default);

        Task<List<Contact>> GetListAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task<List<Contact>> GetPagedListAsync(
            string accessToken,
            ContactGetPagedListRequestParameter request,
            CancellationToken ct = default);

        Task<Guid> CreateAsync(string accessToken, Contact contact, CancellationToken ct = default);

        Task UpdateAsync(string accessToken, Contact contact, CancellationToken ct = default);

        Task DeleteAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);

        Task RestoreAsync(string accessToken, IEnumerable<Guid> ids, CancellationToken ct = default);
    }
}