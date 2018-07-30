using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WizTax.Startup))]
namespace WizTax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
