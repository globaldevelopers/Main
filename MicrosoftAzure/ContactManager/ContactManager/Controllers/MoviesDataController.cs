using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Http;

namespace ContactManager.Controllers
{
    
    public class MoviesDataController : ApiController
    {
        // GET api/<controller>
        [Route("api/MoviesData")]
        [HttpGet]
        public string Get()
        {
            return "Hello " + DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}