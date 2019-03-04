using GodZilla.Interfaces.Models.Accounts;
using GodZilla.Interfaces.Repositories;
using GodZilla.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Godzilla.Core.Services
{
    public class AccountsService : IAccountsService
    {
        private readonly IAccountsRepository _accountsRepository;

        public AccountsService(IAccountsRepository accountsRepository)
        {
            _accountsRepository = accountsRepository;
        }
        public Task<Account> GetAccountAsync(string accountId)
        {
            return _accountsRepository.GetAccountAsync(accountId);
        }

        public Task<IEnumerable<Invoice>> GetAccountInvoicesAsync(string accountId)
        {
            return _accountsRepository.GetAccountInvoicesAsync(accountId);
        }
    }
}
