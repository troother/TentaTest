using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTenta.Startup))]
namespace TestTenta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
