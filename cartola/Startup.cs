using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cartola.Startup))]
namespace cartola
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
