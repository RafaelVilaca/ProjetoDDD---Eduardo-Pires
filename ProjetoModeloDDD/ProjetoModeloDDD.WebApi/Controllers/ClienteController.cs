using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoModeloDDD.WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        private ProjetoModeloDDD db = new ProjetoModeloDDD();

        // GET: api/Cliente
        [Route("clientes")]
        public HttpResponseMessage Get()
        {
            var result = db.
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
