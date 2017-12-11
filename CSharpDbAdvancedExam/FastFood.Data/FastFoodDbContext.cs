using FastFood.Models;
using Microsoft.EntityFrameworkCore;

namespace FastFood.Data
{
	public class FastFoodDbContext : DbContext
	{
		public FastFoodDbContext()
		{
		}

		public FastFoodDbContext(DbContextOptions options)
			: base(options)
		{
		}

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Position> Positions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			if (!builder.IsConfigured)
			{
				builder.UseSqlServer(Configuration.ConnectionString);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Position>()
                .HasAlternateKey(s => s.Name);

            modelBuilder.Entity<Item>()
                .HasAlternateKey(t => t.Name);

            modelBuilder.Entity<OrderItem>()
                .HasKey(bc => new { bc.ItemId, bc.OrderId });

            modelBuilder.Entity<OrderItem>()
                .HasOne(bc => bc.Order)
                .WithMany(b => b.OrderItems)
                .HasForeignKey(bc => bc.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(bc => bc.Item)
                .WithMany(c => c.OrderItems)
                .HasForeignKey(bc => bc.ItemId);
        }
    }
}