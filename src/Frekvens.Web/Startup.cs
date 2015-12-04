using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Frekvens.Web.Startup))]

namespace Frekvens.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseLetsEncrypt("3Q57_PTOVKfxFZbl-LnYsji7PxYDqrCOu4WzM-jjZa4", "3Q57_PTOVKfxFZbl-LnYsji7PxYDqrCOu4WzM-jjZa4.52CEr9yUu-5FmKsp7VokFUHBBhsJxay5egIhVaYCrv4");
            app.UseLetsEncrypt("wICNXvIFrD5cAqHjaUQuqGnxkOl9OB4p73NeuwVg3Ek", "wICNXvIFrD5cAqHjaUQuqGnxkOl9OB4p73NeuwVg3Ek.52CEr9yUu-5FmKsp7VokFUHBBhsJxay5egIhVaYCrv4");
        }
    }

    public static class LetsEncryptExtensions
    {
        public static void UseLetsEncrypt(this IAppBuilder app, string path, string response)
        {
            app.Map("/.well-known/acme-challenge/" + path, letsencrypt =>
            {
                letsencrypt.Run(ctx =>
                {
                    ctx.Response.ContentType = "text/plain";
                    return ctx.Response.WriteAsync(response);
                });
            });
        }
    }
}
