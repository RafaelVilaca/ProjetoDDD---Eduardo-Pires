using ProjetoModeloDDD.Application;
using ProjetoModeloDDD.Application.Interface;
using SimpleInjector;

namespace ProjetoModeloDDD.Web
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterContainer()
        {
            var container = new Container();

            container.Register<IClienteAppService, ClienteAppService>();
            //container.Register<IProdutoAppService, ProdutoAppService>();

            container.Verify();
            return container;
        }
    }
}