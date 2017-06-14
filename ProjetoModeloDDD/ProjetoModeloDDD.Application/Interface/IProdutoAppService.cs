
using System.Collections.Generic;
using System.Net.Http;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IProdutoAppService
    {
        HttpResponseMessage Post(Produto produto);

        HttpResponseMessage GetById(int id);

        HttpResponseMessage GetAll();

        HttpResponseMessage Put(Produto produto);

        HttpResponseMessage Delete(Produto produto);

        void Dispose();

        HttpResponseMessage GetAllByName(string nome);
    }
}
