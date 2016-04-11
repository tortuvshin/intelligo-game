using System.Web.Mvc;

namespace ASP.NET_MVC5_Bootstrap3_3_1_LESS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}