using Insmart.Core.Configs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Insmart.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddJWTAutehntication(this IServiceCollection services)
        {
            var key = System.Text.Encoding.ASCII.GetBytes(AppSettings.Current.JWT.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = AppSettings.Current.JWT.Issuer,
                    ValidateAudience = true,
                    ValidAudience = AppSettings.Current.JWT.Audience,
                    ValidateLifetime = true,
                    //ClockSkew = TimeSpan.FromMinutes(0)
                };
                //x.Events = new JwtBearerEvents
                //{
                //    OnMessageReceived = context =>
                //    {
                //        // If the request is for our hub...
                //        var path = context.HttpContext.Request.Path;
                //        if (path.StartsWithSegments("/hubs/notifyHub"))
                //        {
                //            var accessToken = context.Request.Query["access_token"];
                //            if (!string.IsNullOrEmpty(accessToken))
                //                context.Request.Headers["Authorization"] = accessToken;
                //        }
                //        return Task.CompletedTask;
                //    }
                //};
            });

            //Set Policy



            //await using var provider = new ServiceCollection()
            //.AddScoped<Foo>()
            //.BuildServiceProvider();

            //using (var scope = provider.CreateScope())
            //{
            //    var foo = scope.ServiceProvider.GetRequiredService<Foo>();
            //} // Throws System.InvalidOperationException




            //services.AddTransient<IAdminPermissionService, AdminPermissionService>();

            //var sp = services.BuildServiceProvider();
            //var adminPermissionService = sp.GetService<IAdminPermissionService>();
            //var permissions = adminPermissionService.GetAdminPermissions().Result;

            //services.AddAuthorization(options =>
            //{
            //    if (permissions != null && permissions.Any())
            //    {
            //        foreach (var permission in permissions)
            //        {
            //            options.AddPolicy(permission.Name, policy => policy.RequireClaim(AppConstants.Claim_Permissions, permission.Name));
            //        }
            //    }
            //});
        }


    }
}
