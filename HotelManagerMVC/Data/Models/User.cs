using Microsoft.AspNetCore.Identity;

namespace HotelManagerMVC.Data.Models
{
    public class User: IdentityUser
    {
        public User()
        {
            Reservations = new List<Reservation>();
        }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string PIN { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public bool? EmployeeDataIsActive { get; set; }
        public DateTime? ExemptionDate { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
