using Microsoft.EntityFrameworkCore;

namespace DagemovMVC.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Phone> Phones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pet>().HasIndex("Id", "UserId").IsUnique();
            modelBuilder.Entity<Phone>().HasIndex(c => c.PhoneNumber).IsUnique();
        }

    }
}
