using BooksellerApp.Data;
using BooksellerApp.Models;

namespace BooksellerApp.Services
{
    internal class UserRepository : BaseRepository<User>
    {
        public UserRepository(SahafDBContext context) : base(context)
        {
        }
    }
}
