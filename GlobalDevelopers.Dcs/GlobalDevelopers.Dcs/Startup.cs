using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlobalDevelopers.Dcs.Startup))]
namespace GlobalDevelopers.Dcs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
