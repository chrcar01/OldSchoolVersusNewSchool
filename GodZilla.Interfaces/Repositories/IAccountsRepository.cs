using System.Collections.Generic;
using System.Threading.Tasks;
using GodZilla.Interfaces.Models.Accounts;

namespace GodZilla.Interfaces.Repositories
{
    public interface IAccountsRepository
    {
        Task<Account> GetAccountAsync(string accountId);
        Task<IEnumerable<Invoice>> GetAccountInvoicesAsync(string accountId);
    }
}
