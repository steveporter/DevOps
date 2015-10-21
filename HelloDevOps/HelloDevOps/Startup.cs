using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloDevOps.Startup))]
namespace HelloDevOps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
