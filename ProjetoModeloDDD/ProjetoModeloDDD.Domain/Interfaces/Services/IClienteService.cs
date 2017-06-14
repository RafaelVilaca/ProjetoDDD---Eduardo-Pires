using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IClienteService
    {
        string Post(Cliente cliente);
        Cliente GetById(int id);
        IEnumerable<Cliente> GetAll();
        string Put(Cliente cliente);
        string Delete(Cliente cliente);
        IEnumerable<Cliente> GetAllByName(string nome);
        IEnumerable<Cliente> SpecialClients();
    }
}
