
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using System.Net.Http;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IClienteAppService
    {
        HttpResponseMessage Post(Cliente cliente);

        HttpResponseMessage GetById(int id);

        HttpResponseMessage GetAll();

        HttpResponseMessage GetAllByName(string nome);

        HttpResponseMessage Put(Cliente cliente);

        HttpResponseMessage Delete(Cliente cliente);

        HttpResponseMessage SpecialClients();

        void Dispose();
    }
}
