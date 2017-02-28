using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assigment.Web.Startup))]
namespace Assigment.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
