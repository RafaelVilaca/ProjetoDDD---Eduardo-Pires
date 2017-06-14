using System.Web.Http;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.WebApi.Controllers
{
    [RoutePrefix("api")]
    public class ProdutoApiController : ApiController
    {
        private readonly IProdutoService _produtoService;

        //public ProdutoApiController()
        //{
        //    _produtoService = new ProdutoService(new ProdutoRepository());
        //}

        public ProdutoApiController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET: api/Produto
        [HttpGet]
        [Route("produtos")]
        public IHttpActionResult GetAll()
        {
            var retornoLista = _produtoService.GetAll();
            if (retornoLista != null)
                return Ok(retornoLista);
            return BadRequest("Erro ao trazer Lista de Produtos");
        }

        [HttpGet]
        [Route("produto")]
        public IHttpActionResult GetById(int id)
        {
            var retornoLista = _produtoService.GetById(id);
            if (retornoLista != null)
                return Ok(retornoLista);
            return BadRequest("Erro ao trazer Produto");
        }

        [HttpGet]
        [Route("produtos")]
        public IHttpActionResult GetAllByName(string nome)
        {
            var retornoLista = _produtoService.GetAllByName(nome);
            if (retornoLista != null)
                return Ok(retornoLista);
            return BadRequest("Erro ao trazer Produtos");
        }

        [HttpPost]
        [Route("produto")]
        public IHttpActionResult Post(Produto produto)
        {
            var retorno = _produtoService.Post(produto);
            if (string.IsNullOrEmpty(retorno))
                return Ok();
            return BadRequest(retorno);
        }

        [HttpPut]
        [Route("produto")]
        public IHttpActionResult Put(Produto produto)
        {
            var retorno = _produtoService.Put(produto);
            if (string.IsNullOrEmpty(retorno))
                return Ok();
            return BadRequest(retorno);
        }
    }
}
