using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        void Post(Cliente cliente);
        Cliente GetById(int id);
        IEnumerable<Cliente> GetAll();
        IEnumerable<Cliente> GetAllByName(string nome);
        void Put(Cliente obj);
        void Delete(Cliente obj);
        IEnumerable<Cliente> SpecialClients();
    }
}
