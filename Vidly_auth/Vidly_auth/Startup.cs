using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_auth.Startup))]
namespace Vidly_auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
