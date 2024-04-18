using Microsoft.EntityFrameworkCore;
using SewSew.Models;

namespace SewSew.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
    }
}
