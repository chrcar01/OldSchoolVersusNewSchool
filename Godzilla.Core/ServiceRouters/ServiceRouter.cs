namespace Godzilla.Core.ServiceRouters
{
    public abstract class ServiceRouter<TService>
    {
        protected virtual TService Use(TService service1, TService service2, string accountId)
        {
            return UseOldSystem(accountId) ? service1 : service2;
        }

        private bool UseOldSystem(string accountId)
        {
            return accountId == "1225405";
        }
    }
}