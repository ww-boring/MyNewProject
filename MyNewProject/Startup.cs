using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNewProject.Startup))]
namespace MyNewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
