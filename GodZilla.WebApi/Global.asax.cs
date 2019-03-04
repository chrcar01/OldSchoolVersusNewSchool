using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using GodZilla.WebApi.Infrastructure;
using System.Web.Http;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Godzilla.Core.Repositories;
using Godzilla.Core.Services;
using Godzilla.Shared.Services.Sap;
using GodZilla.Interfaces.Repositories;
using GodZilla.Interfaces.Services;

namespace GodZilla.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private WindsorContainer _container;

        protected void Application_Start()
        {

            _container = new WindsorContainer();
            RegisterComponents(_container);
            _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel, true));
            var dependencyResolver = new WindsorDependencyResolver(_container);
            GlobalConfiguration.Configuration.DependencyResolver = dependencyResolver;
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_container.Kernel));
            _container.Kernel.AddHandlerSelector(new SelectDependencyServiceHandlerSelector());

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }

        private void RegisterComponents(WindsorContainer container)
        {
            container.Register(Classes.FromThisAssembly().BasedOn<ApiController>().LifestyleTransient());
            container.Register(
                Component
                    .For<IAccountsRepository>()
                    .ImplementedBy<AccountsRepository>()
                    .LifestyleTransient());

            container.Register(
                Component
                    .For<IAccountsService>()
                    .ImplementedBy<AccountsService>()
                    .Named("AccountsService")
                    .LifestyleTransient());

            container.Register(
                Component
                    .For<IAccountsService>()
                    .ImplementedBy<SapAccountsService>()
                    .Named("SapAccountsService")
                    .LifestyleTransient());

            
        }

        protected void Application_End()
        {
            _container?.Dispose();
        }
    }
}
