using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapControls.Samples.Startup))]
namespace BootstrapControls.Samples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
