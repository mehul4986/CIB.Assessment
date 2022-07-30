using CIB.Domain.Interfaces;
using CIB.Domain.Models;


namespace CIB.DataAccessEF.TypeRepository
{
    class EntryRepository : GenericRepository<Entry>, IEntryRepository
    {
        public EntryRepository(PhoneBookContext context) : base(context) { }
    }
}
