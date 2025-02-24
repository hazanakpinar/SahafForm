using Microsoft.EntityFrameworkCore;
using BooksellerApp.Data;
using BooksellerApp.Models;
namespace BooksellerApp.Services
{
    internal class BookRepository : BaseRepository<Book>
    {
        public BookRepository(SahafDBContext context) : base(context)
        {
            _context = context;
        }
        // Tüm Kitapların Listesi 
        public IEnumerable<object> GetAllBooks()
        {
            return _context.Books
                 .Include(b => b.User)
                 .Include(b => b.Category)
                 .Include(b => b.Publisher)
                 .Include(b => b.Book_Authors)
                 .ThenInclude(b => b.Author)
                 .Select(b => new
                 {
                     BookId = b.BookID,
                     Title = b.Title,
                     Price = b.Price,
                     PublicationYear = b.PublicationYear,
                     EditionNumber = b.EditionNumber,
                     Summary = b.Summary,
                     Category = b.Category.CategoryName,
                     AuthorNames = string.Join(", ", b.Book_Authors.Select(ba => ba.Author.AuthorName)),
                     Publisher = b.Publisher.PublisherName,
                     UserName = b.User.UserName,
                 })
                 .ToList();
        }

        // Bir kategoriye ait tüm kitapların listesi
        public IEnumerable<object> GetBooksByCategory(int categoryId)
        {
            return _context.Books
                .Where(b => b.CategoryID == categoryId)
                .Include(b => b.Book_Authors)
                .Include(b => b.Publisher)
                .Include(b => b.Category)
                .Select(b => new
                {
                    BookId = b.BookID,
                    Category = b.Category.CategoryName,
                    Title = b.Title,
                    Price = b.Price,
                    PublicationYear = b.PublicationYear,
                    EditionNumber = b.EditionNumber,
                    Summary = b.Summary,
                    Publisher = b.Publisher.PublisherName,
                    UserName = b.User.UserName,
                    AuthorNames = string.Join(", ", b.Book_Authors.Select(ba => ba.Author.AuthorName)),
                })
                .ToList();
        }

        // Bir yazara ait tüm kitaplarının listesi
        public IEnumerable<object> GetBooksByAuthor(int authorId)
        {
            return _context.Books
                .Where(b => b.Book_Authors.Any(ba => ba.AuthorID == authorId))
                .Include(b => b.Book_Authors)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Select(b => new
                {
                    BookId = b.BookID,
                    AuthorNames = string.Join(", ", b.Book_Authors.Select(ba => ba.Author.AuthorName)),
                    Title = b.Title,
                    Price = b.Price,
                    PublicationYear = b.PublicationYear,
                    EditionNumber = b.EditionNumber,
                    Summary = b.Summary,
                    Category = b.Category.CategoryName,
                    Publisher = b.Publisher.PublisherName,
                    UserName = b.User.UserName,
                })
                .ToList();
        }

        // Bir yayınevine ait tüm kitaplarının listesi
        public IEnumerable<object> GetBooksByPublisher(int publisherId)
        {
            return _context.Books
                .Where(b => b.PublisherID == publisherId)
                .Include(b => b.Book_Authors)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Select(b => new
                {
                    BookId = b.BookID,
                    Publisher = b.Publisher.PublisherName,
                    Title = b.Title,
                    Price = b.Price,
                    PublicationYear = b.PublicationYear,
                    EditionNumber = b.EditionNumber,
                    Summary = b.Summary,
                    Category = b.Category.CategoryName,
                    UserName = b.User.UserName,
                    AuthorNames = string.Join(", ", b.Book_Authors.Select(ba => ba.Author.AuthorName)),
                })
                .ToList();
        }

        // Bir çalışan tarafından girilen tüm kitapların listesi
        public IEnumerable<object> GetBooksUser(int userId)
        {
            return _context.Books
                .Where(b => b.UserID == userId)
                .Include(b => b.User)
                .Select(b => new
                {
                    BookId = b.BookID,
                    UserName = b.User.UserName,
                    Title = b.Title,
                    Price = b.Price,
                    PublicationYear = b.PublicationYear,
                    EditionNumber = b.EditionNumber,
                    Summary = b.Summary,
                    Category = b.Category.CategoryName,
                    Publisher = b.Publisher.PublisherName,
                    AuthorNames = string.Join(", ", b.Book_Authors.Select(ba => ba.Author.AuthorName)),
                })
                .ToList();
        }

        // Sisteme en son girilen 10 kitabın listelemesi
        public IEnumerable<object> GetLatestBooks()
        {
            return _context.Books
                .OrderByDescending(b => b.BookID)
                .Take(10)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Include(b => b.User)
                .Select(b => new
                {
                    BookId = b.BookID,
                    Title = b.Title,
                    Price = b.Price,
                    PublicationYear = b.PublicationYear,
                    EditionNumber = b.EditionNumber,
                    Summary = b.Summary,
                    Category = b.Category.CategoryName,
                    Publisher = b.Publisher.PublisherName,
                    UserName = b.User.UserName,
                    AuthorNames = string.Join(", ", b.Book_Authors.Select(ba => ba.Author.AuthorName))
                })
                .ToList();
        }

        // Belirli fiyat aralığında olan kitapların listesi
        public IEnumerable<object> GetBooksByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _context.Books
                .Where(b => b.Price >= minPrice && b.Price <= maxPrice)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Select(b => new
                {
                    BookId = b.BookID,
                    Title = b.Title,
                    Price = b.Price,
                    PublicationYear = b.PublicationYear,
                    EditionNumber = b.EditionNumber,
                    Summary = b.Summary,
                    Category = b.Category.CategoryName,
                    Publisher = b.Publisher.PublisherName,
                    UserName = b.User.UserName,
                    AuthorNames = string.Join(", ", b.Book_Authors.Select(ba => ba.Author.AuthorName))
                })
                .ToList();
        }
        //Kitap güncellemek için özel metot
        public void UpdateBook(Book updatedBook)
        {
            // Mevcut kitabı veritabanından bul
            var existingBook = ForSearch(updatedBook.BookID);

            if (existingBook != null)
            {
                // Güncellenmiş kitabın verilerini mevcut kitaba aktar
                existingBook.Title = updatedBook.Title;
                existingBook.PublicationYear = updatedBook.PublicationYear;
                existingBook.EditionNumber = updatedBook.EditionNumber;
                existingBook.Price = updatedBook.Price;
                existingBook.Summary = updatedBook.Summary;
                existingBook.CategoryID = updatedBook.CategoryID;
                existingBook.PublisherID = updatedBook.PublisherID;
                existingBook.UserID = updatedBook.UserID;

                // Değişiklikleri kaydet
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Book not found");
            }
        }
    }
}
