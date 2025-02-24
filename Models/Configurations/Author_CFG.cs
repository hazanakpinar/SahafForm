using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksellerApp.Models.Configurations
{
    internal class Author_CFG : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            //Varsayılan Author ekleme işlemi
            builder.HasData(new Author { AuthorID = 1, AuthorName = "J.K. Rowling" });
            builder.HasData(new Author { AuthorID = 2, AuthorName = "George Orwell" });
            builder.HasData(new Author { AuthorID = 3, AuthorName = "Jane Austen" });
            builder.HasData(new Author { AuthorID = 4, AuthorName = "Stephen King" });
            builder.HasData(new Author { AuthorID = 5, AuthorName = "Gabriel García Márquez" });

            //Sql server içerisindeki Author tablosunun parametrelerinin düzenlenmesi
            builder.Property(x => x.AuthorName).
            HasColumnType("nvarchar").
            HasMaxLength(50).
            IsRequired();
        }
    }
}
