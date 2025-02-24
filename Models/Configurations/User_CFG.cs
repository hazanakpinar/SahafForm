using ConsoleApp1.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksellerApp.Models.Configurations
{
    internal class User_CFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Varsayılan User ekleme işlemi
            builder.HasData(new User { UserID = 1, UserName="Admin", Password =HashUtility.MdFive( "0000" )});
            builder.HasData(new User { UserID = 2, UserName="Kullanici", Password =HashUtility.MdFive( "12345" )});

            //Sql server içerisindeki User tablosunun parametrelerinin düzenlenmesi
            builder.Property(x => x.UserName).
               HasColumnType("nvarchar").
               HasMaxLength(20).
               IsRequired();

            builder.Property(x => x.Password).
               HasColumnType("nvarchar").
               HasMaxLength(50).
               IsRequired();
        }
    }
}
