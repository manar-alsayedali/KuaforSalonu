namespace KuaforSalonu.Models
{
    public class Salon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WorkingHours { get; set; }
        public string Address { get; set; }


        public ICollection<Employee> Employees { get; set; }
        public ICollection<Service> Services { get; set; }

       


    }
}

