using BooksellerApp.Data;
using BooksellerApp.Models;

namespace BooksellerApp.Services
{
    internal class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(SahafDBContext context) : base(context)
        {
        }
    }
}
