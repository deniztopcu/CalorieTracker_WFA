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
    public class UserDetail_CFG : IEntityTypeConfiguration<UserDetail>

    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.Name).HasColumnType("varchar(30)");    
            builder.Property(x=>x.Surname).HasColumnType("varchar(30)");
            builder.Property(x => x.Weight).HasColumnType("float");
        }
    }
}
