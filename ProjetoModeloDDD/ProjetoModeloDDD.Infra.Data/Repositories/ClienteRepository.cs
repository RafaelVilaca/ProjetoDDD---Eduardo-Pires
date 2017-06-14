using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Contexto;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        protected ProjetoModeloContext Db = new ProjetoModeloContext();

        public void Post(Cliente cliente)
        {
            Db.Set<Cliente>().Add(cliente);
            Db.SaveChanges();
        }

        public Cliente GetById(int id)
        {
            return Db.Set<Cliente>().Find(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return Db.Set<Cliente>().ToList();
        }

        public IEnumerable<Cliente> GetAllByName(string nome)
        {
            return Db.Set<Cliente>().Where(x => x.Nome.Contains(nome)).ToList();
        }

        public void Put(Cliente cliente)
        {
            Db.Entry(cliente).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Delete(Cliente cliente)
        {
            Db.Set<Cliente>().Remove(cliente);
            Db.SaveChanges();
        }

        public IEnumerable<Cliente> SpecialClients()
        {
            return Db.Set<Cliente>().Where(x => (x.DataCadastro.Year - DateTime.Now.Year) >= 5).ToList();
        }
    }
}
