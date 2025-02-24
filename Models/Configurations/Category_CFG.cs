using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksellerApp.Models.Configurations
{
    internal class Category_CFG : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Varsayılan Category ekleme işlemi
            builder.HasData(new Category { CategoryID = 1, CategoryName = "Korku" });
            builder.HasData(new Category { CategoryID = 2, CategoryName = "Macera" });
            builder.HasData(new Category { CategoryID = 3, CategoryName = "Aksiyon" });
            builder.HasData(new Category { CategoryID = 4, CategoryName = "Bilim Kurgu" });
            builder.HasData(new Category { CategoryID = 5, CategoryName = "Romantik" });
            builder.HasData(new Category { CategoryID = 6, CategoryName = "Komedi" });
            builder.HasData(new Category { CategoryID = 7, CategoryName = "Dram" });
            builder.HasData(new Category { CategoryID = 8, CategoryName = "Gerilim" });
            builder.HasData(new Category { CategoryID = 9, CategoryName = "Belgesel" });

            //Sql server içerisindeki Category tablosunun parametrelerinin düzenlenmesi
            builder.Property(x => x.CategoryName).
               HasColumnType("nvarchar").
               HasMaxLength(50).
               IsRequired();

        }
    }
}
