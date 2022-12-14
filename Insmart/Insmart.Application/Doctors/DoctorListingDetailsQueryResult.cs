namespace Insmart.Application.Doctors
{
    public class DoctorListingDetailsQueryResult 
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoPath { get; set; }
        public string Rating { get; set; }
        public string Specialities { get; set; }
        public string Languages { get; set; }
        public string Experiance { get; set; }
        public string City { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
