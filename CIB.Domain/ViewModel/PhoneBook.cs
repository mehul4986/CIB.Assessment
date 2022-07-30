using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIB.Domain.ViewModel
{
    public class PhoneBookViewModel
    {
        public string PhoneBookName { get; set; }
        public List<EntryViewModel> Entires { get; set; }
    }

}
