using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rad302SummerWebAPIs00148820.Startup))]
namespace Rad302SummerWebAPIs00148820
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
