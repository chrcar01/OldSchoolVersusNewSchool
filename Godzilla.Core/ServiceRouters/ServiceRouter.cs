namespace Godzilla.Core.ServiceRouters
{
    public abstract class ServiceRouter<TService>
    {
        private readonly TService _service1;
        private readonly TService _service2;

        protected ServiceRouter(TService service1, TService service2)
        {
            _service1 = service1;
            _service2 = service2;
        }

        protected virtual TService RouteByAccount(string accountId)
        {
            return UseFirstSystem(accountId) ? _service1 : _service2;
        }

        private bool UseFirstSystem(string accountId)
        {
            return accountId == "1225405";
        }
    }
}