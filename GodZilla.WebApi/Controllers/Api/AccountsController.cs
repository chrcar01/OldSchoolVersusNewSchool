using System.Threading.Tasks;
using System.Web.Http;
using GodZilla.Interfaces.Services;

namespace GodZilla.WebApi.Controllers.Api
{
    public class AccountsController : ApiController
    {
        private readonly IAccountsService _service;

        public AccountsController(IAccountsService service)
        {
            _service = service;
        }
        [Route("api/accounts/{accountId}"), HttpGet]
        public async Task<IHttpActionResult> GetAccount(string accountId)
        {
            var result = await _service.GetAccountAsync(accountId);
            return result == null ? (IHttpActionResult) NotFound() : Ok(result);
        }

        [Route("api/accounts/{accountId}/invoices"), HttpGet]
        public async Task<IHttpActionResult> GetAccountInvoices(string accountId)
        {
            var result = await _service.GetAccountInvoicesAsync(accountId);
            return result == null ? (IHttpActionResult) NotFound() : Ok(result);
        }
    }
}
