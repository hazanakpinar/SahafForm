using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksellerApp.Models.Configurations
{
    internal class Publisher_CFG : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            ////Varsayılan Publisher ekleme işlemi
            builder.HasData(new Publisher { PublisherID= 1, PublisherName = "Ornek Yayinevi" });

            //Sql server içerisindeki Publisher tablosunun parametrelerinin düzenlenmesi
            builder.Property(x => x.PublisherName).
               HasColumnType("nvarchar").
               HasMaxLength(50).
               IsRequired();
        }
    }
}
