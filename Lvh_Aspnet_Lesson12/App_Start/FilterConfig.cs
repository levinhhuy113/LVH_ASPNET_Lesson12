using System.Web;
using System.Web.Mvc;

namespace Lvh_Aspnet_Lesson12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
