using Castle.MicroKernel;
using GodZilla.Interfaces.Services;
using System;
using System.Linq;

namespace GodZilla.WebApi.Infrastructure
{
    public class SelectDependencyServiceHandlerSelector : IHandlerSelector
    {
        public bool HasOpinionAbout(string key, Type service)
        {
            return service == typeof(IAccountsService);
        }

        public IHandler SelectHandler(string key, Type service, IHandler[] handlers)
        {
            //find the account id passed into here....
            IHandler component;
            var accountId = ""; // where can we get this from??
            if (accountId == "1225095")
            {
                //new school
                component = handlers.FirstOrDefault(s => s.ComponentModel.Name.Equals("SapAccountsService"));
            }
            else
            {
                //old school
                component = handlers.FirstOrDefault(s => s.ComponentModel.Name.Equals("AccountsService"));
            }

            return component;
        }
    }
}