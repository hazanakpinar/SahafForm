using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksellerApp.Models.Configurations
{
    internal class Book_Author_CFG : IEntityTypeConfiguration<Book_Author>
    {
        public void Configure(EntityTypeBuilder<Book_Author> builder)
        {
            //Varsayılan Book_Author ekleme işlemi
            builder.HasData(new Book_Author { Book_AuthorID = 1, BookID = 1, AuthorID = 1 },
                            new Book_Author { Book_AuthorID = 2, BookID = 1, AuthorID = 2 },
                            new Book_Author { Book_AuthorID = 3, BookID = 2, AuthorID = 2 },
                            new Book_Author { Book_AuthorID = 4, BookID = 3, AuthorID = 3 },
                            new Book_Author { Book_AuthorID = 5, BookID = 4, AuthorID = 1 },
                            new Book_Author { Book_AuthorID = 6, BookID = 4, AuthorID = 4 },
                            new Book_Author { Book_AuthorID = 7, BookID = 4, AuthorID = 5 },
                            new Book_Author { Book_AuthorID = 8, BookID = 5, AuthorID = 5 },
                            new Book_Author { Book_AuthorID = 9, BookID = 6, AuthorID = 5 },
                            new Book_Author { Book_AuthorID = 10, BookID = 7, AuthorID = 4 },
                            new Book_Author { Book_AuthorID = 11, BookID = 8, AuthorID = 3 },
                            new Book_Author { Book_AuthorID = 12, BookID = 9, AuthorID = 1 },
                            new Book_Author { Book_AuthorID = 13, BookID = 9, AuthorID = 2 },
                            new Book_Author { Book_AuthorID = 14, BookID = 9, AuthorID = 3 },
                            new Book_Author { Book_AuthorID = 15, BookID = 9, AuthorID = 4 },
                            new Book_Author { Book_AuthorID = 16, BookID = 9, AuthorID = 5 },
                            new Book_Author { Book_AuthorID = 17, BookID = 10, AuthorID = 1 });
        }
    }
}
