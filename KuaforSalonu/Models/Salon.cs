namespace Kuafor_Salonu.Models
{
    public class Salon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } 
        public string PhoneNumber { get; set; }
        public string WorkingHours { get; set; }
        public List<Employee> Empolyees { get; set; }
        public List<Service> Services { get; set; }

    }
}
