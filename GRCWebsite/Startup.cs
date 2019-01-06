using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GRCWebsite.Startup))]
namespace GRCWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
