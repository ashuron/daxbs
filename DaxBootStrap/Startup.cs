using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DaxBootStrap.Startup))]
namespace DaxBootStrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
