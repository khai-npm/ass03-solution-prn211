using BusinessObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;

namespace eFURentingManagement.Controllers
{
    public class RegisterController : Controller

    {
        ICustomerRepository _customerRepository = new CustomerRepository();

        public IActionResult Register2()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(string emailaddress, string memberpassword, string confirmpassword, string username
                                   ,string telephone, DateTime birthday)
        {
            Customer c = _customerRepository.GetCustomerByEmail(emailaddress);
            if (c != null) {
                ViewBag.EmailExistError = "ERROR: email adress already exist ! ";
                return View(nameof(Index));
            }

            if (memberpassword != confirmpassword)
            {
                ViewBag.ConfirmPasswordError = "ERROR: confirm password does not match !";
                return View(nameof(Index));
            }

            if (emailaddress==null || memberpassword==null || username==null || telephone==null || birthday == null)
            {
                ViewBag.EmailExistError = "ERROR: Some of field is empty !";
                return View(nameof(Index));
            }

            DateTime newBirthdate = Convert.ToDateTime(birthday);
            Customer nc = new Customer();
            nc.Email = emailaddress;
            nc.Password = memberpassword;
            nc.CustomerName = username;
            nc.Telephone = telephone;
            nc.CustomerBirthday = newBirthdate;
            nc.CustomerStatus = 1;

            _customerRepository.Register(nc);
            return Redirect("../Login");
        }
    }
}
