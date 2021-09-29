using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crm.v1.Clients.OAuth.Services
{
    public interface IDefaultRequestHeadersService
    {
        Task<Dictionary<string, string>> GetAsync();
    }

    public class DefaultRequestHeadersService : IDefaultRequestHeadersService
    {
        public Task<Dictionary<string, string>> GetAsync()
        {
            return Task.FromResult(new Dictionary<string, string>());
        }
    }
}
