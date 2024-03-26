using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriTracker.DAL.Configurations
{
    internal class UserMealDetail_CFG : IEntityTypeConfiguration<UserMealDetail>

    {
        public void Configure(EntityTypeBuilder<UserMealDetail> builder)
        {
            
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.User).WithMany(x => x.UserMealDetails).HasForeignKey(x => x.UserID);

            builder.HasOne(x => x.Meal).WithMany(x => x.UserMealDetails).HasForeignKey(x => x.MealID);

            builder.HasOne(x => x.Food).WithMany(x => x.UserMealDetails).HasForeignKey(x => x.FoodID);
        }
    }
}
