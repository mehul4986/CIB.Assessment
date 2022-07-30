using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIB.Domain.ViewModel
{
    public class EntryViewModel
    {
        public string EntryName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
