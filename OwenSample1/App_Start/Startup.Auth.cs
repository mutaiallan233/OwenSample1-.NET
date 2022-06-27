using Microsoft.Owin.Security.OAuth;
using OwenSample1.provider;
using Owin;

namespace OwenSample1.App_Start
{
    public class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        static Startup()
        {
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = new OAuthAppProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(2),
                AllowInsecureHttp = true,
            };
        }

        public void ConfigurationAuth(IAppBuilder app)
        {
            app.UseOAuthBearerTokens();
        }
    }
}
