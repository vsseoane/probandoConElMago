using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportShop.Web.Api.Controllers
{
    public class MagoController : ApiController
    {
        // GET: api/Mago
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Mago/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mago
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mago/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mago/5
        public void Delete(int id)
        {
        }
    }
}
