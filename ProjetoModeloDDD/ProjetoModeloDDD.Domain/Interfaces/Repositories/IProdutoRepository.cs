using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        void Post(Produto produto);
        Produto GetById(int id);
        IEnumerable<Produto> GetAll();
        void Put(Produto obj);
        void Delete(Produto obj);
        IEnumerable<Produto> GetAllByName(string nome);
    }
}
