using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week11ReviewSites.Startup))]
namespace Week11ReviewSites
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
