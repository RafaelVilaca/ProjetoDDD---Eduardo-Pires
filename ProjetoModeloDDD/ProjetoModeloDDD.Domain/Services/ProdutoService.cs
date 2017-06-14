using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> GetAllByName(string nome)
        {
            return _produtoRepository.GetAllByName(nome);
        }

        public string Post(Produto produto)
        {
            if (produto.IsValid() != 0)
                switch (produto.IsValid())
                {
                    case 1: return "Nome Inválido, Mínimo: 3 caracteres e Máximo: 100 caracteres";
                    case 2: return "Erro ao Buscar Cliente";
                }

            _produtoRepository.Post(produto);
            return string.Empty;
        }

        public Produto GetById(int id)
        {
            return _produtoRepository.GetById(id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public string Put(Produto produto)
        {
            if (produto.IsValid() != 0)
                switch (produto.IsValid())
                {
                    case 1: return "Nome Inválido, Mínimo: 3 caracteres e Máximo: 100 caracteres";
                    case 2: return "Erro ao Buscar Cliente";
                }

            _produtoRepository.Put(produto);
            return string.Empty;
        }

        public string Delete(Produto produto)
        {
            _produtoRepository.Delete(produto);
            return string.Empty;
        }
    }
}
