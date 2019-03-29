using System.Web;
using System.Web.Mvc;

namespace Rad302SummerWebAPIs00148820
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
