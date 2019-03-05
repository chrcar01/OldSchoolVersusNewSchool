using System.Collections.Generic;
using System.Threading.Tasks;
using GodZilla.Interfaces.Models.Accounts;
using GodZilla.Interfaces.Services;

namespace Godzilla.Core.ServiceRouters
{
    public class AccountServiceRouter : ServiceRouter<IAccountsService>, IAccountsService
    {
        public AccountServiceRouter(IAccountsService service1, IAccountsService service2)
            : base(service1, service2)
        {
        }
        
        public async Task<Account> GetAccountAsync(string accountId)
        {
            return await RouteByAccount(accountId).GetAccountAsync(accountId);
        }

        public Task<IEnumerable<Invoice>> GetAccountInvoicesAsync(string accountId)
        {
            return RouteByAccount(accountId).GetAccountInvoicesAsync(accountId);
        }
    }
}
