using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIB.Domain.Models
{
    public class PhoneBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int PhoneBookId { get; set; }
        public string PhoneBookName { get; set; }
        public List<Entry> Entires { get; set; }
    }

    public class PhoneBookList
    {
        public string PhoneBookName { get; set; }
        public string EntryName { get; set; }
        public string PhoneNumber { get; set; }
    }

}
