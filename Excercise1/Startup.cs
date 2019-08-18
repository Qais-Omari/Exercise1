using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Excercise1.Startup))]
namespace Excercise1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
