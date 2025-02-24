using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksellerApp.Models.Configurations
{
    internal class Book_CFG : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //Varsayılan Book ekleme işlemi
            builder.HasData(
                new Book { BookID = 1, EditionNumber = 1, Price = 10, CategoryID = 1, PublicationYear = 2024, Title = "Yazılıma Giriş", Summary = "Merhaba", PublisherID = 1, UserID = 1 },
                new Book { BookID = 2, EditionNumber = 2, Price = 25.50m, CategoryID = 2, PublicationYear = 2023, Title = "C# ve .NET", Summary = "C# programlama dili ve .NET framework hakkında derinlemesine bilgi.", PublisherID = 1, UserID = 2 },
                new Book { BookID = 3, EditionNumber = 1, Price = 18.75m, CategoryID = 3, PublicationYear = 2022, Title = "Veritabanı Yönetimi", Summary = "Veritabanı yönetimi ve SQL konularını kapsayan kapsamlı bir rehber.", PublisherID = 1, UserID = 2 },
                new Book { BookID = 4, EditionNumber = 3, Price = 29.99m, CategoryID = 4, PublicationYear = 2021, Title = "Web Geliştirme Temelleri", Summary = "Web geliştirme için gerekli temel bilgiler ve teknolojiler.", PublisherID = 1, UserID = 2 },
                new Book { BookID = 5, EditionNumber = 2, Price = 35.00m, CategoryID = 5, PublicationYear = 2023, Title = "Mobil Uygulama Geliştirme", Summary = "Mobil uygulama geliştirme sürecine dair kapsamlı bir rehber.", PublisherID = 1, UserID = 2 },
                new Book { BookID = 6, EditionNumber = 1, Price = 22.50m, CategoryID = 1, PublicationYear = 2024, Title = "Python Programlama", Summary = "Python dilinin temelleri ve uygulama alanları.", PublisherID = 1, UserID = 2 },
                new Book { BookID = 7, EditionNumber = 4, Price = 45.00m, CategoryID = 6, PublicationYear = 2022, Title = "Makine Öğrenmesi", Summary = "Makine öğrenmesi teknikleri ve uygulamaları üzerine detaylı bilgiler.", PublisherID = 1, UserID = 1 },
                new Book { BookID = 8, EditionNumber = 1, Price = 40.00m, CategoryID = 7, PublicationYear = 2021, Title = "Siber Güvenlik", Summary = "Siber güvenlik önlemleri ve tehditler hakkında kapsamlı bir inceleme.", PublisherID = 1, UserID = 2 },
                new Book { BookID = 9, EditionNumber = 3, Price = 15.75m, CategoryID = 4, PublicationYear = 2024, Title = "Algoritmalar ve Veri Yapıları", Summary = "Temel algoritmalar ve veri yapıları hakkında kapsamlı bilgi.", PublisherID = 1, UserID = 2 },
                new Book { BookID = 10, EditionNumber = 2, Price = 30.00m, CategoryID = 5, PublicationYear = 2023, Title = "Oyun Geliştirme", Summary = "Oyun geliştirme süreci ve kullanılan teknolojiler üzerine bir rehber.", PublisherID = 1, UserID = 2 }
                );

            //Sql server içerisindeki Book tablosunun parametrelerinin düzenlenmesi
            builder.Property(x => x.Title).
               HasColumnType("nvarchar").
               HasMaxLength(50).
               IsRequired();

            builder.Property(x => x.Price).
               HasColumnType("money").
               IsRequired();

            builder.Property(x => x.Summary).
               HasColumnType("nvarchar").
               HasMaxLength(500);

        }
    }
}
