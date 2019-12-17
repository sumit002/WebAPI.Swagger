using System.Web.Mvc;

namespace WebAPI.Swagger
{
    /// <summary>
    /// Filter Config Class
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Register Global Filters
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
