using BooksellerApp.Data;
using BooksellerApp.Models;

namespace BooksellerApp.Services
{
    internal class AuthorRepository : BaseRepository<Author>
    {
        public AuthorRepository(SahafDBContext context) : base(context)
        {
        }
    }
}
