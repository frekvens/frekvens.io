using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Frekvens.Web.Startup))]
namespace Frekvens.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
