using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevSuperDeployWithTests.Startup))]
namespace DevSuperDeployWithTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
