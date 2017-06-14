using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly HttpClient _httpClient;

        public ProdutoAppService()
        {
            _httpClient = new HttpClient();
        }

        public HttpResponseMessage GetAllByName(string nome)
        {
            return _httpClient.GetAsync("http://localhost:63982/api/produtos?like=%" + nome + "%").Result;
        }

        public HttpResponseMessage Post(Produto produto)
        {
            return _httpClient.PostAsync("http://localhost:63982/api/produto/Post", produto, JsonMediaTypeFormatter).Result;
        }

        public HttpResponseMessage GetById(int id)
        {
            return _httpClient.GetAsync("http://localhost:63982/api/produto?id=" + id).Result;
        }

        public HttpResponseMessage GetAll()
        {
            return _httpClient.GetAsync("http://localhost:63982/api/produtos").Result;
        }

        public HttpResponseMessage Put(Produto produto)
        {
            return _httpClient.PutAsync("http://localhost:63982/api/produto/Put", produto, JsonMediaTypeFormatter).Result;
        }

        public HttpResponseMessage Delete(Produto produto)
        {
            return _httpClient.DeleteAsync("http://localhost:63982/api/produto/Delete").Result;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

        private static readonly JsonMediaTypeFormatter JsonMediaTypeFormatter = new JsonMediaTypeFormatter
        {
            SerializerSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Include
            }
        };
    }
}
