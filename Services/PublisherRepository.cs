using BooksellerApp.Data;
using BooksellerApp.Models;

namespace BooksellerApp.Services
{
    internal class PublisherRepository : BaseRepository<Publisher>
    {
        public PublisherRepository(SahafDBContext context) : base(context)
        {
        }
    }
}
