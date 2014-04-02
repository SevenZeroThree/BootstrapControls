using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapControls.WebForms.Sample.Startup))]
namespace BootstrapControls.WebForms.Sample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
