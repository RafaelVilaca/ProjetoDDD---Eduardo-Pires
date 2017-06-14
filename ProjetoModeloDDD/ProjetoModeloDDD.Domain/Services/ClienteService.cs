using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public string Post(Cliente cliente)
        {
            if (cliente.IsValid() != 0)
                switch (cliente.IsValid())
                {
                    case 1: return "Email inválido, corrija por favor!";
                    case 2: return "Sobrenome Inválido, Mínimo: 3 caracteres e Máximo: 100 caracteres";
                    case 3: return "Nome Inválido, Mínimo: 3 caracteres e Máximo: 100 caracteres";
                }

            _clienteRepository.Post(cliente);
            return string.Empty;
        }

        public string Delete(Cliente cliente)
        {
            _clienteRepository.Delete(cliente);
            return string.Empty;
        }

        public IEnumerable<Cliente> GetAllByName(string nome)
        {
            return _clienteRepository.GetAllByName(nome);
        }

        public IEnumerable<Cliente> SpecialClients()
        {
            return _clienteRepository.SpecialClients();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }
        
        public string Put(Cliente cliente)
        {
            if (cliente.IsValid() != 0)
                switch (cliente.IsValid())
                {
                    case 1: return "Email inválido, corrija por favor!";
                    case 2: return "Sobrenome Inválido, Mínimo: 3 caracteres e Máximo: 100 caracteres";
                    case 3: return "Nome Inválido, Mínimo: 3 caracteres e Máximo: 100 caracteres";
                }

            _clienteRepository.Put(cliente);
            return string.Empty;
        }
    }
}
