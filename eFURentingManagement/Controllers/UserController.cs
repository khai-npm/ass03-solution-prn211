using BusinessObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using static System.Collections.Specialized.BitVector32;

namespace eFURentingManagement.Controllers
{
    public class UserController : Controller
    {
        ICustomerRepository _customerRepository = new CustomerRepository();
        public IActionResult SubmitUpdate(string emailaddress, string memberpassword, string confirmpassword, string username
                                   , string telephone, DateTime birthday)
        {
            var Session = HttpContext.Session;
            string userMail = Session.GetString("email");
            Customer c = _customerRepository.GetCustomerByEmail(emailaddress);

            if (memberpassword != confirmpassword)
            {
                Session.SetString("email", c.Email);
                ViewBag.ConfirmPasswordError = "ERROR: confirm password does not match !";
                return View(nameof(Update));
            }

            DateTime newBirthdate = Convert.ToDateTime(birthday);
            Customer nc = new Customer();
            c.Email = emailaddress;
            c.Password = memberpassword;
            c.CustomerName = username;
            c.Telephone = telephone;
            c.CustomerBirthday = newBirthdate;
            c.CustomerStatus = 1;

            _customerRepository.Update(c);
             Session.SetString("Role", "User");
            Session.SetString("Username", c.CustomerName);
            Session.SetString("email", c.Email);
            return Redirect("../Login");
        }

        public IActionResult Update()
        {
            var Session = HttpContext.Session;
            string userMail = Session.GetString("email");
            Customer c = _customerRepository.GetCustomerByEmail(userMail);
            ViewBag.Mail = c.Email;
            ViewBag.name = c.CustomerName;
            ViewBag.phone = c.Telephone;
            ViewBag.date = c.CustomerBirthday;
            Session.SetString("email", userMail);
            return View();
        }
        public IActionResult Deactivate()
        {
            var Session = HttpContext.Session;
            string userMail = Session.GetString("email");
            Session.SetString("email", userMail);
            return View();
        }

        public IActionResult DeactiveSubmit(Boolean checkbox)
        {

                var Session = HttpContext.Session;
                string userMail = Session.GetString("email");
                Customer c = _customerRepository.GetCustomerByEmail(userMail);
                c.CustomerStatus = 0;
                _customerRepository.Update(c);
                return Redirect("../Login");
 
        }
        public IActionResult Index()
        {
            
            var Session = HttpContext.Session;
            String role = Session.GetString("Role");
            String email = Session.GetString("email");
            Customer c = _customerRepository.GetCustomerByEmail(email);

            if (c!=null && role!=null)
            {
                String user = Session.GetString(c.CustomerName);
                string userMail = Session.GetString(c.Email);
                ViewBag.Email = c.CustomerName;
                ViewBag.RealEmail = c.Email;
                return View();
            }
            else
            {
                return Redirect("../Login");
            }

        }
    }
}
