using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shuffleboard.Startup))]
namespace Shuffleboard
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
