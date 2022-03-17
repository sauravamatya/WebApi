using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [Authorize]
        [HttpGet("CustomerList")]
        public IActionResult GetCustomerList() {
            List<Customer> cs_list = new List<Customer>();
            cs_list.Add(new Customer
            {
                CustomerName = "Saurab Amatya",
                CustomerId = 1011,
                MobileNumber = "94342323",
                Address = "Lalitpur"
            }
            
            );
            cs_list.Add(new Customer
            {
                CustomerName = "Alisha Amatya",
                CustomerId = 1012,
                MobileNumber = "943423768",
                Address = "Kathmandu"
            }
        

    );
            return Ok(cs_list);
        }

        [Authorize]
        [HttpGet("BankList")]
        public IActionResult GetBankList()
        {
            List<Bank> cs_list = new List<Bank>();
            cs_list.Add(new Bank
            {
                BankId = 01,
                BankName = "Nic Asia",
                BankCode="002426",
                Branch="Kupoundol"
            }

            );
            cs_list.Add(new Bank
            {
                BankId = 02,
                BankName = "Nabil Bank",
                BankCode = "002436",
                Branch = "Pulchowk"
            }

          );
            return Ok(cs_list);
        }
    }
}
