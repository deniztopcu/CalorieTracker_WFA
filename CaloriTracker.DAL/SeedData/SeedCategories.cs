using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriTracker.DAL.SeedData
{
    public class SeedCategories : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData
               (
                    new Category { ID = 1, CategoryName = "Alkollü İçecekler" },
                    new Category { ID = 2, CategoryName = "Alkolsüz İçecekler" },
                    new Category { ID = 3, CategoryName = "Cerezler" },
                    new Category { ID = 4, CategoryName = "Baklagiller" },
                    new Category { ID = 5, CategoryName = "Sebzeler" },
                    new Category { ID = 6, CategoryName = "Çorbalar" },
                    new Category { ID = 7, CategoryName = "Deniz Ürünleri" },
                    new Category { ID = 8, CategoryName = "Tatlılar" },
                    new Category { ID = 9, CategoryName = "Fast Food" },
                    new Category { ID = 10, CategoryName = "Et ve Et Ürünleri" },
                    new Category { ID = 11, CategoryName = "Meyveler" },
                    new Category { ID = 12, CategoryName = "Ana Yemekler" },
                    new Category { ID = 13, CategoryName = "Ekmek ve Unlu Mamuller" },
                    new Category { ID = 14, CategoryName = "Süt ve Süt Ürünleri" },
                    new Category { ID = 15, CategoryName = "Tahıllı Gevrekler" }
               );
        }
    }
}