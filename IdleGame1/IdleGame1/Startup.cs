using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdleGame1.Startup))]
namespace IdleGame1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
