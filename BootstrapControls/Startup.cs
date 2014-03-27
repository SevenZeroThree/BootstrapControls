using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapControls.Startup))]
namespace BootstrapControls
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
