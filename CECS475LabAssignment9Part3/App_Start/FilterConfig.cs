using System.Web;
using System.Web.Mvc;

namespace CECS475LabAssignment9Part3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
