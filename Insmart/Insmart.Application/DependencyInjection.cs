using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Insmart.Application.Banners.Handlers;

namespace Insmart.Application
{
    public static class DependencyInjection
    {
        public static void AddServiceDependencies(this IServiceCollection services)
        {
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddScoped<IRequestHandler<GetBannerListQuery, BannerListQueryResult>, GetBannerListQueryHandler>();
            services.AddMediatR(typeof(BannerListQueryHandler));
        } 
    }
}
