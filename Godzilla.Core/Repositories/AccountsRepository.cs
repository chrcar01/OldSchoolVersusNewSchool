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
                result = new Account { Id = accountId };
            }
            return Task.FromResult(result);
        }
    }
}
