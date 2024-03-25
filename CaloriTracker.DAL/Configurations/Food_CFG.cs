using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriTracker.DAL.Configurations
{
    internal class Food_CFG : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {

            builder.HasKey(x => x.ID);
            builder.Property(x=>x.Name).HasColumnType("varchar(100)");
            builder.Property(x => x.Picture).HasColumnType("varchar(900)");

        }
    }
}
