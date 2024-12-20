namespace KuaforSalonu.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public int ServiceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public User User { get; set; }
        public Service Service { get; set; }
        public Employee Employee { get; set; }

    }
}
