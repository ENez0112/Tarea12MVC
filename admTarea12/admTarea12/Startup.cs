using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admTarea12.Startup))]
namespace admTarea12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
