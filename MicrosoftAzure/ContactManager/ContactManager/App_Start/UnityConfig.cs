using System.Web.Http;
using System.Web.Mvc;
using ContactManager.DataAccess;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace ContactManager
{
    public static class UnityConfig
    {
        public static IUnityContainer Container { get; private set; }

        public static void RegisterComponents()
        {
			Container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            Container.RegisterType<IContactProvider, ContactProvider>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(Container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(Container);
        }
    }
}