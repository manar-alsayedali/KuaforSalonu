namespace Kuafor_Salonu.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public bool IsAvailable { get; set; }
        public int SalonId { get; set; }
        public Salon Salon { get; set; }

    }
}
