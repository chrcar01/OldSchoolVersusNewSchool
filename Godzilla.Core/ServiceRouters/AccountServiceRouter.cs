using System.Collections.Generic;
using System.Threading.Tasks;
using GodZilla.Interfaces.Models.Accounts;
using GodZilla.Interfaces.Services;

namespace Godzilla.Core.ServiceRouters
{
    public class AccountServiceRouter : ServiceRouter<IAccountsService>, IAccountsService
    {
        private readonly IAccountsService _service1;
        private readonly IAccountsService _service2;
        
        public AccountServiceRouter(IAccountsService service1, IAccountsService service2)
        {
            _service1 = service1;
            _service2 = service2;
        }
        
        public async Task<Account> GetAccountAsync(string accountId)
        {
            return await Use(_service1, _service2, accountId).GetAccountAsync(accountId);
        }

        public Task<IEnumerable<Invoice>> GetAccountInvoicesAsync(string accountId)
        {
            return Use(_service1, _service2, accountId).GetAccountInvoicesAsync(accountId);
        }
    }
}
