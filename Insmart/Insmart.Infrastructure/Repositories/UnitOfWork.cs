using Insmart.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Insmart.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        IServiceProvider _services;
        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _services = serviceProvider ?? throw new ArgumentException("Could not resolve IServiceProvider");
        }

        IAppointmentRepository _appointmentRepository;
        public IAppointmentRepository Appointments
        {
            get
            {
                if (_appointmentRepository == null)
                {
                    _appointmentRepository = _services.GetRequiredService<IAppointmentRepository>();
                }
                return _appointmentRepository;
            }
        }

        IAppointmentReviewRepository _appointmentReviewRepository;
        public IAppointmentReviewRepository AppointmentReviews
        {
            get
            {
                if (_appointmentReviewRepository == null)
                {
                    _appointmentReviewRepository = _services.GetRequiredService<IAppointmentReviewRepository>();
                }
                return _appointmentReviewRepository;
            }
        }

        ISpecialityRepository _specialityRepository;
        public ISpecialityRepository Specialities
        {
            get
            {
                if (_specialityRepository == null)
                {
                    _specialityRepository = _services.GetRequiredService<ISpecialityRepository>();
                }
                return _specialityRepository;
            }
        }

        IDoctorRepository _doctorRepository;
        public IDoctorRepository Doctors
        {
            get
            {
                if (_doctorRepository == null)
                {
                    _doctorRepository = _services.GetRequiredService<IDoctorRepository>();
                }
                return _doctorRepository;
            }
        }

        IHospitalRepository _hospitalRepository;
        public IHospitalRepository Hospitals
        {
            get
            {
                if (_hospitalRepository == null)
                {
                    _hospitalRepository = _services.GetRequiredService<IHospitalRepository>();
                }
                return _hospitalRepository;
            }
        }

        IBannerRepository _bannerRepository;
        public IBannerRepository Banners
        {
            get
            {
                if (_bannerRepository == null)
                {
                    _bannerRepository = _services.GetRequiredService<IBannerRepository>();
                }
                return _bannerRepository;
            }
        }

        ITestimonialRepository _testimonialRepository;
        public ITestimonialRepository Testimonials
        {
            get
            {
                if (_testimonialRepository == null)
                {
                    _testimonialRepository = _services.GetRequiredService<ITestimonialRepository>();
                }
                return _testimonialRepository;
            }
        }

        IPromotionalRepository _promotionalRepository;
        public IPromotionalRepository Promotionals
        {
            get
            {
                if (_promotionalRepository == null)
                {
                    _promotionalRepository = _services.GetRequiredService<IPromotionalRepository>();
                }
                return _promotionalRepository;
            }
        }

        IBlogRepository _blogRepository;
        public IBlogRepository Blogs
        {
            get
            {
                if (_blogRepository == null)
                {
                    _blogRepository = _services.GetRequiredService<IBlogRepository>();
                }
                return _blogRepository;
            }
        }

        ISymptomRepository _symptomRepository;
        public ISymptomRepository Symptoms
        {
            get
            {
                if (_symptomRepository == null)
                {
                    _symptomRepository = _services.GetRequiredService<ISymptomRepository>();
                }
                return _symptomRepository;
            }
        }

        IBlogCategoryRepository _blogCategoryRepository;
        public IBlogCategoryRepository BlogCategories
        {
            get
            {
                if (_blogCategoryRepository == null)
                {
                    _blogCategoryRepository = _services.GetRequiredService<IBlogCategoryRepository>();
                }
                return _blogCategoryRepository;
            }
        }

        ILanguageRepository _languageRepository;
        public ILanguageRepository Languages
        {
            get
            {
                if (_languageRepository == null)
                {
                    _languageRepository = _services.GetRequiredService<ILanguageRepository>();
                }
                return _languageRepository;
            }
        }

        IPromoCodeRepository _promoCodeRepository;
        public IPromoCodeRepository PromoCodes
        {
            get
            {
                if (_promoCodeRepository == null)
                {
                    _promoCodeRepository = _services.GetRequiredService<IPromoCodeRepository>();
                }
                return _promoCodeRepository;
            }
        }

        IUserRepository _userRepository;
        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = _services.GetRequiredService<IUserRepository>();
                }
                return _userRepository;
            }
        }

        IUserAddressRepository _userAddressRepository;
        public IUserAddressRepository UserAddresses
        {
            get
            {
                if (_userAddressRepository == null)
                {
                    _userAddressRepository = _services.GetRequiredService<IUserAddressRepository>();
                }
                return _userAddressRepository;
            }
        }

        IPatientRepository _patientRepository;
        public IPatientRepository Patients
        {
            get
            {
                if (_patientRepository == null)
                {
                    _patientRepository = _services.GetRequiredService<IPatientRepository>();
                }
                return _patientRepository;
            }
        }

        ICityRepository _cityRepository;
        public ICityRepository Cities
        {
            get
            {
                if (_cityRepository == null)
                {
                    _cityRepository = _services.GetRequiredService<ICityRepository>();
                }
                return _cityRepository;
            }
        }

        IUserOTPRepository _userOTPRepository;
        public IUserOTPRepository UserOTPs
        {
            get
            {
                if (_userOTPRepository == null)
                {
                    _userOTPRepository = _services.GetRequiredService<IUserOTPRepository>();
                }
                return _userOTPRepository;
            }
        }

        IRelationRepository _relationRepository;
        public IRelationRepository Relations
        {
            get
            {
                if (_relationRepository == null)
                {
                    _relationRepository = _services.GetRequiredService<IRelationRepository>();
                }
                return _relationRepository;
            }
        }
    }
}
