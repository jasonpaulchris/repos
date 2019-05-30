using System.Web.Http;
using Unity;
using Unity.WebApi;
using REST_API_2.Models;
using REST_API_2.Repositories;

namespace REST_API_2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType(typeof(AppDataEntities));
            container.RegisterType(typeof(IRepository<EmployeeInfo, int>), typeof(EmpRepository));
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}