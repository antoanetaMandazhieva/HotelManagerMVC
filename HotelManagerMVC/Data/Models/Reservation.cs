using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelManagerMVC.Data.Models
{
    public class Reservation
    {
        public Reservation()
        {
            Id= Guid.NewGuid().ToString();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
       public int RoomId { get; set; }
        public List<Client> Clients { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Breakfast { get; set; }
        public bool AllInclusive { get; set; }
        public double Price { get; set; }

        public Room Room { get; set; }
    }
}
