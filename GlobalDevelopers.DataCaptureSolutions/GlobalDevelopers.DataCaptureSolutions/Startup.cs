using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlobalDevelopers.DataCaptureSolutions.Startup))]
namespace GlobalDevelopers.DataCaptureSolutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
