using Microsoft.EntityFrameworkCore;
using BooksellerApp.Data;

namespace BooksellerApp.Services
{
    //Generic Repository
    internal class BaseRepository<TEntity> where TEntity : class
    {
        protected SahafDBContext _context;
        protected DbSet<TEntity> table;

        //ctor injection...
        public BaseRepository(SahafDBContext context)
        {
            _context = context;
            table = context.Set<TEntity>();
        }
        public void ForAdd(TEntity entity)
        {
            table.Add(entity);
            _context.SaveChanges();
        }
        public void ForUpdate(TEntity entity)
        {
            table.Update(entity);
            _context.SaveChanges();
        }
        public TEntity ForSearch(int id)
        {
            return table.Find(id);
        }
        public void ForDelete(int id)
        {
            table.Remove(ForSearch(id));
            _context.SaveChanges();
        }
        public List<TEntity> ForList()
        {
            return table.ToList();
        }
    }
}
