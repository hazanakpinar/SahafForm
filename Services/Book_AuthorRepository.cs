using BooksellerApp.Data;
using BooksellerApp.Models;

namespace BooksellerApp.Services
{
    internal class Book_AuthorRepository : BaseRepository<Book_Author>
    {
        public Book_AuthorRepository(SahafDBContext context) : base(context)
        {
            _context = context;
        }
        public List<Book_Author> GetAllBookAuthors()
        {
            return _context.BookAuthors.ToList();
        }
    }
}
