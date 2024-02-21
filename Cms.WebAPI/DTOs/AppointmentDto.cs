namespace Cms.WebAPI.DTOs
{
    public class AppointmentDto
    {
        public string DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
       
        // Diğer gereken alanlar...
    }

}
