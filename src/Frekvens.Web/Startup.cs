using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Frekvens.Web.Startup))]

namespace Frekvens.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseLetsEncrypt("4fMwlcYNvVsTQ5b5bxL2DUx4SWM4b21QmYxvfO6c7EM", "4fMwlcYNvVsTQ5b5bxL2DUx4SWM4b21QmYxvfO6c7EM.52CEr9yUu-5FmKsp7VokFUHBBhsJxay5egIhVaYCrv4");
            app.UseLetsEncrypt("EL9feWrgVi4BczT9cT707HiJc_s0jp6xwH9XUejLN3Y", "EL9feWrgVi4BczT9cT707HiJc_s0jp6xwH9XUejLN3Y.52CEr9yUu-5FmKsp7VokFUHBBhsJxay5egIhVaYCrv4");
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
