using CIB.Domain.Interfaces;
using CIB.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CIB.DataAccessEF.TypeRepository
{
    public class PhoneBookRepository : GenericRepository<PhoneBook>, IPhoneBookRepository
    {
        PhoneBookContext _context = null;
        public PhoneBookRepository(PhoneBookContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<PhoneBookList> GetAllPhoneBook()
        {
            var phoneBooks = _context.
                PhoneBook.
                Include(x => x.Entires)
                .ToList();

            List<PhoneBookList> phoneBookLists = new List<PhoneBookList>();

            foreach (var itmPB in phoneBooks)
            {
                foreach (var itmE in itmPB.Entires)
                {
                    phoneBookLists.Add(new PhoneBookList
                    {
                        PhoneBookName = itmPB.PhoneBookName,
                        EntryName = itmE.EntryName,
                        PhoneNumber = itmE.PhoneNumber
                    });
                }
            }

            return phoneBookLists;
        }
    }
}
