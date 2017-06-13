using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JoyTea.Startup))]
namespace JoyTea
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
