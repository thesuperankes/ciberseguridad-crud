using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(juanchoWeb.Startup))]
namespace juanchoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
