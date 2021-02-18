using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clothastic.Startup))]
namespace Clothastic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
