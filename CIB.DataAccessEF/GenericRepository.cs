using CIB.Domain.Interfaces;
using System.Linq.Expressions;

namespace CIB.DataAccessEF
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly PhoneBookContext _context;

        public GenericRepository(PhoneBookContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            //_context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
