using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPNCalculator.Startup))]
namespace RPNCalculator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
