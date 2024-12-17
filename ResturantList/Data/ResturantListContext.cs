using Microsoft.EntityFrameworkCore;
using ResturantList.Models;

namespace ResturantList.Data
{
    public class ResturantListContext : DbContext
    {
        public ResturantListContext(DbContextOptions<ResturantListContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ResturantDish>().HasKey(rd => new
            {
                rd.ResturantId,
                rd.DishId
            });

            modelBuilder.Entity<ResturantDish>()
                .HasOne(r => r.Resturant)
                .WithMany(rd => rd.ResturantDishes)
                .HasForeignKey(r => r.ResturantId);

            modelBuilder.Entity<ResturantDish>()
                .HasOne(d => d.Dish)
                .WithMany(r => r.ResturantDishes)
                .HasForeignKey(d => d.DishId);


            // Seed Data
            modelBuilder.Entity<Resturant>()
                .HasData(new Resturant
                {
                    Id = 1,
                    Name = "Gourment Pizzeria",
                    ImageURL = "https://www.whereyoueat.com/r_gallery_images/rgallery-21635/Best_Italian_Pizza2.jpg",
                    Address = "1234 Culinary St, Flavor, CA 90210"
                });

            modelBuilder.Entity<Dish>().HasData(
                    new Dish { Id = 1, Name = "Pizza", Price = 10 },
                    new Dish { Id = 2, Name = "Pasta", Price = 9 },
                    new Dish { Id = 3, Name = "Cheese Bread", Price = 5 }
                );

            modelBuilder.Entity<ResturantDish>().HasData(
                new ResturantDish { ResturantId = 1, DishId = 1},
                new ResturantDish { ResturantId = 1, DishId = 2 },
                new ResturantDish { ResturantId = 1, DishId = 3 }
                );


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<ResturantDish> ResturantsDishes { get; set; }

    }
}
