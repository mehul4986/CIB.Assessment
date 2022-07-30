namespace CIB.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEntryRepository Entry { get; }
        IPhoneBookRepository PhoneBook { get; }
        int Save();
    }
}
