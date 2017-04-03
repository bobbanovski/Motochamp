using Microsoft.EntityFrameworkCore;
using WebApplicationBasic.Models;

namespace WebApplicationBasic.DAL
{
    public class MotoDbContext : DbContext
    {
        public MotoDbContext(DbContextOptions<MotoDbContext> options) : base(options){}

        public DbSet<Bike> Bikes{ get; set; }
        public DbSet<User> Users{ get; set; }

        public DbSet<Model> Models{ get; set; }
    }
}