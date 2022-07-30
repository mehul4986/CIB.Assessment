using CIB.Domain.Interfaces;
using CIB.Domain.Models;
using CIB.Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CIB.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoneBookController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IPhoneBookRepository _phoneBookRepository;

        public PhoneBookController(IUnitOfWork unitOfWork, IPhoneBookRepository phoneBookRepository)
        {
            this.unitOfWork = unitOfWork;
            _phoneBookRepository = phoneBookRepository;
        }

        [HttpGet]
        public IEnumerable<PhoneBookList> GetAllPhoneBook()
        {
            return _phoneBookRepository.GetAllPhoneBook();
        }


        // POST api/<ValuesController>
        [HttpPost]
        public void Post(PhoneBook phone)
        {
            unitOfWork.PhoneBook.Add(phone);
        }



    }
}
