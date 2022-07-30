using CIB.DataAccessEF.TypeRepository;
using CIB.Domain.Interfaces;

namespace CIB.DataAccessEF
{
    public class UnitOfWork : IUnitOfWork
    {
        private PhoneBookContext _context;

        public UnitOfWork(PhoneBookContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            //_context = context;
            PhoneBook = new PhoneBookRepository(_context);
            Entry = new EntryRepository(_context);
        }

        public IPhoneBookRepository PhoneBook { get; private set; }
        public IEntryRepository Entry { get; private set; }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
