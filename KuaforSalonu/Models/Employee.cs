namespace KuaforSalonu.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public int SalonId {  get; set; }

        public Salon Salon { get; set; }
    }
}
