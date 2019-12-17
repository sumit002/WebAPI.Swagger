using System.Collections.Generic;
using System.Web.Http;

namespace WebAPISample.Controllers
{
    public class HomeController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "home1", "Home2" };
        }
    }
}
