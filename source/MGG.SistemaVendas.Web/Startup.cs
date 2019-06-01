using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MGG.SistemaVendas.Web.Startup))]
namespace MGG.SistemaVendas.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
