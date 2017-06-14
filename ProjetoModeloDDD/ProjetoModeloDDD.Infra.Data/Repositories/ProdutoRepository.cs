using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Contexto;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        protected ProjetoModeloContext Db = new ProjetoModeloContext();

        public void Post(Produto produto)
        {
            Db.Set<Produto>().Add(produto);
            Db.SaveChanges();
        }

        public Produto GetById(int id)
        {
            return Db.Set<Produto>().Find(id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return Db.Set<Produto>().ToList();
        }

        public void Put(Produto obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Delete(Produto produto)
        {
            Db.Set<Produto>().Remove(produto);
            Db.SaveChanges();
        }

        public IEnumerable<Produto> GetAllByName(string nome)
        {
            return Db.Produtos.Where(p => p.Nome.Contains(nome));
        }
    }
}
