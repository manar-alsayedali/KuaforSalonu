﻿namespace Kuafor_Salonu.Models
{
    public class Appointment
    {
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

    }
}
