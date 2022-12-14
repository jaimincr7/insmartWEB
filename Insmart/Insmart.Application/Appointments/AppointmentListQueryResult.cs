namespace Insmart.Application.Appointments
{
    public class AppointmentListQueryResult : ListQueryResult
    {
        public IEnumerable<AppointmentDetailsQueryResult> Appointments { get; set; }
    }
}
