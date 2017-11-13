using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tradesta.Startup))]
namespace Tradesta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
