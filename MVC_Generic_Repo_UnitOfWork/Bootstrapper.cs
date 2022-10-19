using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MVC_Generic_Repo_UnitOfWork.DataAccess;
using Unity.Mvc4;

namespace MVC_Generic_Repo_UnitOfWork
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
            container.RegisterType<IUnitOfWork, UnitOfWork>(new TransientLifetimeManager());
    }
  }
}