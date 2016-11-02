using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarckPro.Startup))]
namespace MarckPro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
