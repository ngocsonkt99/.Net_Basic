using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prjWebProject.Startup))]
namespace prjWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
