using System.Collections.Generic;
using System.Web.Http;

namespace WebAPI.Swagger.Controllers.v1
{
    /// <summary>
    /// Employee Controller
    /// </summary>
    public class EmployeeController : ApiController
    {
        // GET api/values
        /// <summary>
        /// Get All Values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "Employee 1", "Employee 2" };
        }

        // GET api/values/5
        /// <summary>
        /// Get All Values by Id
        /// </summary>
        /// <param name="id">Mandatory</param>
        /// <returns></returns>
        public string Get(int id)
        {
            return $"Employee {id.ToString()}";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// Delete Value by id
        /// </summary>
        /// <param name="id">Mandatory</param>
        public void Delete(int id)
        {
        }
    }
}
