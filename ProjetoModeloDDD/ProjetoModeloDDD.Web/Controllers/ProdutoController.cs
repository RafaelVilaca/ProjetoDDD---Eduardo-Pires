using System.Web.Mvc;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoApp;

        public ProdutoController(IProdutoAppService produtoApp)
        {
            _produtoApp = produtoApp;
        }

        // GET: Produto
        public ActionResult Index()
        {
            var produto = _produtoApp.GetAll();
            return View(produto);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoApp.GetById(id);
            return View(produto);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [ValidateAntiForgeryToken]
        public ActionResult CreateConfirmed(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoApp.Post(produto);

                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetById(id);
            return View(produto);
        }

        // POST: Clientes/Edit/5
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirmed(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _produtoApp.Put(produto);

                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetById(id);
            return View(produto);
        }

        // POST: Clientes/Delete/5
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Produto produto)
        {
            _produtoApp.Delete(produto);
            return RedirectToAction("Index");
        }
    }
}