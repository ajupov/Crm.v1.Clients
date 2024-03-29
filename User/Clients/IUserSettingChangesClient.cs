﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Crm.v1.Clients.User.Models;

namespace Crm.v1.Clients.User.Clients
{
    public interface IUserSettingChangesClient
    {
        public Task<UserSettingChangeGetPagedListResponse> GetPagedListAsync(
            UserSettingChangeGetPagedListRequest request,
            Dictionary<string, string> headers = default,
            CancellationToken ct = default);
    }
}
