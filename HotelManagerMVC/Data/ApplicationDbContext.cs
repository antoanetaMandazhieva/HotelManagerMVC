using HotelManagerMVC.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelManagerMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
    }
}