using System.Data.Entity;

namespace WarehouseGoods.Models
{
    public class GoodDbContext
    {
        public partial class GoodDBContext : DbContext
        {
            public GoodDBContext()
            {
            }

            public GoodDBContext(DbContextOptions<GoodDBContext> options)
                : base(options)
            {
            }

            public virtual DbSet<Good> Food { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=.;Database=GoodDB;Integrated Security=true");
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Good>(entity =>
                {
                    entity.Property(e => e.Title).HasMaxLength(2500);
                });

                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }
}
