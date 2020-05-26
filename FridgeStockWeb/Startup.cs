using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FridgeStockWeb.Startup))]
namespace FridgeStockWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
