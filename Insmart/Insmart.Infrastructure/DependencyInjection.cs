using Microsoft.Extensions.DependencyInjection;
using Insmart.Application.Interfaces;
using Insmart.Infrastructure.Repositories;
using AutoMapper;
using Insmart.Application.Tasks.MappingProfiles;
using Insmart.Application.Interfaces.Services;
using Insmart.Infrastructure.Services;
using Insmart.Application.Features.Auth.MappingProfiles;
using Insmart.Application.Users.MappingProfiles;

namespace Insmart.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IHospitalRepository, HospitalRepository>();
            services.AddScoped<ISpecialityRepository, SpecialityRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<IPromotionalRepository, PromotionalRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ISymptomRepository, SymptomRepository>();
            services.AddScoped<IBlogCategoryRepository, BlogCategoryRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<IPromoCodeRepository, PromoCodeRepository>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IPasswordHashService, PasswordHashService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserAddressRepository, UserAddressRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IUserOTPRepository, UerOTPRepository>();
            services.AddScoped<IRelationRepository, RelationRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new BannerMappingProfile());
                mc.AddProfile(new DoctorMappingProfile());
                mc.AddProfile(new HospitalMappingProfile());
                mc.AddProfile(new SpecialityMappingProfile());
                mc.AddProfile(new TestimonialMappingProfile());
                mc.AddProfile(new PromotionalMappingProfile());
                mc.AddProfile(new BlogMappingProfile());
                mc.AddProfile(new BlogCategoryMappingProfile());
                mc.AddProfile(new SymptomMappingProfile());
                mc.AddProfile(new LanguageMappingProfile());
                mc.AddProfile(new PromoCodeMappingProfile());
                mc.AddProfile(new AuthMappingProfile());
                mc.AddProfile(new UserMappingProfile());
                mc.AddProfile(new AppointmentMappingProfile());
                mc.AddProfile(new PatientMappingProfile());
                mc.AddProfile(new CityMappingProfile());
                mc.AddProfile(new RelationMappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
