using System.Web;
using System.Web.Mvc;

namespace CAPA_INSTRUCTOR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
