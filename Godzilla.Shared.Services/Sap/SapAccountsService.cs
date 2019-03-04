using System.Collections.Generic;
using GodZilla.Interfaces.Models.Accounts;
using GodZilla.Interfaces.Services;
using System.Threading.Tasks;

namespace Godzilla.Shared.Services.Sap
{
    public class SapAccountsService : IAccountsService
    {
        private readonly IAccountsService _oldAccountsService;
        
        public SapAccountsService(IAccountsService oldAccountsService)
        {
            _oldAccountsService = oldAccountsService;
        }

        public Task<Account> GetAccountAsync(string accountId)
        {
            Account result = null;
            if (accountId == "1225095")
            {
                result = new Account { Id = accountId, Name = "New School" };
            }

            return Task.FromResult(result);
        }

        public Task<IEnumerable<Invoice>> GetAccountInvoicesAsync(string accountId)
        {
            //return _oldAccountsService.GetAccountInvoicesAsync(accountId);
            var result = new List<Invoice>();
            result.Add(new Invoice { AccountId = accountId, Id = "666", Name = "New School" });
            return Task.FromResult((IEnumerable<Invoice>)result);
        }
    }
}
