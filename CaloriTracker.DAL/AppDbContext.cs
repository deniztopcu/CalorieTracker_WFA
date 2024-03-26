using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Concrete;
using CaloriTracker.DAL.Configurations;
using CaloriTracker.DAL.SeedData;


namespace CaloriTracker.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Food> Foods { get; set; }

        public DbSet<Meal> Meals { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserMealDetail> UserDetails { get; set; }

        public DbSet<UserMealDetail> UserMealDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source =MIHRAP-PC\\SQLEXPRESS; Initial catalog =CalorieTrackerDB90;Integrated security=true;TrustServerCertificate = true");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Category_CFG());    
            modelBuilder.ApplyConfiguration(new Food_CFG());    
            modelBuilder.ApplyConfiguration(new Meal_CFG());    
            modelBuilder.ApplyConfiguration(new UserDetail_CFG());    
            modelBuilder.ApplyConfiguration(new User_CFG());    
            modelBuilder.ApplyConfiguration(new UserMealDetail_CFG());

            modelBuilder.ApplyConfiguration(new SeedCategories());
            modelBuilder.ApplyConfiguration(new SeedFoods());
            modelBuilder.ApplyConfiguration(new SeedMeals());
        }

       

    }
}
