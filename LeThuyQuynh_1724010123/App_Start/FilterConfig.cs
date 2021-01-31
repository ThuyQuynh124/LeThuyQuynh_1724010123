using System.Web;
using System.Web.Mvc;

namespace LeThuyQuynh_1724010123
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
