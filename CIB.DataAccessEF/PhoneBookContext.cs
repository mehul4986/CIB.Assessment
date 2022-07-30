using CIB.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CIB.DataAccessEF
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext(DbContextOptions options) : base(options) { }
        public DbSet<PhoneBook> PhoneBook { get; set; }
        public DbSet<Entry> Entry { get; set; }

    }
}
