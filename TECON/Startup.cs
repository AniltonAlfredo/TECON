using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TECON.Startup))]
namespace TECON
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
