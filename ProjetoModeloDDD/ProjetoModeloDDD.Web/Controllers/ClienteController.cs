using ProjetoModeloDDD.Application.Interface;
using System.Web.Mvc;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteApp;

        public ClienteController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            //return WebApiConfiguration.WebApiConfiguration.Get(uri, controller, parametros);
            //var response = (HttpWebResponse)_request.GetResponse();
            //Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetAll());
            var clienteViewModel = _clienteApp.GetAll();
            return View(clienteViewModel);
        }

        public ActionResult Especiais()
        {
            var clienteViewModel = _clienteApp.SpecialClients();//Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.GetById(id);
            //var clienteViewModel = ;//Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(cliente);//clienteViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [ValidateAntiForgeryToken]
        public ActionResult CreateConfirmed(Cliente cliente)//ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteApp.Post(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.GetById(id);
            //var clienteViewModel = ;//Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(Cliente cliente)//ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                //var clienteDomain = ;//Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteApp.Put(cliente);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.GetById(id);
            //var clienteViewModel = ;//Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Cliente cliente)
        {
            _clienteApp.Delete(cliente);

            return RedirectToAction("Index");
        }
    }
}
