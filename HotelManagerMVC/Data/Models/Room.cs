using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HotelManagerMVC.Data.Enums;

namespace HotelManagerMVC.Data.Models
{
    public class Room
    {
        public Room()
        {
            Reservations = new List<Reservation>();
            Id= new Guid().ToString();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public int Capacity { get; set; }
        public RoomType Type { get; set; }
        public bool IsTaken { get; set; }
        public double AdultPrice { get; set; }
        public double ChildrenPrice { get; set; }
        public int Number { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
