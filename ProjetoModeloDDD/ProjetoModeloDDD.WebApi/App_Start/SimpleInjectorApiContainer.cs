using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Services;
using ProjetoModeloDDD.Infra.Data.Repositories;
using SimpleInjector;

namespace ProjetoModeloDDD.WebApi
{
    public static class SimpleInjectorApiContainer
    {
        public static Container RegisterContainer()
        {
            var container = new Container();

            container.Register<IClienteService, ClienteService>();
            container.Register<IClienteRepository, ClienteRepository>();

            container.Register<IProdutoService, ProdutoService>();
            container.Register<IProdutoRepository, ProdutoRepository>();

            container.Verify();
            return container;
        }
    }
}
