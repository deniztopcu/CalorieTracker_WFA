using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concrete;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriTracker.DAL.SeedData
{
    public class SeedMeals : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasData
                (
                    new Meal { ID = 1, MealType = MealTypes.Kahvalti,},
                    new Meal { ID = 2, MealType = MealTypes.OgleYemegi,},
                    new Meal { ID = 3, MealType = MealTypes.AksamYemegi, },
                    new Meal { ID = 4, MealType = MealTypes.Diger,}
                );
        }
    }
}
