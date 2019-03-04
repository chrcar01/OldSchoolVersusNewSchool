using System.Collections.Generic;
using System.Threading.Tasks;
using GodZilla.Interfaces.Models.Accounts;
using GodZilla.Interfaces.Services;

namespace Godzilla.Core.ServiceRouters
{
    public class AccountServiceRouter : IAccountsService
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
            if (accountId == "1225405")
            {
                return await _service1.GetAccountAsync(accountId);
            }

            return await _service2.GetAccountAsync(accountId);
        }

        public Task<IEnumerable<Invoice>> GetAccountInvoicesAsync(string accountId)
        {
            if (accountId == "1225405")
            {
                return _service1.GetAccountInvoicesAsync(accountId);
            }
            return _service2.GetAccountInvoicesAsync(accountId);
        }
    }
}
