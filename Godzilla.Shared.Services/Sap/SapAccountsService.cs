using GodZilla.Interfaces.Models.Accounts;
using GodZilla.Interfaces.Services;
using System.Threading.Tasks;

namespace Godzilla.Shared.Services.Sap
{
    public class SapAccountsService : IAccountsService
    {
        public Task<Account> GetAccountAsync(string accountId)
        {
            Account result = null;
            if (accountId == "1225095")
            {
                result = new Account { Id = accountId };
            }

            return Task.FromResult(result);
        }
    }
}
