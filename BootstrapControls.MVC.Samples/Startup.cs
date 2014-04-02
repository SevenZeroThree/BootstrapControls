using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapControls.MVC.Samples.Startup))]
namespace BootstrapControls.MVC.Samples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
