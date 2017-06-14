using System.Web.Http;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class ClienteApiController : ApiController
    {
        private readonly IClienteService _clienteService;

        //public ClienteApiController()
        //{
        //    _clienteService = new ClienteService(new ClienteRepository());
        //}

        public ClienteApiController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [Route("clientes")]
        public IHttpActionResult GetAll()
        {
            var retornoLista = _clienteService.GetAll();
            if (retornoLista != null)
                return Ok(retornoLista);
            return BadRequest("Erro ao trazer Lista de Clientes");
        }

        [HttpGet]
        [Route("clientes/specialClients")]
        public IHttpActionResult SpecialClients()
        {
            var retornoLista = _clienteService.SpecialClients();
            if (retornoLista != null)
                return Ok(retornoLista);
            return BadRequest("Erro ao trazer Lista de Clientes Especiais");
        }

        [HttpGet]
        [Route("cliente")]
        public IHttpActionResult GetById(int id)
        {
            var retornoLista = _clienteService.GetById(id);
            if (retornoLista != null)
                return Ok(retornoLista);
            return BadRequest("Erro ao trazer Cliente");
        }

        [HttpGet]
        [Route("cliente")]
        public IHttpActionResult GetAllByName(string nome)
        {
            var retornoLista = _clienteService.GetAllByName(nome);
            if (retornoLista != null)
                return Ok(retornoLista);
            return BadRequest("Erro ao trazer Cliente");
        }

        [HttpPost]
        [Route("cliente")]
        public IHttpActionResult Post(Cliente cliente)
        {
            var retorno = _clienteService.Post(cliente);
            if (string.IsNullOrEmpty(retorno))
                return Ok();
            return BadRequest(retorno);
        }

        [HttpPut]
        [Route("cliente")]
        public IHttpActionResult Put(Cliente cliente)
        {
            var retorno = _clienteService.Put(cliente);
            if(string.IsNullOrEmpty(retorno))
                return Ok();
            return BadRequest(retorno);
        }
    }
}
