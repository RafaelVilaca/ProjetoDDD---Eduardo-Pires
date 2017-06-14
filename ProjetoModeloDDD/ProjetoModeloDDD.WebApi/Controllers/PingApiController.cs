using System;
using System.Net;
using System.Web.Http;

namespace ProjetoModeloDDD.WebApi.Controllers
{
    public class PingApiController : ApiController
    {
        [Route("api/ping")]
        public IHttpActionResult Get()
        {
            return Content(HttpStatusCode.OK, $"Everything is fine! :) - {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
        }
    }
}
