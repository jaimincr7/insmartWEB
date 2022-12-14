namespace Insmart.Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IAppointmentRepository Appointments { get; }
        public IAppointmentReviewRepository AppointmentReviews { get; }
        public ISpecialityRepository Specialities { get; }
        public IDoctorRepository Doctors { get; }
        public IHospitalRepository Hospitals { get; }
        public IBannerRepository Banners { get; }
        public ITestimonialRepository Testimonials { get; }
        public IPromotionalRepository Promotionals { get; }
        public IBlogRepository Blogs { get; }
        public ISymptomRepository Symptoms { get; }
        public IBlogCategoryRepository BlogCategories { get; }
        public ILanguageRepository Languages { get; }
        public IPromoCodeRepository PromoCodes { get; }
        public IUserRepository Users { get; }
        public IUserAddressRepository UserAddresses { get; }
        public IPatientRepository Patients { get; }
        public ICityRepository Cities { get; }
        public IUserOTPRepository UserOTPs { get; }
        public IRelationRepository Relations { get; }
    }
}