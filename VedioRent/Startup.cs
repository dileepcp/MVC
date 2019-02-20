using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VedioRent.Startup))]
namespace VedioRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
