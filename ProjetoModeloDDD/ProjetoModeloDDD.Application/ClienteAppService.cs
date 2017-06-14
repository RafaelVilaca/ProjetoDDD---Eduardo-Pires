using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : IClienteAppService, IDisposable
    {
        private readonly HttpClient _httpClient;

        public ClienteAppService()
        {
            _httpClient = new HttpClient();
        }

        public HttpResponseMessage Post(Cliente cliente)
        {
            return _httpClient.PostAsync("http://localhost:63982/api/cliente/Post", cliente, JsonMediaTypeFormatter).Result;
        }
        
        public HttpResponseMessage GetById(int id)
        {
            return _httpClient.GetAsync("http://localhost:63982/api/cliente?id=" + id).Result;
        }

        public HttpResponseMessage GetAll()
        {
            return _httpClient.GetAsync("http://localhost:63982/api/clientes").Result;
        }

        public HttpResponseMessage GetAllByName(string nome)
        {
            return _httpClient.GetAsync("http://localhost:63982/api/clientes?like=%" + nome+"%").Result;
        }

        public HttpResponseMessage Put(Cliente cliente)
        {
            return _httpClient.PutAsync("http://localhost:63982/api/cliente/Put", cliente, JsonMediaTypeFormatter).Result;
        }

        public HttpResponseMessage Delete(Cliente cliente)
        {
            return _httpClient.DeleteAsync("http://localhost:63982/api/cliente/Delete").Result;
        }

        public HttpResponseMessage SpecialClients()
        {
            return _httpClient.GetAsync("http://localhost:63982/api/clientes/specialClients").Result;
        }

        void IClienteAppService.Dispose()
        {
            _httpClient.Dispose();
        }

        void IDisposable.Dispose()
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
