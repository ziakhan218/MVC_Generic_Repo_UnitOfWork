using System.Web;
using System.Web.Mvc;

namespace MVC_Generic_Repo_UnitOfWork
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
