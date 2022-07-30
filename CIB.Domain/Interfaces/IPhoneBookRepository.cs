using CIB.Domain.Models;

namespace CIB.Domain.Interfaces
{
    public interface IPhoneBookRepository : IGenericRepository<PhoneBook>
    {
        IEnumerable<PhoneBookList> GetAllPhoneBook();
    }
}
