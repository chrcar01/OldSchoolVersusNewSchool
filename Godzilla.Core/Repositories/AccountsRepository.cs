using System.Collections.Generic;
using GodZilla.Interfaces.Models.Accounts;
using GodZilla.Interfaces.Repositories;
using System.Threading.Tasks;

namespace Godzilla.Core.Repositories
{
    public class AccountsRepository : IAccountsRepository
    {
        public Task<Account> GetAccountAsync(string accountId)
        {
            Account result = null;
            if (accountId == "1225405")
            {
                result = new Account { Id = accountId, Name="Old School" };
            }
            return Task.FromResult(result);
        }

        public Task<IEnumerable<Invoice>> GetAccountInvoicesAsync(string accountId)
        {
            var result = new List<Invoice>();
            result.Add(new Invoice {AccountId = accountId, Id = "123", Name = "Old School Invoice"});
            return Task.FromResult(result as IEnumerable<Invoice>) ;
        }
    }
}
