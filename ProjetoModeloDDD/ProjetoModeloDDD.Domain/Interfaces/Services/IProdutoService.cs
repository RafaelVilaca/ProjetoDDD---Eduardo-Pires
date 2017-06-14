using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        IEnumerable<Produto> GetAllByName(string nome);
        string Post(Produto produto);
        Produto GetById(int id);
        IEnumerable<Produto> GetAll();
        string Put(Produto produto);
        string Delete(Produto produto);
    }
}
