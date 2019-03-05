using GodZilla.Interfaces.Models.Accounts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GodZilla.Interfaces.Services
{
    public interface IAccountsService
    {
        Task<Account> GetAccountAsync(string accountId);
        Task<IEnumerable<Invoice>> GetAccountInvoicesAsync(string accountId);
    }
}
